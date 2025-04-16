using Org.BouncyCastle.Pqc.Crypto.Lms;
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
    public partial class FrmFornecedor : Form
    {
        public FrmFornecedor()
        {
            InitializeComponent();
        }

        private void FrmFornecedor_Load(object sender, EventArgs e)
        {
            FornecedorDao dao = new FornecedorDao();
            tabelaFornecedor.DataSource = dao.ListarFornecedor();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();

            obj.nome = txtNome.Text;
            obj.cnpj = txtCnpj.Text;
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

            // - Criar um objeto da classeDAO  e chamar o metodo cadastrarFornecedor
            FornecedorDao dao = new FornecedorDao();
            dao.CadastrarFornecedor(obj);
            tabelaFornecedor.DataSource = dao.ListarFornecedor();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == null)
            {
                return;
            }

            Fornecedor obj = new Fornecedor();
            obj.codigo = int.Parse(txtCodigo.Text);

            FornecedorDao dao = new FornecedorDao();
            dao.ExcluirFornecedor(obj);

            //recarregar o datagridview
            tabelaFornecedor.DataSource = dao.ListarFornecedor();
        }

        private void tabelaFornecedor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
        }

        private void tabelaFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Pegar os dados da linha selecionada
            txtCodigo.Text = tabelaFornecedor.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = tabelaFornecedor.CurrentRow.Cells[1].Value.ToString();
            txtCnpj.Text = tabelaFornecedor.CurrentRow.Cells[2].Value.ToString();
            txtEmail.Text = tabelaFornecedor.CurrentRow.Cells[3].Value.ToString();
            txtTelefone.Text = tabelaFornecedor.CurrentRow.Cells[4].Value.ToString();
            txtCelular.Text = tabelaFornecedor.CurrentRow.Cells[5].Value.ToString();
            txtCep.Text = tabelaFornecedor.CurrentRow.Cells[6].Value.ToString();
            txtEndereco.Text = tabelaFornecedor.CurrentRow.Cells[7].Value.ToString();
            txtNumero.Text = tabelaFornecedor.CurrentRow.Cells[8].Value.ToString();
            txtComplemento.Text = tabelaFornecedor.CurrentRow.Cells[9].Value.ToString();
            txtBairro.Text = tabelaFornecedor.CurrentRow.Cells[10].Value.ToString();
            txtCidade.Text = tabelaFornecedor.CurrentRow.Cells[11].Value.ToString();
            cbEstado.Text = tabelaFornecedor.CurrentRow.Cells[12].Value.ToString();

            //Alterar para a guia Dados Pessoais
            tabControl1.SelectedTab = tabPage1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Fornecedor obj = new Fornecedor();
            obj.nome = txtNome.Text;
            obj.cnpj = txtCnpj.Text;
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

            FornecedorDao dao = new FornecedorDao();
            dao.AlteraFornecedor(obj);

            tabelaFornecedor.DataSource = dao.ListarFornecedor();
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            FornecedorDao dao = new FornecedorDao();

            tabelaFornecedor.DataSource = dao.PesquisaNomeFornecedor(nome);

            if (tabelaFornecedor.Rows.Count == 0)
            {
                tabelaFornecedor.DataSource = dao.ListarFornecedor();
            }
        }
    }
}