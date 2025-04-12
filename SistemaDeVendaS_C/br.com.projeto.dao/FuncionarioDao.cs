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
                string connectionString = "server=localhost; user ID=root; password=''; database=bdvendas";

                using (MySqlConnection conexao = new MySqlConnection(connectionString))

                {    //passo 1 - Definir o comando sql para o insert
                    string sql = @"insert into tb_funcionarios (nome,rg,cpf,email,senha,cargo,nivel acesso,
                                telefone,celular,cep,endereco,numero,complemento,bairro,cidade,estado)
                                values(@nome,@rg,@cpf,@email,@senha,@cargo,@nivel_acesso,@telefone,
                                @celular,@cep,@endereco,@numero,@complemento,@bairro,@cidade,@estado)";

                    // 2 passo - organizar o comando sql

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

                        conexao.Open();
                        executacmd.ExecuteNonQuery();

                        MessageBox.Show("Cliente cadastrado com sucesso");
                    }
                }
            }
            catch (Exception erro)
            {
                MessageBox.Show("Aconteceu o erro:" + erro);
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

        public void AlteraFuncionario()
        { }

        #endregion AlteraFuncionario

        # region ExcluirFuncionario

        public void ExcluirFuncionario()
        { }

        #endregion ExcluirFuncionario

        #region PesquisaNomeFuncionario

        public void PesquisaNomeFuncionario()
        { }

        #endregion PesquisaNomeFuncionario
    }
}