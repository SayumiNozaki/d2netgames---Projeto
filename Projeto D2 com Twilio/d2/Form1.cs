using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace d2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool VerificarCredenciais(string login, string senha)
        {
            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();

                // Busca o hash da senha para o login fornecido
                var command = new SqlCommand("SELECT senha FROM tb_Usuario WHERE usuario = @usuario", conectar);
                command.Parameters.AddWithValue("@usuario", login);

                var senhaHash = command.ExecuteScalar() as string;

                if (senhaHash != null)
                {
                    // Verifica se a senha fornecida corresponde ao hash armazenado
                    bool isVerified = BCrypt.Net.BCrypt.EnhancedVerify(senha, senhaHash);

                    if (isVerified)
                    {
                        return true; // Senha correta
                    }
                    else
                    {
                        Console.WriteLine("Senha incorreta.");
                        return false; // Senha incorreta
                    }
                }
                else
                {
                    Console.WriteLine("Usuário não encontrado.");
                    return false; // Usuário não encontrado
                }
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            if (VerificarCredenciais(login, senha))
            {
                var menu = new Home();
                menu.Show(this);
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnAjuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Para recuperação de senha ou cadastro consulte um administrador.", "Ajuda", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
