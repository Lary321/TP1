namespace telasTrab
{
    partial class telaCadastro
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaCadastro));
            this.btCadastroFuncionario = new System.Windows.Forms.Button();
            this.btCadastroFornecedor = new System.Windows.Forms.Button();
            this.btCadastroCliente = new System.Windows.Forms.Button();
            this.btCadastroFesta = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btCadastroFuncionario
            // 
            this.btCadastroFuncionario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadastroFuncionario.BackgroundImage")));
            this.btCadastroFuncionario.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.btCadastroFuncionario.Location = new System.Drawing.Point(247, 55);
            this.btCadastroFuncionario.Name = "btCadastroFuncionario";
            this.btCadastroFuncionario.Size = new System.Drawing.Size(190, 60);
            this.btCadastroFuncionario.TabIndex = 0;
            this.btCadastroFuncionario.Text = "Cadastrar Funcionário";
            this.btCadastroFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadastroFuncionario.UseVisualStyleBackColor = true;
            this.btCadastroFuncionario.Click += new System.EventHandler(this.btCadastroFuncionario_Click);
            // 
            // btCadastroFornecedor
            // 
            this.btCadastroFornecedor.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadastroFornecedor.BackgroundImage")));
            this.btCadastroFornecedor.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.btCadastroFornecedor.Location = new System.Drawing.Point(247, 151);
            this.btCadastroFornecedor.Name = "btCadastroFornecedor";
            this.btCadastroFornecedor.Size = new System.Drawing.Size(190, 60);
            this.btCadastroFornecedor.TabIndex = 1;
            this.btCadastroFornecedor.Text = "Cadastrar Fornecedor";
            this.btCadastroFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadastroFornecedor.UseVisualStyleBackColor = true;
            this.btCadastroFornecedor.Click += new System.EventHandler(this.btCadastroFornecedor_Click);
            // 
            // btCadastroCliente
            // 
            this.btCadastroCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadastroCliente.BackgroundImage")));
            this.btCadastroCliente.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.btCadastroCliente.Location = new System.Drawing.Point(248, 248);
            this.btCadastroCliente.Name = "btCadastroCliente";
            this.btCadastroCliente.Size = new System.Drawing.Size(190, 60);
            this.btCadastroCliente.TabIndex = 2;
            this.btCadastroCliente.Text = "Cadastrar Cliente";
            this.btCadastroCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadastroCliente.UseVisualStyleBackColor = true;
            this.btCadastroCliente.Click += new System.EventHandler(this.btCadastroCliente_Click);
            // 
            // btCadastroFesta
            // 
            this.btCadastroFesta.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btCadastroFesta.BackgroundImage")));
            this.btCadastroFesta.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.btCadastroFesta.Location = new System.Drawing.Point(247, 341);
            this.btCadastroFesta.Name = "btCadastroFesta";
            this.btCadastroFesta.Size = new System.Drawing.Size(190, 60);
            this.btCadastroFesta.TabIndex = 3;
            this.btCadastroFesta.Text = "Cadastrar Festa";
            this.btCadastroFesta.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btCadastroFesta.UseVisualStyleBackColor = true;
            this.btCadastroFesta.Click += new System.EventHandler(this.btCadastroFesta_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.Location = new System.Drawing.Point(13, 13);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(50, 50);
            this.btVoltar.TabIndex = 7;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // telaCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btCadastroFesta);
            this.Controls.Add(this.btCadastroCliente);
            this.Controls.Add(this.btCadastroFornecedor);
            this.Controls.Add(this.btCadastroFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaCadastro";
            this.Text = "Cadastro";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btCadastroFuncionario;
        private System.Windows.Forms.Button btCadastroFornecedor;
        private System.Windows.Forms.Button btCadastroCliente;
        private System.Windows.Forms.Button btCadastroFesta;
        private System.Windows.Forms.Button btVoltar;
    }
}

