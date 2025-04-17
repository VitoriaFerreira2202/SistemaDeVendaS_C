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
            cbFornecedor.DataSource = F_dao.ListaProduto();
            cbFornecedor.DisplayMember = "Nome";
            cbFornecedor.ValueMember = "id";

            ProdutoDao dao = new ProdutoDao();

            tabelaProduto.DataSource = dao.ListaProduto();
        }
    }
}