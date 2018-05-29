namespace telasTrab
{
    partial class _cadastroFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_cadastroFuncionario));
            this.nomeFuncionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btGravarFuncionario = new System.Windows.Forms.Button();
            this.tipoFuncionario = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.telefoneFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.funcaoFuncionario = new System.Windows.Forms.ComboBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.codigoFuncionario = new System.Windows.Forms.Label();
            this.salarioFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.Location = new System.Drawing.Point(25, 149);
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.Size = new System.Drawing.Size(380, 20);
            this.nomeFuncionario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(105, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(519, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para cadastrar um novo funcionário, preencha os dados abaixo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Telefone:";
            // 
            // btGravarFuncionario
            // 
            this.btGravarFuncionario.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.btGravarFuncionario.Image = ((System.Drawing.Image)(resources.GetObject("btGravarFuncionario.Image")));
            this.btGravarFuncionario.Location = new System.Drawing.Point(23, 394);
            this.btGravarFuncionario.Name = "btGravarFuncionario";
            this.btGravarFuncionario.Size = new System.Drawing.Size(110, 60);
            this.btGravarFuncionario.TabIndex = 11;
            this.btGravarFuncionario.Text = "Gravar ";
            this.btGravarFuncionario.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGravarFuncionario.UseVisualStyleBackColor = true;
            this.btGravarFuncionario.Click += new System.EventHandler(this.btGravarFuncionario_Click);
            // 
            // tipoFuncionario
            // 
            this.tipoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoFuncionario.FormattingEnabled = true;
            this.tipoFuncionario.Items.AddRange(new object[] {
            "Fixo(a)",
            "Temporário(a)"});
            this.tipoFuncionario.Location = new System.Drawing.Point(224, 279);
            this.tipoFuncionario.Name = "tipoFuncionario";
            this.tipoFuncionario.Size = new System.Drawing.Size(159, 21);
            this.tipoFuncionario.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(219, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(20, 319);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salário:";
            // 
            // telefoneFuncionario
            // 
            this.telefoneFuncionario.Location = new System.Drawing.Point(25, 214);
            this.telefoneFuncionario.Mask = "(00)00000-0000";
            this.telefoneFuncionario.Name = "telefoneFuncionario";
            this.telefoneFuncionario.Size = new System.Drawing.Size(91, 20);
            this.telefoneFuncionario.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(20, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Função:";
            // 
            // funcaoFuncionario
            // 
            this.funcaoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcaoFuncionario.FormattingEnabled = true;
            this.funcaoFuncionario.Items.AddRange(new object[] {
            "Animador(a) de Festa",
            "Cerimonialista",
            "Cozinheiro(a)",
            "Decorador(a)",
            "DJ",
            "Faxineiro(a)",
            "Fotógrafo",
            "Garçon",
            "Garçonete",
            "Monitor(a)",
            "Recepcionista",
            "Secretário(a)",
            "Segurança"});
            this.funcaoFuncionario.Location = new System.Drawing.Point(25, 279);
            this.funcaoFuncionario.Name = "funcaoFuncionario";
            this.funcaoFuncionario.Size = new System.Drawing.Size(159, 21);
            this.funcaoFuncionario.TabIndex = 18;
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.Location = new System.Drawing.Point(24, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(50, 50);
            this.btVoltar.TabIndex = 19;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(20, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(150, 20);
            this.label7.TabIndex = 20;
            this.label7.Text = "Código Funcionário:";
            // 
            // codigoFuncionario
            // 
            this.codigoFuncionario.AutoSize = true;
            this.codigoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codigoFuncionario.Location = new System.Drawing.Point(176, 84);
            this.codigoFuncionario.Name = "codigoFuncionario";
            this.codigoFuncionario.Size = new System.Drawing.Size(0, 20);
            this.codigoFuncionario.TabIndex = 21;
            // 
            // salarioFuncionario
            // 
            this.salarioFuncionario.Location = new System.Drawing.Point(24, 342);
            this.salarioFuncionario.Mask = "$ 0000,00";
            this.salarioFuncionario.Name = "salarioFuncionario";
            this.salarioFuncionario.Size = new System.Drawing.Size(92, 20);
            this.salarioFuncionario.TabIndex = 22;
            // 
            // _cadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.salarioFuncionario);
            this.Controls.Add(this.codigoFuncionario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.funcaoFuncionario);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.telefoneFuncionario);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tipoFuncionario);
            this.Controls.Add(this.btGravarFuncionario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_cadastroFuncionario";
            this.Text = "Cadastro Funcionário";
            this.Load += new System.EventHandler(this._cadastroFuncionario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nomeFuncionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btGravarFuncionario;
        private System.Windows.Forms.ComboBox tipoFuncionario;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox telefoneFuncionario;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox funcaoFuncionario;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label codigoFuncionario;
        private System.Windows.Forms.MaskedTextBox salarioFuncionario;
    }
}