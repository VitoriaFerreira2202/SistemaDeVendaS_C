using MySql.Data.MySqlClient;
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

namespace SistemaDeVendaS_C.br.com.projeto.dao
{
    internal class FornecedorDao
    {
        private MySqlConnection conexao;

        public FornecedorDao()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }

        #region CadastroDeFurnecedor

        public void CadastrarFornecedor(Fornecedor obj)
        { }

        #endregion CadastroDeFurnecedor

        #region ListarFornecedor

        public DataTable ListarFornecedor()
        { }

        #endregion ListarFornecedor

        #region AlteraFornecedor

        public void AlteraFornecedor(Fornecedor obj)
        { }

        #endregion AlteraFornecedor

        #region ExcluirFuncionario

        public void ExcluirFornecedor(Fornecedor obj)
        { }

        #endregion ExcluirFuncionario

        #region PesquisaNomeFornecedor

        public DataTable PesquisaNomeFornecedor(string nome)
        { }

        #endregion PesquisaNomeFornecedor
    }
}