using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace d2
{
    internal class classUsuario
    {
        public int id;
        public string usuario;
        public string senha;

        public static void addusuario(classUsuario u)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();
                    var add = new SqlCommand("INSERT INTO tb_Usuario (usuario, senha, dregistro) " +
                                             "VALUES (@usuario, @senha, GETDATE())", conectar);

                    add.Parameters.AddWithValue("@usuario", u.usuario);
                    add.Parameters.AddWithValue("@senha", u.senha);

                    add.ExecuteNonQuery();

                    MessageBox.Show("Usuário adicionado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        public static void attusuario(classUsuario u)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();
                    var att = new SqlCommand("UPDATE tb_Cliente SET" +
                                             "(usuario = @usuario, " +
                                             "senha = @senha," +
                                             "WHERE id = @id;");

                    att.Parameters.AddWithValue("@usuario", u.usuario);
                    att.Parameters.AddWithValue("@senha", u.senha);
                    att.Parameters.AddWithValue("@id", u.id);

                    att.ExecuteNonQuery();

                    MessageBox.Show("Usuário alterado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public static void deleteusuario(int id)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();
                    var delete = new SqlCommand("DELETE FROM tb_Usuario WHERE id = @id", conectar);

                    delete.Parameters.AddWithValue("@id", id);

                    delete.ExecuteNonQuery();

                    MessageBox.Show("Registro do usuário deletado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }
        public static DataTable selectusuario(int ID)
        {
            DataTable retornarID = new DataTable();

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();
                using (var procurar = new SqlCommand("SELECT * FROM tb_Usuario WHERE id = @id", conectar))
                {
                    procurar.Parameters.AddWithValue("@id", ID);

                    using (var resp = new SqlDataAdapter(procurar))
                    {
                        resp.Fill(retornarID); // Preenche o DataTable
                    }
                }
            }
            return retornarID;
        }

    }
}
