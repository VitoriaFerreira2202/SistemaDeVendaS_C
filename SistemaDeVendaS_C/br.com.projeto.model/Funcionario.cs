using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaS_C.br.com.projeto.model
{
    public class Funcionario : Pessoa
    {
        public string cargo { get; set; }
        public string senha { get; set; }
        public string nivel_acesso { get; set; }
        public string cpf { get; set; }
    }
}