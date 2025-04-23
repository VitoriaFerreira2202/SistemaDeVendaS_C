using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaS_C.br.com.projeto.model
{
    public class Produto
    {
        public int codigo { get; set; }
        public string descricao { get; set; }
        public double preco { get; set; }
        public int quantidade_estoque { get; set; }
        public int codigo_fornecedor { get; set; }
    }
}