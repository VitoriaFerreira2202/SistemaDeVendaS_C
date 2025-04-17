using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaS_C.br.com.projeto.model
{
    public class Cliente : Pessoa
    {
        //Atributos e os Getter / Setter

        public string rg { get; set; }
        public string cpf { get; set; }

        public Cliente()
        { }

        public Cliente(string rg, string cpf, int codigo, string nome, string email, string telefone, string celular, string cep,
                      string endereco, int numero, string complemento, string bairro, string cidade, string estado) : base(codigo, nome, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
        {
            this.rg = rg;
            this.cpf = cpf;
        }
    }
}