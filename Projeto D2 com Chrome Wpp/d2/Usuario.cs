using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using BCrypt.Net;
using System.Drawing;

namespace d2
{
    public partial class Usuario : Form
    {
        public Usuario()
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
                    buscar = new SqlCommand("SELECT * FROM tb_Usuario", conectar);
                }
                else
                {
                    // Se não for 'todos', realiza a busca normal
                    buscar = new SqlCommand("SELECT * FROM tb_Usuario WHERE usuario LIKE @pesquisar OR " +
                                            "id LIKE @pesquisar", conectar);

                    buscar.Parameters.AddWithValue("@pesquisar", "%" + pesquisar + "%");
                }

                DataTable vpesquisa = new DataTable();

                using (SqlDataAdapter wpesquisa = new SqlDataAdapter(buscar))
                {
                    wpesquisa.Fill(vpesquisa);
                    tbUsuario.DataSource = vpesquisa;
                }
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'd2Usuario.tb_Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.tb_UsuarioTableAdapter.Fill(this.d2Usuario.tb_Usuario);

        }

        private bool ValidarCampo()
        {

            if (string.IsNullOrWhiteSpace(txtLogin.Text))
            {
                MessageBox.Show("Por favor, preencher o login.");
                txtLogin.Focus();
                return true;
            }


            if (string.IsNullOrWhiteSpace(txtSenha.Text))
            {
                MessageBox.Show("Por favor, preencher a senha.");
                txtSenha.Focus();
                return true;
            }

            return false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ValidarCampo() == false)
            {
                var resultado = MessageBox.Show("Você tem certeza que deseja adicionar esse usuário?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK)
                {
                    string senha = txtSenha.Text;
                    string senhaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(senha, 13);


                    classUsuario u = new classUsuario();

                    u.usuario = txtLogin.Text;
                    u.senha = senhaHash;

                    classUsuario.addusuario(u);

                    var usuario = new Usuario();
                    usuario.Show(this);
                    this.Visible = false;
                }
                return;
            }
        }

        private void btnAtt_Click(object sender, EventArgs e)
        {
            if (ValidarCampo() == false)
            {
                var resultado = MessageBox.Show("Você tem certeza que deseja adicionar esse usuário?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (resultado == DialogResult.OK)
                {
                    string senha = txtSenha.Text;
                    string senhaHash = BCrypt.Net.BCrypt.EnhancedHashPassword(senha, 13);


                    classUsuario u = new classUsuario();

                    u.usuario = txtLogin.Text;
                    u.senha = senhaHash;

                    classUsuario.attusuario(u);

                    var usuario = new Usuario();
                    usuario.Show(this);
                    this.Visible = false;
                }
                return;
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtId.Text))
                {
                    MessageBox.Show("Por favor, insira o ID do usuário que deseja excluir.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtId.Focus();
                    return;
                }


                var resultado = MessageBox.Show("Você tem certeza que deseja excluir este usuário?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {

                    int id = int.Parse(txtId.Text);

                    classUsuario.deleteusuario(id);


                    MessageBox.Show("Usuário excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    var usuario = new Usuario();
                    usuario.Show(this);
                    this.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void COUNTUsuario()
        {
            bool idExists = false;

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();
                using (var procurarID = new SqlCommand("SELECT COUNT(*) FROM tb_Usuario WHERE id = @id", conectar))
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

            COUNTUsuario();

            DataTable usuario = classUsuario.selectusuario(Convert.ToInt32(txtId.Text));

            if (usuario.Rows.Count > 0)
            {
                
                txtLogin.Text = usuario.Rows[0].Field<string>("usuario");
                txtDregistro.Text = usuario.Rows[0].IsNull("dregistro") ? "" : usuario.Rows[0].Field<DateTime>("dregistro").ToString("dd/MM/yyyy HH:mm:ss");
               
            }
            else
            {
                MessageBox.Show("Não existe registro de usuário com o ID informado.");
            }
        }
        private void Limpar()
        {
            txtId.Clear();
            txtLogin.Clear();
            txtSenha.Clear();
            txtDregistro.Clear();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            var resultado = MessageBox.Show("Você deseja limpar todos os campos?", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (resultado == DialogResult.OK)
            {
                Limpar();
            }
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

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            txtLogin.BackColor = Color.LightBlue;
        }

        private void txtLogin_Leave(object sender, EventArgs e)
        {
            txtLogin.BackColor = Color.White;
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.LightBlue;
        }

        private void txtSenha_Leave(object sender, EventArgs e)
        {
            txtSenha.BackColor = Color.White;
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
    }
}
