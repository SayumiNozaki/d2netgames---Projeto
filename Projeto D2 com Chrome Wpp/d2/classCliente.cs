using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace d2
{
    internal class classCliente
    {
        public int id;
        public string nome;
        public string cpf;
        public string telefone;
        public string telefone2;

        public static void addcliente(classCliente c)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();
                    var add = new SqlCommand("INSERT INTO tb_Cliente (nome, cpf, telefone, telefone2) " +
                                                 "VALUES (@nome, @cpf, @telefone, @telefone2)", conectar);

                    add.Parameters.AddWithValue("@nome", c.nome);
                    add.Parameters.AddWithValue("@cpf", c.cpf);
                    add.Parameters.AddWithValue("@telefone", c.telefone);
                    add.Parameters.AddWithValue("@telefone2", c.telefone2);

                    add.ExecuteNonQuery();

                    MessageBox.Show("Cliente adicionado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        public static void attcliente(classCliente c)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();
                    var att = new SqlCommand("UPDATE tb_Cliente SET " +
                                             "nome = @nome, " +
                                             "cpf = @cpf," +
                                             "telefone = @telefone," +
                                             "telefone2 = @telefone2 " +
                                             "WHERE id = @id;", conectar);

                    att.Parameters.AddWithValue("@nome", c.nome);
                    att.Parameters.AddWithValue("@cpf", c.cpf);
                    att.Parameters.AddWithValue("@telefone", c.telefone);
                    att.Parameters.AddWithValue("@telefone2", c.telefone2);
                    att.Parameters.AddWithValue("@id", c.id);
                    att.ExecuteNonQuery();

                    MessageBox.Show("Cliente alterado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static DataTable selectcliente(int ID)
        {
            DataTable retornarID = new DataTable();

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();
                using (var procurar = new SqlCommand("SELECT * FROM tb_Cliente WHERE id = @id", conectar))
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
