using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace d2
{
    internal class classFinanceiro
    {
        public DateTime diainicio { get; set; }
        public DateTime diafim { get; set; }
        public decimal lucro { get; set; }


        public static void addfinanceiro(classFinanceiro f)
        {
            try
            {
                string d2 = "Server=SERVIDOR2;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();
                    var add = new SqlCommand("INSERT INTO tb_Financeiro (diainicio, diafim, lucro) " +
                                             "VALUES (@diainicio, @diafim, @lucro)", conectar);

                    add.Parameters.AddWithValue("@diainicio", f.diainicio);
                    add.Parameters.AddWithValue("@diafim", f.diafim);
                    add.Parameters.AddWithValue("@lucro", f.lucro);

                    add.ExecuteNonQuery();

                    MessageBox.Show("Relatório financeiro adicionado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }

        }
        public static void deletefinanceiro(int id)
        {
            try
            {
                string d2 = "Server=SERVIDOR2;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();
                    var delete = new SqlCommand("DELETE FROM tb_Financeiro WHERE id = @id", conectar);

                    delete.Parameters.AddWithValue("@id", id);

                    delete.ExecuteNonQuery();

                    MessageBox.Show("Relatório financeiro deletado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static DataTable selectfinanceiro(int ID)
        {
            DataTable retornarID = new DataTable();

            string d2 = "Server=SERVIDOR2;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();
                using (var procurar = new SqlCommand("SELECT * FROM tb_Financeiro WHERE id = @id", conectar))
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
