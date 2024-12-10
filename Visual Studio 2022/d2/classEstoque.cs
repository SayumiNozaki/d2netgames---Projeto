using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace d2
{
    internal class classEstoque
    {
        public int id { get; set; }
        public string loja { get; set; }
        public int pk_idCliente { get; set; }
        public int quantidade { get; set; }
        public string situacao { get; set; }
        public string nomecliente { get; set; }
        public string nomeretirada { get; set; }
        public string cpf { get; set; }
        public decimal valor { get; set; }
        public DateTime dregistro { get; set; }
        public DateTime dretirada { get; set; }


        public static void addestoque(classEstoque e)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();

                    // Comando SQL corrigido para adicionar valores ao estoque
                    var add = new SqlCommand(
                        "INSERT INTO tb_Estoque (loja, pk_idCliente, quantidade, situacao, nomecliente, cpf, valor, dregistro) " +
                        "VALUES (@loja, @pk_idCliente, @quantidade, @situacao, @nomecliente, @cpf, @valor, GETDATE())", conectar);

                    // Adicionando os parâmetros
                    add.Parameters.AddWithValue("@loja", e.loja);
                    add.Parameters.AddWithValue("@pk_idCliente", e.pk_idCliente);
                    add.Parameters.AddWithValue("@quantidade", e.quantidade);
                    add.Parameters.AddWithValue("@situacao", e.situacao);
                    add.Parameters.AddWithValue("@nomecliente", e.nomecliente ?? (object)DBNull.Value); // Permite null
                    add.Parameters.AddWithValue("@cpf", e.cpf ?? (object)DBNull.Value); // Permite null
                    add.Parameters.AddWithValue("@valor", e.valor == 0 ? (object)DBNull.Value : e.valor); // Permite null ou 0 como vazio

                    add.ExecuteNonQuery();

                    MessageBox.Show("Pacote adicionado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }


        public static void attestoque(classEstoque e)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();

                    // Verifica se a situação é "retirado"
                    if (e.situacao.ToLower() == "retirado")
                    {
                        if (string.IsNullOrWhiteSpace(e.nomeretirada))
                        {
                            MessageBox.Show("O nome de quem retirou é obrigatório ao marcar o pacote como 'retirado'.");
                            return;
                        }

                        // Atualiza com data e nome de retirada
                        var att = new SqlCommand(
                            "UPDATE tb_Estoque SET " +
                            "loja = @loja, " +
                            "pk_idCliente = @pk_idCliente, " +
                            "quantidade = @quantidade, " +
                            "situacao = @situacao, " +
                            "nomecliente = @nomecliente, " +
                            "nomeretirada = @nomeretirada, " +
                            "cpf = @cpf, " +
                            "valor = @valor, " +
                            "dretirada = GETDATE() " +
                            "WHERE id = @id", conectar);

                        // Adiciona parâmetros
                        att.Parameters.AddWithValue("@loja", e.loja);
                        att.Parameters.AddWithValue("@pk_idCliente", e.pk_idCliente);
                        att.Parameters.AddWithValue("@quantidade", e.quantidade);
                        att.Parameters.AddWithValue("@situacao", e.situacao);
                        att.Parameters.AddWithValue("@nomecliente", e.nomecliente);
                        att.Parameters.AddWithValue("@nomeretirada", e.nomeretirada);
                        att.Parameters.AddWithValue("@cpf", e.cpf);
                        att.Parameters.AddWithValue("@valor", e.valor);
                        att.Parameters.AddWithValue("@id", e.id);

                        att.ExecuteNonQuery();
                        MessageBox.Show("Pacote atualizado como 'retirado' com sucesso.");
                    }
                    else
                    {
                        // Atualiza sem mexer nos dados de retirada
                        var att = new SqlCommand(
                            "UPDATE tb_Estoque SET " +
                            "loja = @loja, " +
                            "pk_idCliente = @pk_idCliente, " +
                            "quantidade = @quantidade, " +
                            "nomecliente = @nomecliente, " +
                            "WHERE id = @id", conectar);

                        // Adiciona parâmetros
                        att.Parameters.AddWithValue("@loja", e.loja);
                        att.Parameters.AddWithValue("@pk_idCliente", e.pk_idCliente);
                        att.Parameters.AddWithValue("@quantidade", e.quantidade);
                        att.Parameters.AddWithValue("@nomecliente", e.nomecliente);
                        att.Parameters.AddWithValue("@id", e.id);

                        att.ExecuteNonQuery();
                        MessageBox.Show("Pacote atualizado como 'em estoque' com sucesso.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static void deleteestoque(int id)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();
                    var delete = new SqlCommand("DELETE FROM tb_Estoque WHERE id = @id", conectar);

                    delete.Parameters.AddWithValue("@id", id);

                    delete.ExecuteNonQuery();

                    MessageBox.Show("Registro de pacote deletado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.Message);
            }
        }

        public static DataTable selectestoque(int ID)
        {
            DataTable retornarID = new DataTable();

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();
                using (var procurar = new SqlCommand("SELECT * FROM tb_Estoque WHERE id = @id", conectar))
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
