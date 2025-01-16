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


        public static void addestoque(classEstoque p)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();

                    // Comando SQL ajustado para incluir `dretirada`
                    var add = new SqlCommand(
                        "INSERT INTO tb_Estoque (loja, pk_idCliente, quantidade, situacao, nomecliente, cpf, valor, dregistro, dretirada, nomeretirada) " +
                        "VALUES (@loja, @pk_idCliente, @quantidade, @situacao, @nomecliente, @cpf, @valor, GETDATE(), @dretirada, @nomeretirada)", conectar);

                    // Adicionando os parâmetros
                    add.Parameters.AddWithValue("@loja", p.loja);
                    add.Parameters.AddWithValue("@pk_idCliente", p.pk_idCliente);
                    add.Parameters.AddWithValue("@quantidade", p.quantidade);
                    add.Parameters.AddWithValue("@situacao", p.situacao);
                    add.Parameters.AddWithValue("@nomecliente", p.nomecliente ?? (object)DBNull.Value); // Permite null
                    add.Parameters.AddWithValue("@cpf", p.cpf ?? (object)DBNull.Value);               // Permite null
                    add.Parameters.AddWithValue("@valor", p.valor > 0 ? p.valor : (object)DBNull.Value); // Permite null para valor

                    // Adiciona `dretirada` e `nomeretirada` apenas se retirado
                    if (p.situacao == "Retirado")
                    {
                        add.Parameters.AddWithValue("@dretirada", DateTime.Now); // Data atual
                        add.Parameters.AddWithValue("@nomeretirada", p.nomeretirada);
                    }
                    else
                    {
                        add.Parameters.AddWithValue("@dretirada", DBNull.Value); // Null se não retirado
                        add.Parameters.AddWithValue("@nomeretirada", DBNull.Value);
                    }

                    add.ExecuteNonQuery();

                    MessageBox.Show("Pacote adicionado com sucesso.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao registrar pacote: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public static void attestoque(classEstoque p)
        {
            try
            {
                string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";
                using (var conectar = new SqlConnection(d2))
                {
                    conectar.Open();

                    if (p.situacao.ToLower() == "retirado")
                    {
                        // Validação obrigatória
                        if (string.IsNullOrWhiteSpace(p.nomeretirada))
                        {
                            MessageBox.Show("O nome de quem retirou é obrigatório ao marcar o pacote como 'retirado'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        if (p.valor <= 0)
                        {
                            MessageBox.Show("O valor é obrigatório ao marcar o pacote como 'retirado'.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        // Atualização para situação "Retirado"
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

                        // Parâmetros
                        att.Parameters.AddWithValue("@loja", p.loja);
                        att.Parameters.AddWithValue("@pk_idCliente", p.pk_idCliente);
                        att.Parameters.AddWithValue("@quantidade", p.quantidade);
                        att.Parameters.AddWithValue("@situacao", p.situacao);
                        att.Parameters.AddWithValue("@nomecliente", p.nomecliente ?? (object)DBNull.Value);
                        att.Parameters.AddWithValue("@nomeretirada", p.nomeretirada);
                        att.Parameters.AddWithValue("@cpf", p.cpf ?? (object)DBNull.Value);
                        att.Parameters.AddWithValue("@valor", p.valor);
                        att.Parameters.AddWithValue("@id", p.id);

                        att.ExecuteNonQuery();
                        MessageBox.Show("Pacote atualizado como 'retirado' com sucesso.");
                    }
                    else
                    {
                        // Atualização para situação "Em Estoque"
                        var att = new SqlCommand(
                            "UPDATE tb_Estoque SET " +
                            "loja = @loja, " +
                            "pk_idCliente = @pk_idCliente, " +
                            "quantidade = @quantidade, " +
                            "situacao = @situacao, " +
                            "nomecliente = @nomecliente, " +
                            "cpf = @cpf, " +
                            "valor = @valor " +
                            "WHERE id = @id", conectar);

                        // Parâmetros
                        att.Parameters.AddWithValue("@loja", p.loja);
                        att.Parameters.AddWithValue("@pk_idCliente", p.pk_idCliente);
                        att.Parameters.AddWithValue("@quantidade", p.quantidade);
                        att.Parameters.AddWithValue("@situacao", p.situacao);
                        att.Parameters.AddWithValue("@nomecliente", p.nomecliente ?? (object)DBNull.Value);
                        att.Parameters.AddWithValue("@cpf", p.cpf ?? (object)DBNull.Value);
                        att.Parameters.AddWithValue("@valor", p.valor > 0 ? p.valor : (object)DBNull.Value);
                        att.Parameters.AddWithValue("@id", p.id);

                        att.ExecuteNonQuery();
                        MessageBox.Show("Pacote atualizado como 'em estoque' com sucesso.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar pacote: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public static DataTable selectestoque(int id)
        {
            DataTable retornarID = new DataTable();

            string d2 = "Server=FEUERWOLF;Database=d2;Integrated Security=True;";

            using (var conectar = new SqlConnection(d2))
            {
                conectar.Open();
                using (var procurar = new SqlCommand("SELECT * FROM tb_Estoque WHERE id = @id", conectar))
                {
                    procurar.Parameters.AddWithValue("@id", id);

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
