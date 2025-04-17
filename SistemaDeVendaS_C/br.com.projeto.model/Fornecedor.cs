using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaDeVendaS_C.br.com.projeto.model
{
    public class Fornecedor : Pessoa
    {
        public string cnpj { get; set; }

        public Fornecedor()
        { }

        public Fornecedor(int codigo, string nome, string email, string telefone, string celular, string cep,
                          string endereco, int numero, string complemento, string bairro, string cidade, string estado, string cnpj)
                        : base(codigo, nome, email, telefone, celular, cep, endereco, numero, complemento, bairro, cidade, estado)
        {
            this.cnpj = cnpj;
        }
    }
}