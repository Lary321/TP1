namespace telasTrab
{
    partial class telaRelatorio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(telaRelatorio));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rTBrelatorioCliente = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btPesquisar = new System.Windows.Forms.Button();
            this.btVoltar = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.gBnomeCliente = new System.Windows.Forms.GroupBox();
            this.gBdataFesta = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.btVoltar)).BeginInit();
            this.gBnomeCliente.SuspendLayout();
            this.gBdataFesta.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 0;
            // 
            // rTBrelatorioCliente
            // 
            this.rTBrelatorioCliente.Location = new System.Drawing.Point(12, 254);
            this.rTBrelatorioCliente.Name = "rTBrelatorioCliente";
            this.rTBrelatorioCliente.ReadOnly = true;
            this.rTBrelatorioCliente.Size = new System.Drawing.Size(680, 269);
            this.rTBrelatorioCliente.TabIndex = 1;
            this.rTBrelatorioCliente.Text = "";
            this.rTBrelatorioCliente.TextChanged += new System.EventHandler(this.rTBrelatorioCliente_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.label2.Location = new System.Drawing.Point(2, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe o nome do cliente:";
            // 
            // btPesquisar
            // 
            this.btPesquisar.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.btPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btPesquisar.Image")));
            this.btPesquisar.Location = new System.Drawing.Point(289, 189);
            this.btPesquisar.Name = "btPesquisar";
            this.btPesquisar.Size = new System.Drawing.Size(118, 59);
            this.btPesquisar.TabIndex = 4;
            this.btPesquisar.Text = "Pesquisar";
            this.btPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btPesquisar.UseVisualStyleBackColor = true;
            // 
            // btVoltar
            // 
            this.btVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btVoltar.Image")));
            this.btVoltar.Location = new System.Drawing.Point(12, 9);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(76, 42);
            this.btVoltar.TabIndex = 5;
            this.btVoltar.TabStop = false;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Data",
            "Clientes"});
            this.comboBox1.Location = new System.Drawing.Point(289, 47);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.label1.Location = new System.Drawing.Point(250, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 19);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exibir relatório de festas por:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(262, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Swis721 BlkCn BT", 12F);
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informe a data da festa:";
            // 
            // gBnomeCliente
            // 
            this.gBnomeCliente.Controls.Add(this.textBox1);
            this.gBnomeCliente.Controls.Add(this.label2);
            this.gBnomeCliente.Enabled = false;
            this.gBnomeCliente.Location = new System.Drawing.Point(12, 83);
            this.gBnomeCliente.Name = "gBnomeCliente";
            this.gBnomeCliente.Size = new System.Drawing.Size(279, 100);
            this.gBnomeCliente.TabIndex = 10;
            this.gBnomeCliente.TabStop = false;
            // 
            // gBdataFesta
            // 
            this.gBdataFesta.Controls.Add(this.label3);
            this.gBdataFesta.Controls.Add(this.dateTimePicker1);
            this.gBdataFesta.Enabled = false;
            this.gBdataFesta.Location = new System.Drawing.Point(405, 83);
            this.gBdataFesta.Name = "gBdataFesta";
            this.gBdataFesta.Size = new System.Drawing.Size(287, 100);
            this.gBdataFesta.TabIndex = 11;
            this.gBdataFesta.TabStop = false;
            // 
            // telaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(704, 535);
            this.Controls.Add(this.gBdataFesta);
            this.Controls.Add(this.gBnomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.btPesquisar);
            this.Controls.Add(this.rTBrelatorioCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.telaRelatorio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btVoltar)).EndInit();
            this.gBnomeCliente.ResumeLayout(false);
            this.gBnomeCliente.PerformLayout();
            this.gBdataFesta.ResumeLayout(false);
            this.gBdataFesta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.RichTextBox rTBrelatorioCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btPesquisar;
        private System.Windows.Forms.PictureBox btVoltar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBnomeCliente;
        private System.Windows.Forms.GroupBox gBdataFesta;
    }
}