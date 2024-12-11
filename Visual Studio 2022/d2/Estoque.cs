using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Twilio.TwiML.Voice;

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
            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (SqlConnection conectar = new SqlConnection(d2))
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


                    List<string> filtro = new List<string>();

                    if (checkEstoque.Checked)
                    {
                        filtro.Add("situacao = 'Estoque'");
                    }
                    if (checkRetirado.Checked)
                    {
                        filtro.Add("situacao = 'Retirado'");
                    }


                    if (filtro.Count > 0)
                    {
                        versituacao.RowFilter = string.Join(" OR ", filtro);
                    }
                    else
                    {
                        versituacao.RowFilter = "";
                    }

                    
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

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
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

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();
                using (var procurarID = new SqlCommand("SELECT COUNT(*) FROM tb_Cliente WHERE id = @id", conectar))
                {
                    procurarID.Parameters.AddWithValue("@id", Convert.ToInt32(txtIdCliente.Text));
                    idExists = (int)procurarID.ExecuteScalar() > 0;
                }
            }

            if (!idExists)
            {
                MessageBox.Show("O ID informado não existe.");
                return;
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
            if (string.IsNullOrWhiteSpace(txtPesquisar.Text))
            {
                MessageBox.Show("Por favor, insira um termo de pesquisa.");
                txtPesquisar.Focus();
                return;
            }

            string pesquisar = txtPesquisar.Text;

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (SqlConnection conectar = new SqlConnection(d2))
            {
                conectar.Open();

                SqlCommand buscar;

                if (pesquisar.ToLower() == "todos") // Verifica se a pesquisa é 'todos'
                {
                    // Se for 'todos', busca todos os dados sem filtro
                    buscar = new SqlCommand("SELECT * FROM tb_Estoque", conectar);
                }
                else
                {
                    // Se não for 'todos', realiza a busca normal
                    buscar = new SqlCommand("SELECT * FROM tb_Estoque WHERE nomecliente LIKE @pesquisar OR " +
                                            "loja LIKE @pesquisar OR " +
                                            "id LIKE @pesquisar", conectar);

                    buscar.Parameters.AddWithValue("@pesquisar", "%" + pesquisar + "%");
                }

                DataTable vpesquisa = new DataTable();

                using (SqlDataAdapter wpesquisa = new SqlDataAdapter(buscar))
                {
                    wpesquisa.Fill(vpesquisa);
                    tbEstoque.DataSource = vpesquisa;
                }
            }
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
                        catch (FormatException)
                        {
                            MessageBox.Show("Por favor, preencha os campos de Quantidade e Valor corretamente (somente números).",
                                "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            else
            {
                if (!ValidarCampo())
                {
                    // Confirmação antes de atualizar o pacote
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
                            p.nomeretirada = txtNomeRetirada.Text;
                            p.cpf = txtCPF.Text;

                            // Conversões de tipos
                            p.pk_idCliente = int.Parse(txtIdCliente.Text); // Convertendo string para int
                            p.quantidade = int.Parse(txtQuantidade.Text);  // Convertendo string para int
                            p.valor = decimal.Parse(txtValor.Text);       // Convertendo string para decimal

                            // Verifica situação do pacote (Estoque ou Retirado)
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
                            MessageBox.Show("Por favor, preencha os campos de ID, Quantidade e Valor corretamente (somente números).",
                                "Erro de Formato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
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
    }
}
