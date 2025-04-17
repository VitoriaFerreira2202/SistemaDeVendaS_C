using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaS_C.br.com.projeto.model
{
    public class Funcionario : Pessoa
    {
        public string rg { get; set; }
        public string cargo { get; set; }
        public string senha { get; set; }
        public string nivel_acesso { get; set; }
        public string cpf { get; set; }

        public Funcionario()
        { }

        public Funcionario(string rg, string cpf, int codigo, string nome, string email, string telefone, string celular, string cep,
                      string endereco, int numero, string complemento, string bairro, string cidade, string estado, string senha, string nivel_acesso) : base(codigo, nome, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
        {
            this.rg = rg;
            this.cargo = cargo;
            this.senha = senha;
            this.cpf = cpf;
            this.nivel_acesso = nivel_acesso;
        }
    }
}