namespace telasTrab
{
    partial class _cadastroFornecedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_cadastroFornecedor));
            this.btVoltar = new System.Windows.Forms.PictureBox();
            this.btGravarFornecedor = new System.Windows.Forms.Button();
            this.nomeForn = new System.Windows.Forms.Label();
            this.nomeFornecedor = new System.Windows.Forms.TextBox();
            this.telFornecedor = new System.Windows.Forms.Label();
            this.prodFornecido = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.telefoneFornecedor = new System.Windows.Forms.MaskedTextBox();
            this.codFornecedor = new System.Windows.Forms.Label();
            this.produtoFornecido = new System.Windows.Forms.ComboBox();
            this.outroProduto = new System.Windows.Forms.TextBox();
            this.codigoFornecedor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btVoltar)).BeginInit();
            this.SuspendLayout();
            // 
            // btVoltar
            // 
            this.btVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btVoltar.Image")));
            this.btVoltar.Location = new System.Drawing.Point(12, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(76, 42);
            this.btVoltar.TabIndex = 4;
            this.btVoltar.TabStop = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // btGravarFornecedor
            // 
            this.btGravarFornecedor.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.btGravarFornecedor.Image = ((System.Drawing.Image)(resources.GetObject("btGravarFornecedor.Image")));
            this.btGravarFornecedor.Location = new System.Drawing.Point(290, 358);
            this.btGravarFornecedor.Name = "btGravarFornecedor";
            this.btGravarFornecedor.Size = new System.Drawing.Size(117, 61);
            this.btGravarFornecedor.TabIndex = 12;
            this.btGravarFornecedor.Text = "Gravar ";
            this.btGravarFornecedor.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGravarFornecedor.UseVisualStyleBackColor = true;
            this.btGravarFornecedor.Click += new System.EventHandler(this.btGravarFornecedor_Click);
            // 
            // nomeForn
            // 
            this.nomeForn.AutoSize = true;
            this.nomeForn.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.nomeForn.Location = new System.Drawing.Point(285, 115);
            this.nomeForn.Name = "nomeForn";
            this.nomeForn.Size = new System.Drawing.Size(58, 21);
            this.nomeForn.TabIndex = 14;
            this.nomeForn.Text = "Nome:";
            // 
            // nomeFornecedor
            // 
            this.nomeFornecedor.Location = new System.Drawing.Point(290, 140);
            this.nomeFornecedor.Name = "nomeFornecedor";
            this.nomeFornecedor.Size = new System.Drawing.Size(380, 20);
            this.nomeFornecedor.TabIndex = 13;
            // 
            // telFornecedor
            // 
            this.telFornecedor.AutoSize = true;
            this.telFornecedor.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.telFornecedor.Location = new System.Drawing.Point(285, 195);
            this.telFornecedor.Name = "telFornecedor";
            this.telFornecedor.Size = new System.Drawing.Size(78, 21);
            this.telFornecedor.TabIndex = 16;
            this.telFornecedor.Text = "Telefone:";
            // 
            // prodFornecido
            // 
            this.prodFornecido.AutoSize = true;
            this.prodFornecido.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.prodFornecido.Location = new System.Drawing.Point(285, 265);
            this.prodFornecido.Name = "prodFornecido";
            this.prodFornecido.Size = new System.Drawing.Size(152, 21);
            this.prodFornecido.TabIndex = 18;
            this.prodFornecido.Text = "Produto Fornecido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(159, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(456, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Para cadastrar um novo fornecedor, preencha os dados abaixo:";
            // 
            // telefoneFornecedor
            // 
            this.telefoneFornecedor.Location = new System.Drawing.Point(290, 220);
            this.telefoneFornecedor.Mask = "(00)00000-0000";
            this.telefoneFornecedor.Name = "telefoneFornecedor";
            this.telefoneFornecedor.Size = new System.Drawing.Size(91, 20);
            this.telefoneFornecedor.TabIndex = 20;
            // 
            // codFornecedor
            // 
            this.codFornecedor.AutoSize = true;
            this.codFornecedor.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.codFornecedor.Location = new System.Drawing.Point(285, 65);
            this.codFornecedor.Name = "codFornecedor";
            this.codFornecedor.Size = new System.Drawing.Size(155, 21);
            this.codFornecedor.TabIndex = 21;
            this.codFornecedor.Text = "Código Fornecedor:";
            // 
            // produtoFornecido
            // 
            this.produtoFornecido.FormattingEnabled = true;
            this.produtoFornecido.Items.AddRange(new object[] {
            "Artigos decorativos",
            "Balões",
            "Bebidas",
            "Bolos",
            "Brinquedos ",
            "Cadeiras e mesas",
            "Doces",
            "Guloseimas",
            "Itens personalizados",
            "Jogos de luzes e efeitos especiais",
            "Kit multimídia",
            "Lembrancinhas diversas",
            "Outros",
            "Salgados"});
            this.produtoFornecido.Location = new System.Drawing.Point(290, 290);
            this.produtoFornecido.Name = "produtoFornecido";
            this.produtoFornecido.Size = new System.Drawing.Size(150, 21);
            this.produtoFornecido.TabIndex = 22;
            this.produtoFornecido.SelectedIndexChanged += new System.EventHandler(this.produtoFornecido_SelectedIndexChanged);
            // 
            // outroProduto
            // 
            this.outroProduto.Location = new System.Drawing.Point(465, 290);
            this.outroProduto.Name = "outroProduto";
            this.outroProduto.Size = new System.Drawing.Size(150, 20);
            this.outroProduto.TabIndex = 23;
            // 
            // codigoFornecedor
            // 
            this.codigoFornecedor.AutoSize = true;
            this.codigoFornecedor.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.codigoFornecedor.Location = new System.Drawing.Point(446, 65);
            this.codigoFornecedor.Name = "codigoFornecedor";
            this.codigoFornecedor.Size = new System.Drawing.Size(0, 21);
            this.codigoFornecedor.TabIndex = 24;
            // 
            // _cadastroFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.codigoFornecedor);
            this.Controls.Add(this.outroProduto);
            this.Controls.Add(this.produtoFornecido);
            this.Controls.Add(this.codFornecedor);
            this.Controls.Add(this.telefoneFornecedor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.prodFornecido);
            this.Controls.Add(this.telFornecedor);
            this.Controls.Add(this.nomeForn);
            this.Controls.Add(this.nomeFornecedor);
            this.Controls.Add(this.btGravarFornecedor);
            this.Controls.Add(this.btVoltar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_cadastroFornecedor";
            this.Text = "Cadastro Fornecedor";
            ((System.ComponentModel.ISupportInitialize)(this.btVoltar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btVoltar;
        private System.Windows.Forms.Button btGravarFornecedor;
        private System.Windows.Forms.Label nomeForn;
        private System.Windows.Forms.TextBox nomeFornecedor;
        private System.Windows.Forms.Label telFornecedor;
        private System.Windows.Forms.Label prodFornecido;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox telefoneFornecedor;
        private System.Windows.Forms.Label codFornecedor;
        private System.Windows.Forms.ComboBox produtoFornecido;
        private System.Windows.Forms.TextBox outroProduto;
        private System.Windows.Forms.Label codigoFornecedor;
    }
}