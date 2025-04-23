using MySql.Data.MySqlClient;
using SistemaDeVendaS_C.br.com.projeto.conguicao;
using SistemaDeVendaS_C.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVendaS_C.br.com.projeto.dao
{
    public class ProdutoDao
    {
        private MySqlConnection conexao;

        public ProdutoDao()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastroDeProduto

        public void CadastroProduto(Produto obj)
        {
            try
            {
                using (MySqlConnection conexao = new ConnectionFactory().getconnection())
                {
                    string sql = @"insert into tb_produtos (descricao,preco,qtd_estoque,for_id)
                                                          values(@descricao,@preco,@qtd_estoque,@for_id)";

                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                        executacmd.Parameters.AddWithValue("@preco", obj.preco);
                        executacmd.Parameters.AddWithValue("@qtd_estoque", obj.quantidade_estoque);
                        executacmd.Parameters.AddWithValue("@for_id", obj.codigo_fornecedor);

                        // passo 3 - Abrir conexão e executar o comand
                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show(" Produto cadastrado com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro.Message);
            }
        }

        #endregion CadastroDeProduto

        #region ListarProduto

        public DataTable ListaProduto()
        {
            try
            {
                conexao = new ConnectionFactory().getconnection();

                DataTable tabelaProduto = new DataTable();
                string sql = "select * from tb_produtos";
                using (MySqlCommand cmdExecSql = new MySqlCommand(sql, conexao))
                {
                    {
                        // 3 passo - Abrir a conexão e executar o comando sql
                        //conexao.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmdExecSql);
                        da.Fill(tabelaProduto);

                        return tabelaProduto;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion ListarProduto

        #region AlteraProduto

        public void AlteraProdudo(Produto obj)
        {
            try
            {
                //passo 1 - Definir o comando sql para o insert
                using (MySqlConnection conexao = new ConnectionFactory().getconnection())
                {
                    string sql = @"update tb_produtos set descricao=@descricao, preco=@preco,
                                                      @qtd_estoque=@qtd_estoque, for_id=@for_id
                                                       where id=@id";

                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@descricao", obj.descricao);
                        executacmd.Parameters.AddWithValue("@preco", obj.preco);
                        executacmd.Parameters.AddWithValue("@qtd_estoque", obj.quantidade_estoque);
                        executacmd.Parameters.AddWithValue("@for_id", obj.codigo_fornecedor);
                        executacmd.Parameters.AddWithValue("@id", obj.codigo);

                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show("Produto alterado com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion AlteraProduto

        #region ExcluirProduto

        public void ExcluirProduto(Produto obj)
        {
            try
            {
                using (MySqlConnection conexao = new ConnectionFactory().getconnection())  // Aqui você declara a conexão dentro do using
                {
                    string sql = @"DELETE FROM tb_produtos WHERE id = @id";

                    // Passo 2 - Organizar o comando sql
                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@id", obj.codigo);

                        // Passo 3 - Abrir a conexão e executar o comando
                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show("Produto excluído com sucesso!");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o erro" + erro);
            }
        }

        #endregion ExcluirProduto

        #region PesquisaNomeProduto

        public DataTable PesquisaNomeProduto(string nome)
        {
            try
            {
                //passo 1 - Definir o comando sql para o insert
                conexao = new ConnectionFactory().getconnection();

                DataTable tabelaProduto = new DataTable();
                string sql = "select * from tb_produtos where nome=@nome";
                // 2 passo - organizar o comando sql
                using (MySqlCommand cmdExecSql = new MySqlCommand(sql, conexao))
                {
                    {
                        cmdExecSql.Parameters.AddWithValue("@nome", nome);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdExecSql);
                        da.Fill(tabelaProduto);

                        return tabelaProduto;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando Sql:" + erro);
                return null;
            }
        }

        #endregion PesquisaNomeProduto
    }
}