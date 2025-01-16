using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace d2
{
    public partial class Financeiro : Form
    {
        public Financeiro()
        {
            InitializeComponent();
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

        private void Financeiro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'd2Financeiro.tb_Financeiro'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_FinanceiroTableAdapter.Fill(this.d2Financeiro.tb_Financeiro);

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            /// Validação das entradas de data
            if (!DateTime.TryParse(txtDe.Text, out DateTime dinicio) ||
                !DateTime.TryParse(txtAte.Text, out DateTime dfim))
            {
                MessageBox.Show("Por favor, insira datas válidas.");
                txtDe.Focus();
                return;
            }

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (SqlConnection conectar = new SqlConnection(d2))
            {
                conectar.Open();


                decimal lucro = 0;
                using (SqlCommand cmd = new SqlCommand(
                    "SELECT SUM(valor) FROM tb_Estoque WHERE dregistro BETWEEN @diainicio AND @diafim", conectar))
                {
                    cmd.Parameters.AddWithValue("@diainicio", dinicio);
                    cmd.Parameters.AddWithValue("@diafim", dfim);
                    var result = cmd.ExecuteScalar();
                    lucro = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                }


                using (SqlCommand cmd = new SqlCommand("INSERT INTO tb_Financeiro (diainicio, diafim, lucro) VALUES (@diainicio, @diafim, @lucro)", conectar))
                {
                    cmd.Parameters.AddWithValue("@diainicio", dinicio);
                    cmd.Parameters.AddWithValue("@diafim", dfim);
                    cmd.Parameters.AddWithValue("@lucro", lucro);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro adicionado com sucesso!");

                var financeiro = new Financeiro();
                financeiro.Show(this);
                this.Visible = false;

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                // Verifica se o campo ID está preenchido
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, insira o ID do relatório que deseja excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Pede confirmação antes de excluir
                var resultado = MessageBox.Show("Você tem certeza que deseja excluir este relatório?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    // Converte o ID para int
                    int id = int.Parse(txtId.Text);

                    // Chama o método de exclusão
                    classFinanceiro.deletefinanceiro(id);

                    // Mensagem de sucesso
                    MessageBox.Show("Pacote excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Atualiza ou redireciona para outra tela, se necessário
                    var financeiro = new Financeiro();
                    financeiro.Show(this);
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void COUNTFinanceiro()
        {
            bool idExists = false;

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();
                using (var procurarID = new SqlCommand("SELECT COUNT(*) FROM tb_Financeiro WHERE id = @id", conectar))
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

            COUNTFinanceiro();

            DataTable financeiro = classFinanceiro.selectfinanceiro(Convert.ToInt32(txtId.Text));

            if (financeiro.Rows.Count > 0)
            {

                // Tratamento para valores nulos (DBNull) em DateTime e conversão para string no formato desejado
                txtAte.Text = financeiro.Rows[0].IsNull("diainicio") ? "" : financeiro.Rows[0].Field<DateTime>("diafim").ToString("dd/MM/yyyy HH:mm:ss");
                txtDe.Text = financeiro.Rows[0].IsNull("diafim") ? "" : financeiro.Rows[0].Field<DateTime>("diainicio").ToString("dd/MM/yyyy HH:mm:ss");
                txtLucro.Text = financeiro.Rows[0].IsNull("lucro") ? "" : financeiro.Rows[0].Field<decimal>("lucro").ToString("F2");
            }
            else
            {
                MessageBox.Show("Não existe registro no estoque com o ID informado.");
            }
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
                    buscar = new SqlCommand("SELECT * FROM tb_Financeiro", conectar);
                }
                else
                {
                    // Se não for 'todos', realiza a busca normal
                    buscar = new SqlCommand("SELECT * FROM tb_Financeiro WHERE id LIKE @pesquisar OR " +
                                            "diainicio LIKE @pesquisar OR " +
                                            "diafim LIKE @pesquisar", conectar);

                    buscar.Parameters.AddWithValue("@pesquisar", "%" + pesquisar + "%");
                }

                DataTable vpesquisa = new DataTable();

                using (SqlDataAdapter wpesquisa = new SqlDataAdapter(buscar))
                {
                    wpesquisa.Fill(vpesquisa);
                    tbFinanceiro.DataSource = vpesquisa;
                }
            }
        }

        private void Limpar()
        {
            txtId.Clear();
            txtDe.Clear();
            txtAte.Clear();
            txtLucro.Clear();
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
