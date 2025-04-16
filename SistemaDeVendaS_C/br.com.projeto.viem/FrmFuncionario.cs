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
            obj.senha = txtSenha.Text;
            obj.cargo = txtCargo.Text;
            obj.nivel_acesso = txtNivelAcesso.Text;
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            // 1 passo - Receber os dados dentro do objeto modelo de funcionario
            Funcionario obj = new Funcionario();

            obj.nome = txtNome.Text;
            obj.rg = txtRg.Text;
            obj.cpf = txtCpf.Text;
            obj.email = txtEmail.Text;
            obj.senha = txtSenha.Text;
            obj.cargo = txtCargo.Text;
            obj.nivel_acesso = txtNivelAcesso.Text;
            obj.telefone = txtTelefone.Text;
            obj.celular = txtCelular.Text;
            obj.cep = txtCep.Text;
            obj.endereco = txtEndereco.Text;
            obj.numero = int.Parse(txtNumero.Text);
            obj.complemento = txtComplemento.Text;
            obj.bairro = txtBairro.Text;
            obj.cidade = txtCidade.Text;
            obj.estado = cbEstado.Text;
            obj.codigo = int.Parse(txtCodigo.Text);

            //2 passo - Criar um objeto da funcionario FuncionarioDao e chamar o metodo alterar
            FuncionarioDao dao = new FuncionarioDao();
            dao.AlteraFuncionario(obj);

            //recarregar o datagridview
            tabelaFucionario.DataSource = dao.ListarFuncionario();
        }

        private void tabelaFucionario_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada
            txtCodigo.Text = tabelaFucionario.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFucionario.CurrentRow.Cells[1].Value.ToString();
            txtRg.Text = tabelaFucionario.CurrentRow.Cells[2].Value.ToString();
            txtCpf.Text = tabelaFucionario.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = tabelaFucionario.CurrentRow.Cells[4].Value.ToString();
            txtSenha.Text = tabelaFucionario.CurrentRow.Cells[5].Value.ToString();
            txtCargo.Text = tabelaFucionario.CurrentRow.Cells[6].Value.ToString();
            txtNivelAcesso.Text = tabelaFucionario.CurrentRow.Cells[7].Value.ToString();
            txtTelefone.Text = tabelaFucionario.CurrentRow.Cells[8].Value.ToString();
            txtCelular.Text = tabelaFucionario.CurrentRow.Cells[9].Value.ToString();
            txtCep.Text = tabelaFucionario.CurrentRow.Cells[10].Value.ToString();
            txtEndereco.Text = tabelaFucionario.CurrentRow.Cells[11].Value.ToString();
            txtNumero.Text = tabelaFucionario.CurrentRow.Cells[12].Value.ToString();
            txtComplemento.Text = tabelaFucionario.CurrentRow.Cells[13].Value.ToString();
            txtBairro.Text = tabelaFucionario.CurrentRow.Cells[14].Value.ToString();
            txtCidade.Text = tabelaFucionario.CurrentRow.Cells[15].Value.ToString();
            cbEstado.Text = tabelaFucionario.CurrentRow.Cells[16].Value.ToString();

            //Alterar para a guia Dados Pessoais
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == null)
            {
                return;
            }

            Funcionario obj = new Funcionario();
            obj.codigo = int.Parse(txtCodigo.Text);

            FuncionarioDao dao = new FuncionarioDao();
            dao.ExcluirFuncionario(obj);

            //recarregar o datagridview
            tabelaFucionario.DataSource = dao.ListarFuncionario();
        }

        private void tabelaFucionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFucionario.CurrentRow.Cells[0].Value.ToString();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            FuncionarioDao dao = new FuncionarioDao();

            tabelaFucionario.DataSource = dao.PesquisaNomeFuncionario(nome);

            if (tabelaFucionario.Rows.Count == 0)
            {
                tabelaFucionario.DataSource = dao.ListarFuncionario();
            }
        }
    }
}