using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace d2
{
    public partial class Cliente : Form
    {
        public Cliente()
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
                    buscar = new SqlCommand("SELECT * FROM tb_Cliente", conectar);
                }
                else
                {
                    // Se não for 'todos', realiza a busca normal
                    buscar = new SqlCommand("SELECT * FROM tb_Cliente WHERE nome LIKE @pesquisar OR " +
                                            "cpf LIKE @pesquisar OR " +
                                            "id LIKE @pesquisar", conectar);
                    buscar.Parameters.AddWithValue("@pesquisar", "%" + pesquisar + "%");
                }

                DataTable vpesquisa = new DataTable();

                using (SqlDataAdapter wpesquisa = new SqlDataAdapter(buscar))
                {
                    wpesquisa.Fill(vpesquisa);
                    tbCliente.DataSource = vpesquisa;
                }
            }
        }


        private void Cliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'd2Cliente1.tb_Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_ClienteTableAdapter.Fill(this.d2Cliente1.tb_Cliente);


        }

        private bool ValidarCampo()
        {
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("Por favor, preencha o nome do cliente.");
                txtNome.Focus();
                return true;
            }

            if (!txtTel1.MaskFull)
            {
                MessageBox.Show("Por favor, preencha o telefone do cliente.");
                txtTel1.Focus();
                return true;
            }

            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidarCampo())
            {
                var resultado = MessageBox.Show("Você tem certeza que deseja adicionar esse cliente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK)
                {
                    classCliente c = new classCliente();

                    c.nome = txtNome.Text;
                    c.telefone = txtTel1.Text;

                    if (!string.IsNullOrWhiteSpace(txtCPF.Text))
                    {
                        c.cpf = txtCPF.Text;
                    }
                    else
                    {
                        c.cpf = null; 
                    }

                   
                    if (!string.IsNullOrWhiteSpace(txtTel2.Text))
                    {
                        c.telefone2 = txtTel2.Text;
                    }
                    else
                    {
                        c.telefone2 = null; 
                    }

                    classCliente.addcliente(c);

                    var cliente = new Cliente();
                    cliente.Show(this);
                    this.Visible = false;
                }
            }
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            if (!ValidarCampo())
            {
                var resultado = MessageBox.Show("Você tem certeza que deseja alterar esse cliente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK)
                {
                    classCliente c = new classCliente();

                    c.id = Convert.ToInt32(txtId.Text);
                    c.nome = txtNome.Text;
                    c.telefone = txtTel1.Text;

                    if (!string.IsNullOrWhiteSpace(txtCPF.Text))
                    {
                        c.cpf = txtCPF.Text;
                    }
                    else
                    {
                        c.cpf = null;
                    }


                    if (!string.IsNullOrWhiteSpace(txtTel2.Text))
                    {
                        c.telefone2 = txtTel2.Text;
                    }
                    else
                    {
                        c.telefone2 = null;
                    }

                    classCliente.attcliente(c);

                    var cliente = new Cliente();
                    cliente.Show(this);
                    this.Visible = false;
                }
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

            COUNTCliente();

            DataTable cliente = classCliente.selectcliente(Convert.ToInt32(txtId.Text));


            if (cliente.Rows.Count > 0)
            {
                txtNome.Text = cliente.Rows[0].Field<string>("nome");
                txtCPF.Text = cliente.Rows[0].Field<string>("cpf");
                txtTel1.Text = cliente.Rows[0].Field<string>("telefone").ToString();
                txtTel2.Text = cliente.Rows[0].Field<string>("telefone2").ToString();
            }

        }

        private void Limpar()
        {
            txtId.Clear();
            txtNome.Clear();
            txtCPF.Clear();
            txtTel1.Clear();
            txtTel2.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você deseja limpar todos os campos do cliente?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                Limpar();
            }
        }
    }
}

