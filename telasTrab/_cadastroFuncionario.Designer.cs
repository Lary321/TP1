﻿namespace telasTrab
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
            this.codFunc = new System.Windows.Forms.Label();
            this.codigoFuncionario = new System.Windows.Forms.Label();
            this.salarioFuncionario = new System.Windows.Forms.MaskedTextBox();
            this.outraFuncao = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nomeFuncionario
            // 
            this.nomeFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.nomeFuncionario.Location = new System.Drawing.Point(25, 149);
            this.nomeFuncionario.Name = "nomeFuncionario";
            this.nomeFuncionario.Size = new System.Drawing.Size(380, 23);
            this.nomeFuncionario.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(20, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Candara", 14F);
            this.label2.Location = new System.Drawing.Point(105, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(518, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Para cadastrar um novo funcionário, preencha os dados abaixo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(20, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 21);
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
            this.tipoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tipoFuncionario.FormattingEnabled = true;
            this.tipoFuncionario.Items.AddRange(new object[] {
            "Fixo(a)",
            "Temporário(a)"});
            this.tipoFuncionario.Location = new System.Drawing.Point(25, 344);
            this.tipoFuncionario.Name = "tipoFuncionario";
            this.tipoFuncionario.Size = new System.Drawing.Size(159, 24);
            this.tipoFuncionario.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(20, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Tipo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(200, 321);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Salário:";
            // 
            // telefoneFuncionario
            // 
            this.telefoneFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.telefoneFuncionario.Location = new System.Drawing.Point(25, 214);
            this.telefoneFuncionario.Mask = "(00)00000-0000";
            this.telefoneFuncionario.Name = "telefoneFuncionario";
            this.telefoneFuncionario.Size = new System.Drawing.Size(95, 23);
            this.telefoneFuncionario.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(20, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 21);
            this.label5.TabIndex = 17;
            this.label5.Text = "Função:";
            // 
            // funcaoFuncionario
            // 
            this.funcaoFuncionario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcaoFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
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
            "Segurança",
            "Outro(a)"});
            this.funcaoFuncionario.Location = new System.Drawing.Point(25, 279);
            this.funcaoFuncionario.Name = "funcaoFuncionario";
            this.funcaoFuncionario.Size = new System.Drawing.Size(159, 24);
            this.funcaoFuncionario.TabIndex = 18;
            this.funcaoFuncionario.SelectedIndexChanged += new System.EventHandler(this.funcaoFuncionario_SelectedIndexChanged);
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
            // codFunc
            // 
            this.codFunc.AutoSize = true;
            this.codFunc.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.codFunc.Location = new System.Drawing.Point(20, 84);
            this.codFunc.Name = "codFunc";
            this.codFunc.Size = new System.Drawing.Size(155, 21);
            this.codFunc.TabIndex = 20;
            this.codFunc.Text = "Código Funcionário:";
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
            this.salarioFuncionario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.salarioFuncionario.Location = new System.Drawing.Point(205, 344);
            this.salarioFuncionario.Mask = "$ 0000,00";
            this.salarioFuncionario.Name = "salarioFuncionario";
            this.salarioFuncionario.Size = new System.Drawing.Size(92, 23);
            this.salarioFuncionario.TabIndex = 22;
            // 
            // outraFuncao
            // 
            this.outraFuncao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.outraFuncao.Location = new System.Drawing.Point(204, 279);
            this.outraFuncao.Name = "outraFuncao";
            this.outraFuncao.Size = new System.Drawing.Size(201, 23);
            this.outraFuncao.TabIndex = 23;
            // 
            // _cadastroFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.outraFuncao);
            this.Controls.Add(this.salarioFuncionario);
            this.Controls.Add(this.codigoFuncionario);
            this.Controls.Add(this.codFunc);
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
        private System.Windows.Forms.Label codFunc;
        private System.Windows.Forms.Label codigoFuncionario;
        private System.Windows.Forms.MaskedTextBox salarioFuncionario;
        private System.Windows.Forms.TextBox outraFuncao;
    }
}