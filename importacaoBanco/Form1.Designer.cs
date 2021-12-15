namespace importacaoBanco
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnGerarArquivoClientes = new System.Windows.Forms.Button();
            this.BtnArquivoProduto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGerarArquivoClientes
            // 
            this.btnGerarArquivoClientes.Location = new System.Drawing.Point(12, 81);
            this.btnGerarArquivoClientes.Name = "btnGerarArquivoClientes";
            this.btnGerarArquivoClientes.Size = new System.Drawing.Size(368, 36);
            this.btnGerarArquivoClientes.TabIndex = 0;
            this.btnGerarArquivoClientes.Text = "Gerar Arquivo Clientes";
            this.btnGerarArquivoClientes.UseVisualStyleBackColor = true;
            this.btnGerarArquivoClientes.Click += new System.EventHandler(this.btnGerarArquivoClientes_Click);
            // 
            // BtnArquivoProduto
            // 
            this.BtnArquivoProduto.Location = new System.Drawing.Point(12, 123);
            this.BtnArquivoProduto.Name = "BtnArquivoProduto";
            this.BtnArquivoProduto.Size = new System.Drawing.Size(368, 36);
            this.BtnArquivoProduto.TabIndex = 1;
            this.BtnArquivoProduto.Text = "Gerar Arquivo Produto";
            this.BtnArquivoProduto.UseVisualStyleBackColor = true;
            this.BtnArquivoProduto.Click += new System.EventHandler(this.BtnArquivoProduto_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 450);
            this.Controls.Add(this.BtnArquivoProduto);
            this.Controls.Add(this.btnGerarArquivoClientes);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transportar Banco de dados para Arquivo TXT";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnGerarArquivoClientes;
        private Button BtnArquivoProduto;
    }
}