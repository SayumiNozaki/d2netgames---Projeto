using System;
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
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show(this);
            this.Visible = false;
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
                txtLoja.Text = estoque.Rows[0].Field<string>("loja");
                txtIdCliente.Text = estoque.Rows[0].Field<string>("pk_idCliente");
                txtQuantidade.Text = estoque.Rows[0].Field<string>("quantidade");
                txtNomeRetirada.Text = estoque.Rows[0].Field<string>("nomeretirada");
                txtNomeCliente.Text = estoque.Rows[0].Field<string>("nomecliente");
                txtCPF.Text = estoque.Rows[0].Field<string>("cpf");
                txtValor.Text = estoque.Rows[0].Field<string>("valor");
                txtDregistro.Text = estoque.Rows[0].Field<string>("dregistro");
                txtDretirada.Text = estoque.Rows[0].Field<string>("dretirada");

            }
        }
    }
}
