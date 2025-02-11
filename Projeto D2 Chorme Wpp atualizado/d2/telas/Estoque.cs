using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;
using MySql.Data.MySqlClient;


namespace d2
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();

            checkEstoque.Checked = true;
            checkRetirado.Checked = true;
        }

        private void CarregarDados()
        {
            using (SqlConnection conectar = new SqlConnection(classBd.d2))
            {
                conectar.Open();

                using (SqlCommand pegardados = new SqlCommand("SELECT * FROM tb_Estoque", conectar))
                {
                    DataTable filtrar = new DataTable();

                    using (SqlDataAdapter resp = new SqlDataAdapter(pegardados))
                    {
                        resp.Fill(filtrar);
                    }

                    DataView versituacao = filtrar.DefaultView;
                    List<string> filtros = new List<string>();

                    // Verifica se o usuário digitou "todos" para exibir todos os registros
                    if (!string.IsNullOrWhiteSpace(txtPesquisar.Text) && txtPesquisar.Text.ToLower() != "todos")
                    {
                        string pesquisar = txtPesquisar.Text.Replace("'", "''"); // Evita problemas com aspas simples
                        filtros.Add($"(nomecliente LIKE '%{pesquisar}%' OR loja LIKE '%{pesquisar}%')");
                    }

                    // Adiciona filtros de situação com base nos checkboxes
                    List<string> situacaoFiltros = new List<string>();

                    if (checkEstoque.Checked)
                    {
                        situacaoFiltros.Add("situacao = 'Estoque'");
                    }
                    if (checkRetirado.Checked)
                    {
                        situacaoFiltros.Add("situacao = 'Retirado'");
                    }

                    // Se houver filtros de situação, adiciona ao filtro principal
                    if (situacaoFiltros.Count > 0)
                    {
                        filtros.Add("(" + string.Join(" OR ", situacaoFiltros) + ")");
                    }

                    // Aplica o filtro final
                    versituacao.RowFilter = filtros.Count > 0 ? string.Join(" AND ", filtros) : "";

                    // Atualiza o DataGridView
                    tbEstoque.DataSource = versituacao;
                }
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você deseja voltar para a tela principal?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                var home = new Home();
                home.Show(this);
                this.Visible = false;
            }
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'd2Estoque.tb_Estoque'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_EstoqueTableAdapter.Fill(this.d2Estoque.tb_Estoque);

        }

        private void COUNTEstoque()
        {
            bool idExists = false;

            using (var conectar = new SqlConnection(classBd.d2))
            {
                conectar.Open();
                using (var procurarID = new SqlCommand("SELECT COUNT(*) FROM tb_Estoque WHERE id = @id", conectar))
                {
                    procurarID.Parameters.AddWithValue("@id", Convert.ToInt32(txtId.Text));
                    idExists = (int)procurarID.ExecuteScalar() > 0;
                }
            }

            if (!idExists)
            {
                MessageBox.Show("O ID informado não existe.");
                return;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, insira um ID válido para selecionar.");
                txtId.Focus();
                return;
            }

            COUNTEstoque();

            DataTable estoque = classEstoque.selectestoque(Convert.ToInt32(txtId.Text));

            if (estoque.Rows.Count > 0)
            {
                // Preenchendo os campos de texto com valores do banco
                txtLoja.Text = estoque.Rows[0].Field<string>("loja");
                txtIdCliente.Text = estoque.Rows[0].Field<int>("pk_idCliente").ToString(); // Convertendo int para string
                txtQuantidade.Text = estoque.Rows[0].Field<int>("quantidade").ToString(); // Convertendo int para string
                txtNomeRetirada.Text = estoque.Rows[0].Field<string>("nomeretirada");
                txtNomeCliente.Text = estoque.Rows[0].Field<string>("nomecliente");
                txtCPF.Text = estoque.Rows[0].Field<string>("cpf");

                // Tratamento para valores nulos (DBNull)
                txtValor.Text = estoque.Rows[0].IsNull("valor") ? "" : estoque.Rows[0].Field<decimal>("valor").ToString("F2");

                // Tratamento para valores nulos (DBNull) em DateTime e conversão para string no formato desejado
                txtDregistro.Text = estoque.Rows[0].IsNull("dregistro") ? "" : estoque.Rows[0].Field<DateTime>("dregistro").ToString("dd/MM/yyyy HH:mm:ss");
                txtDretirada.Text = estoque.Rows[0].IsNull("dretirada") ? "" : estoque.Rows[0].Field<DateTime>("dretirada").ToString("dd/MM/yyyy HH:mm:ss");

                // Exibindo a situação do pacote (Em Estoque ou Retirado) nos RadioButtons
                string situacao = estoque.Rows[0].Field<string>("situacao");

                if (situacao == "Estoque")
                {
                    radioEstoque.Checked = true;
                    radioRetirado.Checked = false;
                }
                else if (situacao == "Retirado")
                {
                    radioEstoque.Checked = false;
                    radioRetirado.Checked = true;
                }
            }
            else
            {
                MessageBox.Show("Não existe registro no estoque com o ID informado.");
            }
        }

        private void COUNTCliente()
        {
            bool idExists = false;

            using (var conectar = new SqlConnection(classBd.d2))
            {
                conectar.Open();
                using (var procurarID = new SqlCommand("SELECT COUNT(*) FROM tb_Cliente WHERE id = @id", conectar))
                {
                    procurarID.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdCliente.Text));
                    idExists = (int)procurarID.ExecuteScalar() > 0;
                }
            }
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdCliente.Text))
            {
                MessageBox.Show("Por favor, insira o ID de um cliente.");
                txtIdCliente.Focus();
                return;
            }

            COUNTCliente();

            DataTable cliente = classCliente.selectcliente(Convert.ToInt32(txtIdCliente.Text));


            if (cliente.Rows.Count > 0)
            {
                txtNomeCliente.Text = cliente.Rows[0].Field<string>("nome");
            }
            else
            {
                MessageBox.Show("Não existe registro de cliente com o ID informado.");
                txtIdCliente.Focus();
            }
        }

        private void checkEstoque_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void checkRetirado_CheckedChanged(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private bool ValidarCampo()
        {

            if (string.IsNullOrWhiteSpace(txtLoja.Text))
            {
                MessageBox.Show("O nome da loja é obrigatório.");
                txtLoja.Focus();
                return true;
            }

            if (string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("A quantidade é obrigatória.");
                txtQuantidade.Focus();
                return true;
            }


            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidarCampo())
            {
                // Verifica se o radio button de estoque ou retirado está marcado
                if (!radioEstoque.Checked && !radioRetirado.Checked)
                {
                    MessageBox.Show("Por favor, indicar se o pacote está em estoque ou retirado.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    var resultado = MessageBox.Show("Você tem certeza que deseja registrar esse pacote?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                    if (resultado == DialogResult.OK)
                    {
                        try
                        {
                            classEstoque p = new classEstoque();

                            // Captura os dados
                            p.nomecliente = txtNomeCliente.Text;
                            p.loja = txtLoja.Text;
                            p.nomeretirada = txtNomeRetirada.Text;
                            p.cpf = txtCPF.Text;
                            p.pk_idCliente = int.Parse(txtIdCliente.Text); // O ID do cliente é obrigatório
                            p.quantidade = int.Parse(txtQuantidade.Text);  // Conversão de quantidade
                            p.valor = 0; // Valor inicialmente 0, será atualizado se o pacote for retirado

                            // Verifica a situação do pacote
                            string situacao = radioEstoque.Checked ? "Estoque" : "Retirado";
                            p.situacao = situacao;

                            // Validação adicional para pacotes retirados
                            if (situacao == "Retirado")
                            {
                                if (string.IsNullOrWhiteSpace(p.nomeretirada) || p.valor <= 0)
                                {
                                    MessageBox.Show("Para pacotes retirados, é obrigatório preencher o Nome de Retirada e Valor.",
                                        "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                                p.valor = decimal.Parse(txtValor.Text); // Só atualiza o valor se for retirado
                            }

                            // Registro no banco de dados
                            classEstoque.addestoque(p);

                            // Transição para a próxima tela
                            var estoque = new Estoque();
                            estoque.Show(this);
                            this.Visible = false;
                        }   
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Por favor, insira um ID para alterar.");
                txtId.Focus();
                return;
            }

            if (!ValidarCampo())
            {
                var resultado = MessageBox.Show("Você tem certeza que deseja atualizar esse pacote?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK)
                {
                    try
                    {
                        classEstoque p = new classEstoque();

                        // Captura e converte os dados (int ou decimal onde necessário)
                        p.id = int.Parse(txtId.Text);         // ID do pacote (necessário para a atualização)
                        p.nomecliente = txtNomeCliente.Text;
                        p.loja = txtLoja.Text;
                        p.cpf = txtCPF.Text;

                        // Conversões de tipos com verificações de preenchimento
                        if (!string.IsNullOrWhiteSpace(txtIdCliente.Text))
                        {
                            p.pk_idCliente = int.Parse(txtIdCliente.Text);
                        }

                        if (!string.IsNullOrWhiteSpace(txtQuantidade.Text))
                        {
                            p.quantidade = int.Parse(txtQuantidade.Text);
                        }

                        // Permite txtValor vazio e define como 0 se não for preenchido
                        p.valor = !string.IsNullOrWhiteSpace(txtValor.Text) ? decimal.Parse(txtValor.Text) : 0;

                        // Verifica situação do pacote (Estoque ou Retirado)
                        string situacao = radioEstoque.Checked ? "Estoque" : "Retirado";
                        p.situacao = situacao;

                        // Validação adicional para pacotes retirados
                        if (situacao == "Retirado")
                        {
                            if (string.IsNullOrWhiteSpace(txtNomeRetirada.Text))
                            {
                                MessageBox.Show("Para pacotes retirados, é obrigatório preencher o nome de quem retirou o pacote.",
                                    "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                            p.nomeretirada = txtNomeRetirada.Text; // Nome de Retirada
                        }
                        else
                        {
                            // Quando o pacote está em "Estoque", os campos opcionais podem ser ignorados
                            p.nomeretirada = string.Empty;
                        }

                        // Atualização no banco de dados
                        classEstoque.attestoque(p);

                        // Transição para a próxima tela
                        var estoque = new Estoque();
                        estoque.Show(this);
                        this.Visible = false;
                    }
                    catch (FormatException)
                    {
                        MessageBox.Show("Por favor, preencha os campos de ID e Quantidade corretamente (somente números).",
                            "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o campo ID está preenchido
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, insira o ID do pacote que deseja excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                    return;
                }

                // Pede confirmação antes de excluir
                var resultado = MessageBox.Show("Você tem certeza que deseja excluir este pacote?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Converte o ID para int
                    int id = int.Parse(txtId.Text);

                    // Chama o método de exclusão
                    classEstoque.deleteestoque(id);

                    // Mensagem de sucesso
                    MessageBox.Show("Pacote excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza ou redireciona para outra tela, se necessário
                    var estoque = new Estoque();
                    estoque.Show(this);
                    this.Visible = false;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor, insira um ID válido (somente números).", "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Limpar()
        {
            txtId.Clear();
            txtIdCliente.Clear();
            txtNomeCliente.Clear();
            txtCPF.Clear();
            txtLoja.Clear();
            txtNomeRetirada.Clear();
            txtQuantidade.Clear();
            txtValor.Clear();
            txtDregistro.Clear();
            txtDretirada.Clear();
            radioEstoque.Checked = false;
            radioRetirado.Checked = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você deseja limpar todos os campos?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                Limpar();
            }
        }
        private string BuscarTel1(string idCliente)
        {
            string query = "SELECT telefone FROM tb_Cliente WHERE id = @idCliente";

            string telefone1 = null;

            using (SqlConnection connection = new SqlConnection(classBd.d2))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCliente", txtIdCliente.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            telefone1 = reader["telefone"]?.ToString();
                            return telefone1;
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                }
            }
        }

        private string BuscarTel2(string idCliente)
        {
            string query = "SELECT telefone2 FROM tb_Cliente WHERE id = @idCliente";

            string telefone2 = null;

            using (SqlConnection connection = new SqlConnection(classBd.d2))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idCliente", txtIdCliente.Text);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            telefone2 = reader["telefone2"]?.ToString();
                            return telefone2;
                        }
                        else
                        {
                            return string.Empty;
                        }
                    }
                }
            } 
        }

        private string FormatarMensagem(string nomeCliente, string mensagemBase)
        {
            return $"Olá, {nomeCliente}! {mensagemBase}";
        }

        private void btnWpp1_Click(object sender, EventArgs e)
        {
            try
            {
                string idCliente = txtIdCliente.Text;
                string nomeCliente = txtNomeCliente.Text;
                string idPacote = txtId.Text;

                if (string.IsNullOrEmpty(idCliente) || string.IsNullOrEmpty(idPacote))
                {
                    MessageBox.Show("Por favor, selecione um ID de pacote.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                    return;
                }

                // Busca telefone 1
                string telefone1 = BuscarTel1(idCliente);

                if (!string.IsNullOrEmpty(telefone1))
                {
                    string mensagem = FormatarMensagem(nomeCliente, "Seu pacote chegou e está disponível para retirada na loja.");
                    whatsapp whatsApp = new whatsapp();
                    whatsApp.SendMessage(mensagem, telefone1);

                    MessageBox.Show("Mensagem enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Telefone 1 não encontrado no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar mensagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWpp2_Click(object sender, EventArgs e)
        {
            try
            {
                string idCliente = txtIdCliente.Text;
                string nomeCliente = txtNomeCliente.Text;
                string idPacote = txtId.Text;

                if (string.IsNullOrEmpty(idCliente) || string.IsNullOrEmpty(idPacote))
                {
                    MessageBox.Show("Por favor, selecione um ID de pacote.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                    return;
                }

                // Busca telefone 2
                string telefone2 = BuscarTel2(idCliente);

                // Verifica se telefone2 é nulo, vazio ou apenas a máscara vazia
                if (string.IsNullOrEmpty(telefone2) || EhMascaraVazia(telefone2))
                {
                    MessageBox.Show("Telefone 2 não encontrado ou inválido no banco de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string mensagem = FormatarMensagem(nomeCliente, "Seu pacote chegou e está disponível para retirada na loja.");
                whatsapp whatsApp = new whatsapp();
                whatsApp.SendMessage(mensagem, telefone2);

                MessageBox.Show("Mensagem enviada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao enviar mensagem: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Função para verificar se o telefone salvo contém apenas a máscara vazia
        private bool EhMascaraVazia(string telefone)
        {
            string apenasDigitos = new string(telefone.Where(char.IsDigit).ToArray());
            return string.IsNullOrEmpty(apenasDigitos);
        }

        private void txtPesquisar_Enter(object sender, EventArgs e)
        {
            txtPesquisar.BackColor = Color.LightBlue;
        }

        private void txtPesquisar_Leave(object sender, EventArgs e)
        {
            txtPesquisar.BackColor = Color.White;
        }

        private void btnBuscar_Enter(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.LightGreen;
        }

        private void btnBuscar_Leave(object sender, EventArgs e)
        {
            btnBuscar.BackColor = Color.Silver;
        }

        private void txtId_Enter(object sender, EventArgs e)
        {
            txtId.BackColor = Color.LightBlue;
        }

        private void txtId_Leave(object sender, EventArgs e)
        {
            txtId.BackColor = Color.White;
        }

        private void btnSelect_Enter(object sender, EventArgs e)
        {
            btnSelect.BackColor = Color.LightGreen;
        }

        private void btnSelect_Leave(object sender, EventArgs e)
        {
            btnSelect.BackColor = Color.Silver;
        }

        private void txtIdCliente_Enter(object sender, EventArgs e)
        {
            txtIdCliente.BackColor = Color.LightBlue;
        }

        private void txtIdCliente_Leave(object sender, EventArgs e)
        {
            txtIdCliente.BackColor = Color.White;
        }

        private void btnCliente_Enter(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.LightGreen;
        }

        private void btnCliente_Leave(object sender, EventArgs e)
        {
            btnCliente.BackColor = Color.Silver;
        }

        private void txtLoja_Enter(object sender, EventArgs e)
        {
            txtLoja.BackColor = Color.LightBlue;
        }

        private void txtLoja_Leave(object sender, EventArgs e)
        {
            txtLoja.BackColor = Color.White;
        }

        private void txtQuantidade_Enter(object sender, EventArgs e)
        {
            txtQuantidade.BackColor = Color.LightBlue;
        }

        private void txtQuantidade_Leave(object sender, EventArgs e)
        {
            txtQuantidade.BackColor = Color.White;
        }

        private void txtNomeRetirada_Enter(object sender, EventArgs e)
        {
            txtNomeRetirada.BackColor = Color.LightBlue;
        }

        private void txtNomeRetirada_Leave(object sender, EventArgs e)
        {
            txtNomeRetirada.BackColor = Color.White;
        }

        private void txtCPF_Enter(object sender, EventArgs e)
        {
            txtCPF.BackColor = Color.LightBlue;
        }

        private void txtCPF_Leave(object sender, EventArgs e)
        {
            txtCPF.BackColor = Color.White;
        }

        private void txtValor_Enter(object sender, EventArgs e)
        {
            txtValor.BackColor = Color.LightBlue;
        }

        private void txtValor_Leave(object sender, EventArgs e)
        {
            txtValor.BackColor = Color.White;
        }

        private void btnAdd_Enter(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Green;
        }

        private void btnAdd_Leave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Silver;
        }

        private void btnAtt_Enter(object sender, EventArgs e)
        {
            btnAtt.BackColor = Color.Yellow;
        }

        private void btnAtt_Leave(object sender, EventArgs e)
        {
            btnAtt.BackColor = Color.Silver;
        }

        private void btnDel_Enter(object sender, EventArgs e)
        {
            btnDel.BackColor = Color.Red;
        }

        private void btnDel_Leave(object sender, EventArgs e)
        {
            btnDel.BackColor = Color.Silver;
        }

        private void btnLimpar_Enter(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.Orange;
        }

        private void btnLimpar_Leave(object sender, EventArgs e)
        {
            btnLimpar.BackColor = Color.Silver;
        }

        private void btnVoltar_Enter(object sender, EventArgs e)
        {
            btnVoltar.BackColor = Color.Red;
        }

        private void btnVoltar_Leave(object sender, EventArgs e)
        {
            btnVoltar.BackColor = Color.Silver;
        }

        private void btnWpp1_Enter(object sender, EventArgs e)
        {
            btnWpp1.BackColor = Color.LightGreen;
        }

        private void btnWpp1_Leave(object sender, EventArgs e)
        {
            btnWpp1.BackColor = Color.Silver;
        }

        private void btnWpp2_Enter(object sender, EventArgs e)
        {
            btnWpp2.BackColor = Color.LightGreen;
        }

        private void btnWpp2_Leave(object sender, EventArgs e)
        {
            btnWpp2.BackColor = Color.Silver;
        }

        private void gpboxEstoque_Enter(object sender, EventArgs e)
        {

        }

        private void txtPesquisar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnBuscar.PerformClick(); // Simula o clique no botão de busca
            }
        }
    }
}
