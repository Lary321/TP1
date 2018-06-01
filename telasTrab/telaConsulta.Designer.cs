namespace telasTrab
{
    partial class telaConsulta
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaConsulta));
            this.label1 = new System.Windows.Forms.Label();
            this.tipoPessoaPesquisada = new System.Windows.Forms.ComboBox();
            this.frasePesquisa = new System.Windows.Forms.Label();
            this.pesquisaTextBox = new System.Windows.Forms.TextBox();
            this.mostrarPesquisa = new System.Windows.Forms.RichTextBox();
            this.btGerarPesquisa = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btVoltar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 14F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(119, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecione uma opção de pesquisa:";
            // 
            // tipoPessoaPesquisada
            // 
            this.tipoPessoaPesquisada.BackColor = System.Drawing.SystemColors.Window;
            this.tipoPessoaPesquisada.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoPessoaPesquisada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tipoPessoaPesquisada.FormattingEnabled = true;
            this.tipoPessoaPesquisada.Items.AddRange(new object[] {
            "Cliente",
            "Fornecedor",
            "Funcionário"});
            this.tipoPessoaPesquisada.Location = new System.Drawing.Point(411, 14);
            this.tipoPessoaPesquisada.Name = "tipoPessoaPesquisada";
            this.tipoPessoaPesquisada.Size = new System.Drawing.Size(157, 24);
            this.tipoPessoaPesquisada.TabIndex = 6;
            this.tipoPessoaPesquisada.SelectedIndexChanged += new System.EventHandler(this.tipoPessoaPesquisada_SelectedIndexChanged);
            // 
            // frasePesquisa
            // 
            this.frasePesquisa.AutoSize = true;
            this.frasePesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.frasePesquisa.ForeColor = System.Drawing.Color.Black;
            this.frasePesquisa.Location = new System.Drawing.Point(145, 56);
            this.frasePesquisa.Name = "frasePesquisa";
            this.frasePesquisa.Size = new System.Drawing.Size(0, 20);
            this.frasePesquisa.TabIndex = 7;
            // 
            // pesquisaTextBox
            // 
            this.pesquisaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.pesquisaTextBox.Location = new System.Drawing.Point(214, 95);
            this.pesquisaTextBox.Name = "pesquisaTextBox";
            this.pesquisaTextBox.Size = new System.Drawing.Size(282, 23);
            this.pesquisaTextBox.TabIndex = 8;
            // 
            // mostrarPesquisa
            // 
            this.mostrarPesquisa.BackColor = System.Drawing.Color.LightYellow;
            this.mostrarPesquisa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mostrarPesquisa.Location = new System.Drawing.Point(14, 190);
            this.mostrarPesquisa.Name = "mostrarPesquisa";
            this.mostrarPesquisa.ReadOnly = true;
            this.mostrarPesquisa.Size = new System.Drawing.Size(678, 279);
            this.mostrarPesquisa.TabIndex = 9;
            this.mostrarPesquisa.Text = "";
            // 
            // btGerarPesquisa
            // 
            this.btGerarPesquisa.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarPesquisa.ForeColor = System.Drawing.SystemColors.MenuText;
            this.btGerarPesquisa.Image = ((System.Drawing.Image)(resources.GetObject("btGerarPesquisa.Image")));
            this.btGerarPesquisa.Location = new System.Drawing.Point(295, 124);
            this.btGerarPesquisa.Name = "btGerarPesquisa";
            this.btGerarPesquisa.Size = new System.Drawing.Size(110, 60);
            this.btGerarPesquisa.TabIndex = 10;
            this.btGerarPesquisa.Text = "Pesquisar";
            this.btGerarPesquisa.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGerarPesquisa.UseVisualStyleBackColor = true;
            this.btGerarPesquisa.Click += new System.EventHandler(this.btPesquisar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.Location = new System.Drawing.Point(14, 15);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(50, 50);
            this.btVoltar.TabIndex = 13;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // telaConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btGerarPesquisa);
            this.Controls.Add(this.mostrarPesquisa);
            this.Controls.Add(this.pesquisaTextBox);
            this.Controls.Add(this.frasePesquisa);
            this.Controls.Add(this.tipoPessoaPesquisada);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaConsulta";
            this.Text = "Pesquisas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox tipoPessoaPesquisada;
        private System.Windows.Forms.Label frasePesquisa;
        private System.Windows.Forms.TextBox pesquisaTextBox;
        private System.Windows.Forms.RichTextBox mostrarPesquisa;
        private System.Windows.Forms.Button btGerarPesquisa;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button btVoltar;
    }
}