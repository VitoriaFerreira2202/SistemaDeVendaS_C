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
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            var cliente = new Frmcliente();
            cliente.Show();
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            var funcionario = new FrmFuncionario();
            funcionario.Show();
        }

        private void btnCadastrarFornecedor_Click(object sender, EventArgs e)
        {
            var fornecedor = new FrmFornecedor();
            fornecedor.Show();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            var produto = new FrmProduto();
            produto.Show();
        }
    }
}