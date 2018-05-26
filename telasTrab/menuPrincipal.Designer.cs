namespace telasTrab
{
    partial class menuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(menuPrincipal));
            this.novoCadastro = new System.Windows.Forms.Button();
            this.pesquisarCadastro = new System.Windows.Forms.Button();
            this.relatorio = new System.Windows.Forms.Button();
            this.sair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // novoCadastro
            // 
            this.novoCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("novoCadastro.BackgroundImage")));
            this.novoCadastro.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.novoCadastro.Location = new System.Drawing.Point(65, 235);
            this.novoCadastro.Name = "novoCadastro";
            this.novoCadastro.Size = new System.Drawing.Size(190, 60);
            this.novoCadastro.TabIndex = 0;
            this.novoCadastro.Text = "Novo Cadastro";
            this.novoCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.novoCadastro.UseVisualStyleBackColor = true;
            this.novoCadastro.Click += new System.EventHandler(this.novoCadastro_Click);
            // 
            // pesquisarCadastro
            // 
            this.pesquisarCadastro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pesquisarCadastro.BackgroundImage")));
            this.pesquisarCadastro.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pesquisarCadastro.Location = new System.Drawing.Point(65, 315);
            this.pesquisarCadastro.Name = "pesquisarCadastro";
            this.pesquisarCadastro.Size = new System.Drawing.Size(190, 60);
            this.pesquisarCadastro.TabIndex = 3;
            this.pesquisarCadastro.Text = "Pesquisar";
            this.pesquisarCadastro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pesquisarCadastro.UseVisualStyleBackColor = true;
            this.pesquisarCadastro.Click += new System.EventHandler(this.pesquisarCadastro_Click);
            // 
            // relatorio
            // 
            this.relatorio.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("relatorio.BackgroundImage")));
            this.relatorio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.relatorio.Location = new System.Drawing.Point(65, 395);
            this.relatorio.Name = "relatorio";
            this.relatorio.Size = new System.Drawing.Size(190, 60);
            this.relatorio.TabIndex = 4;
            this.relatorio.Text = "Relatórios";
            this.relatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.relatorio.UseVisualStyleBackColor = true;
            this.relatorio.Click += new System.EventHandler(this.relatorio_Click);
            // 
            // sair
            // 
            this.sair.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sair.BackgroundImage")));
            this.sair.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sair.Location = new System.Drawing.Point(359, 395);
            this.sair.Name = "sair";
            this.sair.Size = new System.Drawing.Size(110, 60);
            this.sair.TabIndex = 5;
            this.sair.Text = "Sair";
            this.sair.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.sair.UseVisualStyleBackColor = true;
            this.sair.Click += new System.EventHandler(this.sair_Click);
            // 
            // menuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.sair);
            this.Controls.Add(this.relatorio);
            this.Controls.Add(this.pesquisarCadastro);
            this.Controls.Add(this.novoCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "menuPrincipal";
            this.Text = "Patati Patatá Buffet Infantil";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button novoCadastro;
        private System.Windows.Forms.Button pesquisarCadastro;
        private System.Windows.Forms.Button relatorio;
        private System.Windows.Forms.Button sair;
    }
}