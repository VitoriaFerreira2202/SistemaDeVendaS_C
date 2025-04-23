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
    public partial class FrmProduto : Form
    {
        public FrmProduto()
        {
            InitializeComponent();
        }

        private void FrmProduto_Load(object sender, EventArgs e)
        {
            ProdutoDao F_dao = new ProdutoDao();
            tabelaProduto.DataSource = F_dao.ListaProduto();

            var dao = new FornecedorDao();
            cbFornecedor.DataSource = dao.ListarFornecedor();
            cbFornecedor.DisplayMember = "Nome";
            cbFornecedor.ValueMember = "id";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtDescricao.Text;
            obj.codigo_fornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());
            obj.preco = Double.Parse(txtPreco.Text);
            obj.quantidade_estoque = int.Parse(txtQntEstoque.Text);

            ProdutoDao dao = new ProdutoDao();
            dao.CadastroProduto(obj);
            tabelaProduto.DataSource = dao.ListaProduto();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text == null)
            {
                return;
            }

            Produto obj = new Produto();
            obj.codigo = int.Parse(txtCodigo.Text);

            ProdutoDao dao = new ProdutoDao();
            dao.ExcluirProduto(obj);

            //recarregar o datagridview
            tabelaProduto.DataSource = dao.ListaProduto();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto obj = new Produto();

            obj.descricao = txtDescricao.Text;
            obj.codigo_fornecedor = int.Parse(cbFornecedor.SelectedValue.ToString());
            obj.preco = Double.Parse(txtPreco.Text);
            obj.quantidade_estoque = int.Parse(txtQntEstoque.Text);

            ProdutoDao dao = new ProdutoDao();
            dao.AlteraProdudo(obj);
            tabelaProduto.DataSource = dao.ListaProduto();
        }

        private void tabelaProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaProduto.CurrentRow.Cells[0].Value.ToString();
            txtDescricao.Text = tabelaProduto.CurrentRow.Cells[1].Value.ToString();
            txtPreco.Text = tabelaProduto.CurrentRow.Cells[2].Value.ToString();
            txtQntEstoque.Text = tabelaProduto.CurrentRow.Cells[3].Value.ToString();
            cbFornecedor.Text = tabelaProduto.CurrentRow.Cells[4].Value.ToString();

            tabControl1.SelectedTab = tabPage1;
        }

        private void btnpesquisar_Click(object sender, EventArgs e)
        {
            string nome = txtPesquisa.Text;

            ProdutoDao dao = new ProdutoDao();

            tabelaProduto.DataSource = dao.PesquisaNomeProduto(nome);

            if (tabelaProduto.Rows.Count == 0)
            {
                tabelaProduto.DataSource = dao.ListaProduto();
            }
        }

        private void tabelaProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = tabelaProduto.CurrentRow.Cells[0].Value.ToString();
        }
    }
}