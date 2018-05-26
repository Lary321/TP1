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
            this.btVoltar = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gpHoraDiaSemana = new System.Windows.Forms.GroupBox();
            this.timeHoradiaSemana2 = new System.Windows.Forms.DateTimePicker();
            this.timeHoradiaSemana1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxDiaSemana = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gpHoraFimSemana = new System.Windows.Forms.GroupBox();
            this.cbHoraFestaSabado = new System.Windows.Forms.ComboBox();
            gravarCliente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.btVoltar)).BeginInit();
            this.gpHoraDiaSemana.SuspendLayout();
            this.gpHoraFimSemana.SuspendLayout();
            this.SuspendLayout();
            // 
            // gravarCliente
            // 
            gravarCliente.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            gravarCliente.Image = ((System.Drawing.Image)(resources.GetObject("gravarCliente.Image")));
            gravarCliente.Location = new System.Drawing.Point(180, 408);
            gravarCliente.Name = "gravarCliente";
            gravarCliente.Size = new System.Drawing.Size(118, 59);
            gravarCliente.TabIndex = 15;
            gravarCliente.Text = "Gravar";
            gravarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            gravarCliente.UseVisualStyleBackColor = true;
            gravarCliente.Click += new System.EventHandler(this.gravarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.label2.Location = new System.Drawing.Point(94, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(383, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "Insira as seguintes infomações para o cadastro da festa:";
            // 
            // btVoltar
            // 
            this.btVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btVoltar.Image")));
            this.btVoltar.Location = new System.Drawing.Point(12, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(76, 42);
            this.btVoltar.TabIndex = 6;
            this.btVoltar.TabStop = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.label1.Location = new System.Drawing.Point(8, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome do cliente:";
            // 
            // tbNomeCliente
            // 
            this.tbNomeCliente.Location = new System.Drawing.Point(134, 111);
            this.tbNomeCliente.Name = "tbNomeCliente";
            this.tbNomeCliente.Size = new System.Drawing.Size(294, 20);
            this.tbNomeCliente.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.label3.Location = new System.Drawing.Point(8, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data da festa:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.ImeMode = System.Windows.Forms.ImeMode.Katakana;
            this.dateTimePicker1.Location = new System.Drawing.Point(134, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(93, 20);
            this.dateTimePicker1.TabIndex = 10;
            this.dateTimePicker1.Value = new System.DateTime(2018, 5, 19, 15, 36, 35, 0);
            // 
            // gpHoraDiaSemana
            // 
            this.gpHoraDiaSemana.Controls.Add(this.timeHoradiaSemana2);
            this.gpHoraDiaSemana.Controls.Add(this.timeHoradiaSemana1);
            this.gpHoraDiaSemana.Location = new System.Drawing.Point(12, 294);
            this.gpHoraDiaSemana.Name = "gpHoraDiaSemana";
            this.gpHoraDiaSemana.Size = new System.Drawing.Size(221, 100);
            this.gpHoraDiaSemana.TabIndex = 11;
            this.gpHoraDiaSemana.TabStop = false;
            // 
            // timeHoradiaSemana2
            // 
            this.timeHoradiaSemana2.Enabled = false;
            this.timeHoradiaSemana2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoradiaSemana2.Location = new System.Drawing.Point(110, 38);
            this.timeHoradiaSemana2.Name = "timeHoradiaSemana2";
            this.timeHoradiaSemana2.ShowUpDown = true;
            this.timeHoradiaSemana2.Size = new System.Drawing.Size(81, 20);
            this.timeHoradiaSemana2.TabIndex = 15;
            this.timeHoradiaSemana2.Value = new System.DateTime(2018, 5, 23, 16, 0, 0, 0);
            // 
            // timeHoradiaSemana1
            // 
            this.timeHoradiaSemana1.Enabled = false;
            this.timeHoradiaSemana1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timeHoradiaSemana1.Location = new System.Drawing.Point(16, 38);
            this.timeHoradiaSemana1.Name = "timeHoradiaSemana1";
            this.timeHoradiaSemana1.ShowUpDown = true;
            this.timeHoradiaSemana1.Size = new System.Drawing.Size(81, 20);
            this.timeHoradiaSemana1.TabIndex = 14;
            this.timeHoradiaSemana1.Value = new System.DateTime(2018, 5, 23, 12, 0, 0, 0);
            this.timeHoradiaSemana1.ValueChanged += new System.EventHandler(this.timeHoradiaSemana1_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Window;
            this.label4.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.label4.Location = new System.Drawing.Point(8, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Dia da Semana:";
            // 
            // comboBoxDiaSemana
            // 
            this.comboBoxDiaSemana.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDiaSemana.FormattingEnabled = true;
            this.comboBoxDiaSemana.Items.AddRange(new object[] {
            "Segunda-feira",
            "Terça-feira",
            "Quarta-feira",
            "Quinta-feira",
            "Sexta-feira",
            "Sábado",
            "Domingo"});
            this.comboBoxDiaSemana.Location = new System.Drawing.Point(149, 220);
            this.comboBoxDiaSemana.Name = "comboBoxDiaSemana";
            this.comboBoxDiaSemana.Size = new System.Drawing.Size(121, 21);
            this.comboBoxDiaSemana.TabIndex = 13;
            this.comboBoxDiaSemana.SelectedIndexChanged += new System.EventHandler(this.comboBoxDiaSemana_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Window;
            this.label5.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.label5.Location = new System.Drawing.Point(12, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Horário da festa:";
            // 
            // gpHoraFimSemana
            // 
            this.gpHoraFimSemana.Controls.Add(this.cbHoraFestaSabado);
            this.gpHoraFimSemana.Location = new System.Drawing.Point(248, 294);
            this.gpHoraFimSemana.Name = "gpHoraFimSemana";
            this.gpHoraFimSemana.Size = new System.Drawing.Size(221, 100);
            this.gpHoraFimSemana.TabIndex = 14;
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
            this.cbHoraFestaSabado.Location = new System.Drawing.Point(23, 41);
            this.cbHoraFestaSabado.Name = "cbHoraFestaSabado";
            this.cbHoraFestaSabado.Size = new System.Drawing.Size(182, 21);
            this.cbHoraFestaSabado.TabIndex = 15;
            // 
            // _cadastroFesta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(481, 479);
            this.Controls.Add(gravarCliente);
            this.Controls.Add(this.gpHoraFimSemana);
            this.Controls.Add(this.gpHoraDiaSemana);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDiaSemana);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_cadastroFesta";
            this.Text = "Cadastro Festa";
            this.Load += new System.EventHandler(this._cadastroFesta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btVoltar)).EndInit();
            this.gpHoraDiaSemana.ResumeLayout(false);
            this.gpHoraFimSemana.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gpHoraDiaSemana;
        private System.Windows.Forms.GroupBox gpHoraFimSemana;
        private System.Windows.Forms.ComboBox cbHoraFestaSabado;
        private System.Windows.Forms.DateTimePicker timeHoradiaSemana2;
        private System.Windows.Forms.DateTimePicker timeHoradiaSemana1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxDiaSemana;
    }
}