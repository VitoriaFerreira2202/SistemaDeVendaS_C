namespace SistemaDeVendaS_C.br.com.projeto.viem
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCadastrarCliente = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCadastrarFuncionario = new System.Windows.Forms.Button();
            this.btnCadastrarFornecedor = new System.Windows.Forms.Button();
            this.btnCadastrarProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCadastrarCliente
            // 
            this.btnCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarCliente.Location = new System.Drawing.Point(48, 144);
            this.btnCadastrarCliente.Name = "btnCadastrarCliente";
            this.btnCadastrarCliente.Size = new System.Drawing.Size(110, 76);
            this.btnCadastrarCliente.TabIndex = 0;
            this.btnCadastrarCliente.Text = "CADASTRAR CLIENTE";
            this.btnCadastrarCliente.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 1;
            // 
            // btnCadastrarFuncionario
            // 
            this.btnCadastrarFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFuncionario.Location = new System.Drawing.Point(200, 144);
            this.btnCadastrarFuncionario.Name = "btnCadastrarFuncionario";
            this.btnCadastrarFuncionario.Size = new System.Drawing.Size(110, 76);
            this.btnCadastrarFuncionario.TabIndex = 2;
            this.btnCadastrarFuncionario.Text = "CADASTRAR FUNCIONARIO";
            this.btnCadastrarFuncionario.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFornecedor
            // 
            this.btnCadastrarFornecedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarFornecedor.Location = new System.Drawing.Point(48, 245);
            this.btnCadastrarFornecedor.Name = "btnCadastrarFornecedor";
            this.btnCadastrarFornecedor.Size = new System.Drawing.Size(110, 76);
            this.btnCadastrarFornecedor.TabIndex = 3;
            this.btnCadastrarFornecedor.Text = "CADASTRAR FORNECEDOR";
            this.btnCadastrarFornecedor.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarProduto
            // 
            this.btnCadastrarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrarProduto.Location = new System.Drawing.Point(200, 245);
            this.btnCadastrarProduto.Name = "btnCadastrarProduto";
            this.btnCadastrarProduto.Size = new System.Drawing.Size(110, 76);
            this.btnCadastrarProduto.TabIndex = 4;
            this.btnCadastrarProduto.Text = "CADASTRAR PRODUTO\r\n";
            this.btnCadastrarProduto.UseVisualStyleBackColor = true;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.btnCadastrarProduto);
            this.Controls.Add(this.btnCadastrarFornecedor);
            this.Controls.Add(this.btnCadastrarFuncionario);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnCadastrarCliente);
            this.Name = "FrmMenu";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCliente;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCadastrarFuncionario;
        private System.Windows.Forms.Button btnCadastrarFornecedor;
        private System.Windows.Forms.Button btnCadastrarProduto;
    }
}