using MySql.Data.MySqlClient;
using Mysqlx;
using SistemaDeVendaS_C.br.com.projeto.conguicao;
using SistemaDeVendaS_C.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVendaS_C.br.com.projeto.dao
{
    internal class FornecedorDao
    {
        private MySqlConnection conexao;

        public FornecedorDao()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastroDeFornecedor

        public void CadastrarFornecedor(Fornecedor obj)
        {
            try
            {
                using (MySqlConnection conexao = new ConnectionFactory().getconnection())
                {
                    string sql = @"insert into tb_fornecedores (nome,cnpj,email,telefone,celular,cep
                                                    ,endereco,numero,complemento,bairro,cidade,estado)
                                values(@nome,@cnpj,@email,@telefone,@celular,@cep,@endereco,@numero,
                                                                   @complemento,@bairro,@cidade,@estado)";

                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@nome", obj.nome);
                        executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                        executacmd.Parameters.AddWithValue("@email", obj.email);
                        executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                        executacmd.Parameters.AddWithValue("@celular", obj.celular);
                        executacmd.Parameters.AddWithValue("@cep", obj.cep);
                        executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                        executacmd.Parameters.AddWithValue("@numero", obj.numero);
                        executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                        executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                        executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                        executacmd.Parameters.AddWithValue("@estado", obj.estado);

                        // passo 3 - Abrir conexão e executar o comand
                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor cadastrado com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro.Message);
            }
        }

        #endregion CadastroDeFornecedor

        #region ListarFornecedor

        public DataTable ListarFornecedor()
        {
            try
            {
                conexao = new ConnectionFactory().getconnection();

                DataTable tabelaFucionario = new DataTable();
                string sql = "select * from tb_fornecedores";

                using (MySqlCommand cmdExecSql = new MySqlCommand(sql, conexao))
                {
                    {
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdExecSql);
                        da.Fill(tabelaFucionario);

                        return tabelaFucionario;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion ListarFornecedor

        #region AlteraFornecedor

        public void AlteraFornecedor(Fornecedor obj)
        {
            try
            {
                using (MySqlConnection conexao = new ConnectionFactory().getconnection())
                {
                    string sql = @"update tb_fornecedores set nome=@nome,
                                    cnpj=@cnpj,email=@email,telefone=@telefone,celular=@celular,
                                                        cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
                                                        cidade=@cidade,estado=@estado
                                                        where id=@id";

                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@nome", obj.nome);
                        executacmd.Parameters.AddWithValue("@cnpj", obj.cnpj);
                        executacmd.Parameters.AddWithValue("@email", obj.email);
                        executacmd.Parameters.AddWithValue("@telefone", obj.telefone);
                        executacmd.Parameters.AddWithValue("@celular", obj.celular);
                        executacmd.Parameters.AddWithValue("@cep", obj.cep);
                        executacmd.Parameters.AddWithValue("@endereco", obj.endereco);
                        executacmd.Parameters.AddWithValue("@numero", obj.numero);
                        executacmd.Parameters.AddWithValue("@complemento", obj.complemento);
                        executacmd.Parameters.AddWithValue("@bairro", obj.bairro);
                        executacmd.Parameters.AddWithValue("@cidade", obj.cidade);
                        executacmd.Parameters.AddWithValue("@estado", obj.estado);
                        executacmd.Parameters.AddWithValue("@id", obj.codigo);

                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor alterado com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion AlteraFornecedor

        #region Excluirfornecedor

        public void ExcluirFornecedor(Fornecedor obj)
        {
            try
            {
                using (MySqlConnection conexao = new ConnectionFactory().getconnection())
                {
                    string sql = @"DELETE FROM tb_fornecedores WHERE id = @id";

                    // Passo 2 - Organizar o comando sql
                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@id", obj.codigo);

                        // Passo 3 - Abrir a conexão e executar o comando
                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show("Fornecedor excluído com sucesso!");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o erro" + erro);
            }
        }

        #endregion Excluirfornecedor

        #region PesquisaNomeFornecedor

        public DataTable PesquisaNomeFornecedor(string nome)
        {
            try
            {//passo 1 - Definir o comando sql para o insert
                conexao = new ConnectionFactory().getconnection();

                DataTable tabelaFornecedor = new DataTable();
                string sql = $"select * from tb_fornecedores where nome=@nome";
                // 2 passo - organizar o comando sql
                using (MySqlCommand cmdExecSql = new MySqlCommand(sql, conexao))
                {
                    {
                        cmdExecSql.Parameters.AddWithValue("@nome", nome);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdExecSql);
                        da.Fill(tabelaFornecedor);

                        return tabelaFornecedor;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando Sql:" + erro);
                return null;
            }
        }

        #endregion PesquisaNomeFornecedor
    }
}