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
                    string sql = @"insert into tb_produtos (descricao,preco,quantidate_estoque,codigo_fornecedor)
                                                          values(@descriacao,@preco,@quantidate_estoquequantidate_estoque,@codigo_fornecedor)";

                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@descriacao", obj.descricao);
                        executacmd.Parameters.AddWithValue("@preco", obj.preco);
                        executacmd.Parameters.AddWithValue("@quantidate_estoque", obj.quantidate_estoque);
                        executacmd.Parameters.AddWithValue("@codigo_fornecedor", obj.codigo_fornecedor);

                        // passo 3 - Abrir conexão e executar o comand
                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show("Funcionario cadastrado com sucesso");
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

        #endregion ListarProduto

        #region AlteraProduto

        public void AlteraProdudo(Produto obj)
        { }

        #region AlteraProduto
    }
}