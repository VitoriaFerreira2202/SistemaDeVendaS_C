using MySql.Data.MySqlClient;
using Mysqlx;
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
    public class FuncionarioDao
    {
        private MySqlConnection conexao;

        public FuncionarioDao()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastroDeFucionario

        public void CadastroFucionario(Funcionario obj)
        {
            try
            {
                // passo 1 - Definir o comando sql para o INSERT

                using (MySqlConnection conexao = new ConnectionFactory().getconnection())
                {
                    string sql = @"insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel_acesso,
                                telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values(@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,
                                @celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                    // passo 2 - Organizar o comando SQL

                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@nome", obj.nome);
                        executacmd.Parameters.AddWithValue("@rg", obj.rg);
                        executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                        executacmd.Parameters.AddWithValue("@email", obj.email);
                        executacmd.Parameters.AddWithValue("@senha", obj.senha);
                        executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                        executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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

                        MessageBox.Show("Produto cadastrado com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro.Message);
            }
        }

        #endregion CadastroDeFucionario

        #region ListarFuncionario

        public DataTable ListarFuncionario()
        {
            try
            {
                //passo 1 - Definir o comando sql para o insert
                conexao = new ConnectionFactory().getconnection();

                DataTable tabelaFucionario = new DataTable();
                string sql = "select * from tb_funcionarios";

                // 2 passo - organizar o comando sql
                using (MySqlCommand cmdExecSql = new MySqlCommand(sql, conexao))
                {
                    {
                        // 3 passo - Abrir a conexão e executar o comando sql
                        //conexao.Open();

                        MySqlDataAdapter da = new MySqlDataAdapter(cmdExecSql);
                        da.Fill(tabelaFucionario);

                        return tabelaFucionario;
                    } // comando descartado aqui
                } // conexão fechada aqui
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao executar o comando sql: " + erro);
                return null;
            }
        }

        #endregion ListarFuncionario

        #region AlteraFuncionario

        public void AlteraFuncionario(Funcionario obj)
        {
            try
            {
                //passo 1 - Definir o comando sql para o insert
                using (MySqlConnection conexao = new ConnectionFactory().getconnection())
                {
                    string sql = @"update tb_funcionarios set nome=@nome,rg=@rg,cpf=@cpf,email=@email,senha=@senha,cargo=@cargo,nivel_acesso=@nivel_acesso,
                                telefone=@telefone,celular=@celular,cep=@cep,endereco=@endereco,numero=@numero,complemento=@complemento,bairro=@bairro,
                                cidade=@cidade,estado=@estado
                                where id=@id";

                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@nome", obj.nome);
                        executacmd.Parameters.AddWithValue("@rg", obj.rg);
                        executacmd.Parameters.AddWithValue("@cpf", obj.cpf);
                        executacmd.Parameters.AddWithValue("@email", obj.email);
                        executacmd.Parameters.AddWithValue("@senha", obj.senha);
                        executacmd.Parameters.AddWithValue("@cargo", obj.cargo);
                        executacmd.Parameters.AddWithValue("@nivel_acesso", obj.nivel_acesso);
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
                        MessageBox.Show("Funcionario alterado com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro: " + erro);
            }
        }

        #endregion AlteraFuncionario

        #region ExcluirFuncionario

        public void ExcluirFuncionario(Funcionario obj)
        {
            try
            {
                using (MySqlConnection conexao = new ConnectionFactory().getconnection())  // Aqui você declara a conexão dentro do using
                {
                    string sql = @"DELETE FROM tb_funcionarios WHERE id = @id";

                    // Passo 2 - Organizar o comando sql
                    using (MySqlCommand executacmd = new MySqlCommand(sql, conexao))
                    {
                        executacmd.Parameters.AddWithValue("@id", obj.codigo);

                        // Passo 3 - Abrir a conexão e executar o comando
                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show("Funcionário excluído com sucesso!");
                    } // O MySqlCommand 'executacmd' é descartado automaticamente aqui
                } // A conexão 'conexao' é fechada automaticamente aqui
            }
            catch (Exception erro)
            {
                MessageBox.Show("Ocorreu o erro" + erro);
            }
        }

        #endregion ExcluirFuncionario

        #region PesquisaNomeFuncionario

        public DataTable PesquisaNomeFuncionario(string nome)
        {
            try
            {
                //passo 1 - Definir o comando sql para o insert
                conexao = new ConnectionFactory().getconnection();

                DataTable tabelaFucionario = new DataTable();
                string sql = "select * from tb_funcionarios where nome=@nome";
                // 2 passo - organizar o comando sql
                using (MySqlCommand cmdExecSql = new MySqlCommand(sql, conexao))
                {
                    {
                        cmdExecSql.Parameters.AddWithValue("@nome", nome);
                        MySqlDataAdapter da = new MySqlDataAdapter(cmdExecSql);
                        da.Fill(tabelaFucionario);

                        return tabelaFucionario;
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show($"Erro ao executar o comando Sql:" + erro);
                return null;
            }
        }

        #endregion PesquisaNomeFuncionario
    }
}