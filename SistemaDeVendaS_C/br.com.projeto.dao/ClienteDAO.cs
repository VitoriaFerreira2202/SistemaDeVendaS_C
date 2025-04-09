using MySql.Data.MySqlClient;
using SistemaDeVendaS_C.br.com.projeto.conguicao;

namespace SistemaDeVendaS_C.br.com.projeto.dao
{
    public class ClienteDAO
    {
        private MySqlConnection conexao;

        public ClienteDAO()
        {
            this.conexao = new ConnectionFactory().getconnection();
        }
    }
}