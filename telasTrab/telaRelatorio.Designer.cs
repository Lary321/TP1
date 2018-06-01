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
            this.label2 = new System.Windows.Forms.Label();
            this.btGerarRelatorio = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gBnomeCliente = new System.Windows.Forms.GroupBox();
            this.gBdataFesta = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.gBRelatorioClienteData = new System.Windows.Forms.GroupBox();
            this.rBRelatorioCliente = new System.Windows.Forms.RadioButton();
            this.rBRelatorioData = new System.Windows.Forms.RadioButton();
            this.btVoltar = new System.Windows.Forms.Button();
            this.gBnomeCliente.SuspendLayout();
            this.gBdataFesta.SuspendLayout();
            this.gBRelatorioClienteData.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 50);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(267, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(2, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(197, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Informe o nome do cliente:";
            // 
            // btGerarRelatorio
            // 
            this.btGerarRelatorio.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGerarRelatorio.Image = ((System.Drawing.Image)(resources.GetObject("btGerarRelatorio.Image")));
            this.btGerarRelatorio.Location = new System.Drawing.Point(258, 182);
            this.btGerarRelatorio.Name = "btGerarRelatorio";
            this.btGerarRelatorio.Size = new System.Drawing.Size(190, 60);
            this.btGerarRelatorio.TabIndex = 4;
            this.btGerarRelatorio.Text = "Gerar Relatório";
            this.btGerarRelatorio.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGerarRelatorio.UseVisualStyleBackColor = true;
            this.btGerarRelatorio.Click += new System.EventHandler(this.btGerarRelatorio_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Window;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(162, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Exibir relatório de festas por:";
            // 
            // gBnomeCliente
            // 
            this.gBnomeCliente.Controls.Add(this.textBox1);
            this.gBnomeCliente.Controls.Add(this.label2);
            this.gBnomeCliente.Enabled = false;
            this.gBnomeCliente.Location = new System.Drawing.Point(215, 66);
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
            this.gBdataFesta.Location = new System.Drawing.Point(215, 66);
            this.gBdataFesta.Name = "gBdataFesta";
            this.gBdataFesta.Size = new System.Drawing.Size(279, 100);
            this.gBdataFesta.TabIndex = 11;
            this.gBdataFesta.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Window;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Informe a data da festa:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(10, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(263, 20);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // gBRelatorioClienteData
            // 
            this.gBRelatorioClienteData.Controls.Add(this.rBRelatorioCliente);
            this.gBRelatorioClienteData.Controls.Add(this.rBRelatorioData);
            this.gBRelatorioClienteData.Location = new System.Drawing.Point(377, 15);
            this.gBRelatorioClienteData.Name = "gBRelatorioClienteData";
            this.gBRelatorioClienteData.Size = new System.Drawing.Size(165, 42);
            this.gBRelatorioClienteData.TabIndex = 14;
            this.gBRelatorioClienteData.TabStop = false;
            // 
            // rBRelatorioCliente
            // 
            this.rBRelatorioCliente.AutoSize = true;
            this.rBRelatorioCliente.Location = new System.Drawing.Point(14, 14);
            this.rBRelatorioCliente.Name = "rBRelatorioCliente";
            this.rBRelatorioCliente.Size = new System.Drawing.Size(57, 17);
            this.rBRelatorioCliente.TabIndex = 1;
            this.rBRelatorioCliente.TabStop = true;
            this.rBRelatorioCliente.Text = "Cliente";
            this.rBRelatorioCliente.UseVisualStyleBackColor = true;
            this.rBRelatorioCliente.CheckedChanged += new System.EventHandler(this.rBRelatorioCliente_CheckedChanged);
            // 
            // rBRelatorioData
            // 
            this.rBRelatorioData.AutoSize = true;
            this.rBRelatorioData.Location = new System.Drawing.Point(102, 14);
            this.rBRelatorioData.Name = "rBRelatorioData";
            this.rBRelatorioData.Size = new System.Drawing.Size(48, 17);
            this.rBRelatorioData.TabIndex = 2;
            this.rBRelatorioData.TabStop = true;
            this.rBRelatorioData.Text = "Data";
            this.rBRelatorioData.UseVisualStyleBackColor = true;
            this.rBRelatorioData.CheckedChanged += new System.EventHandler(this.rBRelatorioData_CheckedChanged);
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.Location = new System.Drawing.Point(12, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(50, 50);
            this.btVoltar.TabIndex = 15;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // telaRelatorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.gBRelatorioClienteData);
            this.Controls.Add(this.gBdataFesta);
            this.Controls.Add(this.gBnomeCliente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btGerarRelatorio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "telaRelatorio";
            this.Text = "Relatório";
            this.Load += new System.EventHandler(this.telaRelatorio_Load);
            this.gBnomeCliente.ResumeLayout(false);
            this.gBnomeCliente.PerformLayout();
            this.gBdataFesta.ResumeLayout(false);
            this.gBdataFesta.PerformLayout();
            this.gBRelatorioClienteData.ResumeLayout(false);
            this.gBRelatorioClienteData.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btGerarRelatorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gBnomeCliente;
        private System.Windows.Forms.GroupBox gBRelatorioClienteData;
        private System.Windows.Forms.RadioButton rBRelatorioCliente;
        private System.Windows.Forms.RadioButton rBRelatorioData;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gBdataFesta;
        private System.Windows.Forms.Button btVoltar;
    }
}