namespace telasTrab
{
    partial class _cadastroFesta
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
            System.Windows.Forms.Button gravarCliente;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_cadastroFesta));
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dTPdataFesta = new System.Windows.Forms.DateTimePicker();
            this.gpHoraDiaSemana = new System.Windows.Forms.GroupBox();
            this.timeHoradiaSemana2 = new System.Windows.Forms.DateTimePicker();
            this.timeHoradiaSemana1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDiaSemana = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpHoraFimSemana = new System.Windows.Forms.GroupBox();
            this.cbHoraFestaSabado = new System.Windows.Forms.ComboBox();
            this.cbNomeCliente = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbQtdConvidados = new System.Windows.Forms.ComboBox();
            this.btVoltar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbTemaFesta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.codigoFesta = new System.Windows.Forms.Label();
            gravarCliente = new System.Windows.Forms.Button();
            this.gpHoraDiaSemana.SuspendLayout();
            this.gpHoraFimSemana.SuspendLayout();
            this.SuspendLayout();
            // 
            // gravarCliente
            // 
            gravarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gravarCliente.Image = ((System.Drawing.Image)(resources.GetObject("gravarCliente.Image")));
            gravarCliente.Location = new System.Drawing.Point(207, 507);
            gravarCliente.Name = "gravarCliente";
            gravarCliente.Size = new System.Drawing.Size(118, 59);
            gravarCliente.TabIndex = 9;
            gravarCliente.Text = "Gravar";
            gravarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            gravarCliente.UseVisualStyleBackColor = true;
            gravarCliente.Click += new System.EventHandler(this.gravarFesta_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira as seguintes infomações para o cadastro da festa:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(11, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(11, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data da festa:";
            // 
            // dTPdataFesta
            // 
            this.dTPdataFesta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPdataFesta.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dTPdataFesta.Location = new System.Drawing.Point(137, 173);
            this.dTPdataFesta.Name = "dTPdataFesta";
            this.dTPdataFesta.Size = new System.Drawing.Size(99, 20);
            this.dTPdataFesta.TabIndex = 2;
            this.dTPdataFesta.Value = new System.DateTime(2018, 5, 19, 0, 0, 0, 0);
            // 
            // gpHoraDiaSemana
            // 
            this.gpHoraDiaSemana.Controls.Add(this.timeHoradiaSemana2);
            this.gpHoraDiaSemana.Controls.Add(this.timeHoradiaSemana1);
            this.gpHoraDiaSemana.Location = new System.Drawing.Point(15, 292);
            this.gpHoraDiaSemana.Name = "gpHoraDiaSemana";
            this.gpHoraDiaSemana.Size = new System.Drawing.Size(244, 100);
            this.gpHoraDiaSemana.TabIndex = 4;
            this.gpHoraDiaSemana.TabStop = false;
            // 
            // timeHoradiaSemana2
            // 
            this.timeHoradiaSemana2.Enabled = false;
            this.timeHoradiaSemana2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoradiaSemana2.Location = new System.Drawing.Point(137, 38);
            this.timeHoradiaSemana2.Name = "timeHoradiaSemana2";
            this.timeHoradiaSemana2.ShowUpDown = true;
            this.timeHoradiaSemana2.Size = new System.Drawing.Size(81, 20);
            this.timeHoradiaSemana2.TabIndex = 2;
            this.timeHoradiaSemana2.Value = new System.DateTime(2018, 5, 23, 16, 0, 0, 0);
            // 
            // timeHoradiaSemana1
            // 
            this.timeHoradiaSemana1.Enabled = false;
            this.timeHoradiaSemana1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoradiaSemana1.Location = new System.Drawing.Point(26, 38);
            this.timeHoradiaSemana1.Name = "timeHoradiaSemana1";
            this.timeHoradiaSemana1.ShowUpDown = true;
            this.timeHoradiaSemana1.Size = new System.Drawing.Size(81, 20);
            this.timeHoradiaSemana1.TabIndex = 1;
            this.timeHoradiaSemana1.Value = new System.DateTime(2018, 5, 23, 12, 0, 0, 0);
            this.timeHoradiaSemana1.ValueChanged += new System.EventHandler(this.timeHoradiaSemana1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(11, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dia da Semana:";
            // 
            // cbDiaSemana
            // 
            this.cbDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiaSemana.FormattingEnabled = true;
            this.cbDiaSemana.ItemHeight = 13;
            this.cbDiaSemana.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado",
            "Domingo"});
            this.cbDiaSemana.Location = new System.Drawing.Point(140, 227);
            this.cbDiaSemana.Name = "cbDiaSemana";
            this.cbDiaSemana.Size = new System.Drawing.Size(121, 21);
            this.cbDiaSemana.TabIndex = 3;
            this.cbDiaSemana.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiaSemana_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(11, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Horário da festa:";
            // 
            // gpHoraFimSemana
            // 
            this.gpHoraFimSemana.Controls.Add(this.cbHoraFestaSabado);
            this.gpHoraFimSemana.Location = new System.Drawing.Point(265, 292);
            this.gpHoraFimSemana.Name = "gpHoraFimSemana";
            this.gpHoraFimSemana.Size = new System.Drawing.Size(249, 100);
            this.gpHoraFimSemana.TabIndex = 5;
            this.gpHoraFimSemana.TabStop = false;
            // 
            // cbHoraFestaSabado
            // 
            this.cbHoraFestaSabado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHoraFestaSabado.Enabled = false;
            this.cbHoraFestaSabado.FormattingEnabled = true;
            this.cbHoraFestaSabado.Items.AddRange(new object[] {
            "12:00:00 a 16:00:00",
            "18:00:00 a 22:00:00"});
            this.cbHoraFestaSabado.Location = new System.Drawing.Point(24, 41);
            this.cbHoraFestaSabado.Name = "cbHoraFestaSabado";
            this.cbHoraFestaSabado.Size = new System.Drawing.Size(205, 21);
            this.cbHoraFestaSabado.TabIndex = 1;
            // 
            // cbNomeCliente
            // 
            this.cbNomeCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNomeCliente.FormattingEnabled = true;
            this.cbNomeCliente.Location = new System.Drawing.Point(137, 125);
            this.cbNomeCliente.Name = "cbNomeCliente";
            this.cbNomeCliente.Size = new System.Drawing.Size(259, 21);
            this.cbNomeCliente.TabIndex = 1;
            this.cbNomeCliente.SelectedIndexChanged += new System.EventHandler(this.cbNomeCliente_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Window;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(11, 413);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quantidade convidados:";
            // 
            // cbQtdConvidados
            // 
            this.cbQtdConvidados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbQtdConvidados.FormattingEnabled = true;
            this.cbQtdConvidados.Items.AddRange(new object[] {
            "30",
            "50",
            "80",
            "100"});
            this.cbQtdConvidados.Location = new System.Drawing.Point(189, 412);
            this.cbQtdConvidados.Name = "cbQtdConvidados";
            this.cbQtdConvidados.Size = new System.Drawing.Size(52, 21);
            this.cbQtdConvidados.TabIndex = 6;
            this.cbQtdConvidados.SelectedIndexChanged += new System.EventHandler(this.cbQtdConvidados_SelectedIndexChanged);
            // 
            // btVoltar
            // 
            this.btVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btVoltar.Image")));
            this.btVoltar.Location = new System.Drawing.Point(12, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(50, 50);
            this.btVoltar.TabIndex = 30;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Window;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(15, 458);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Tema da festa:";
            // 
            // tbTemaFesta
            // 
            this.tbTemaFesta.Location = new System.Drawing.Point(137, 457);
            this.tbTemaFesta.Name = "tbTemaFesta";
            this.tbTemaFesta.Size = new System.Drawing.Size(259, 20);
            this.tbTemaFesta.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Window;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label8.Location = new System.Drawing.Point(11, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Código da festa:";
            // 
            // codigoFesta
            // 
            this.codigoFesta.AutoSize = true;
            this.codigoFesta.BackColor = System.Drawing.SystemColors.Window;
            this.codigoFesta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.codigoFesta.Location = new System.Drawing.Point(142, 83);
            this.codigoFesta.Name = "codigoFesta";
            this.codigoFesta.Size = new System.Drawing.Size(0, 20);
            this.codigoFesta.TabIndex = 34;
            // 
            // _cadastroFesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(523, 578);
            this.Controls.Add(this.codigoFesta);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbTemaFesta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.cbQtdConvidados);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbNomeCliente);
            this.Controls.Add(gravarCliente);
            this.Controls.Add(this.gpHoraFimSemana);
            this.Controls.Add(this.gpHoraDiaSemana);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbDiaSemana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dTPdataFesta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_cadastroFesta";
            this.Text = "Cadastro Festa";
            this.Load += new System.EventHandler(this._cadastroFesta_Load);
            this.gpHoraDiaSemana.ResumeLayout(false);
            this.gpHoraFimSemana.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dTPdataFesta;
        private System.Windows.Forms.GroupBox gpHoraDiaSemana;
        private System.Windows.Forms.GroupBox gpHoraFimSemana;
        private System.Windows.Forms.ComboBox cbHoraFestaSabado;
        private System.Windows.Forms.DateTimePicker timeHoradiaSemana2;
        private System.Windows.Forms.DateTimePicker timeHoradiaSemana1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDiaSemana;
        private System.Windows.Forms.ComboBox cbNomeCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbQtdConvidados;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbTemaFesta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label codigoFesta;
    }
}