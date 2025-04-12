using SistemaDeVendaS_C.br.com.projeto.dao;
using SistemaDeVendaS_C.br.com.projeto.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVendaS_C.br.com.projeto.viem
{
    public partial class FrmFuncionario : Form
    {
        public FrmFuncionario()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro do objeto modelo de cliente
            Funcionario obj = new Funcionario();

            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
            obj.email = txtEmail.Text;
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.cep = txtCep.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbEstado.Text;

            // passo - Criar um objeto da classeDAO  e chamar o metodo cadastrarCliente
            FuncionarioDao dao = new FuncionarioDao();
            dao.CadastroFucionario(obj);
            tabelaFucionario.DataSource = dao.ListarFuncionario();
        }

        private void FrmFuncionario_Load(object sender, EventArgs e)
        {
            FuncionarioDao dao = new FuncionarioDao();
            tabelaFucionario.DataSource = dao.ListarFuncionario();
        }
    }
}