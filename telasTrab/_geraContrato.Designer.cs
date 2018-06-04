namespace telasTrab
{
    partial class _geraContrato
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_geraContrato));
            this.btVoltar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cbFestas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPagarCancelar = new System.Windows.Forms.ComboBox();
            this.cbFormaPagamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelPagamento = new System.Windows.Forms.Label();
            this.reais = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            gravarCliente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // gravarCliente
            // 
            gravarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gravarCliente.Image = ((System.Drawing.Image)(resources.GetObject("gravarCliente.Image")));
            gravarCliente.Location = new System.Drawing.Point(183, 292);
            gravarCliente.Name = "gravarCliente";
            gravarCliente.Size = new System.Drawing.Size(118, 59);
            gravarCliente.TabIndex = 21;
            gravarCliente.Text = "Confirmar";
            gravarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            gravarCliente.UseVisualStyleBackColor = true;
            gravarCliente.Click += new System.EventHandler(this.gravarContrato_Click);
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.Location = new System.Drawing.Point(12, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(50, 50);
            this.btVoltar.TabIndex = 14;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(81, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Selecione o código da festa para atualizar o contrato:";
            // 
            // cbFestas
            // 
            this.cbFestas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFestas.FormattingEnabled = true;
            this.cbFestas.Location = new System.Drawing.Point(151, 59);
            this.cbFestas.Name = "cbFestas";
            this.cbFestas.Size = new System.Drawing.Size(184, 21);
            this.cbFestas.TabIndex = 16;
            this.cbFestas.SelectedIndexChanged += new System.EventHandler(this.cbFestas_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(167, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "O que deseja fazer?";
            // 
            // cbPagarCancelar
            // 
            this.cbPagarCancelar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPagarCancelar.Enabled = false;
            this.cbPagarCancelar.FormattingEnabled = true;
            this.cbPagarCancelar.Items.AddRange(new object[] {
            "Cancelar contrato",
            "Pagar"});
            this.cbPagarCancelar.Location = new System.Drawing.Point(151, 135);
            this.cbPagarCancelar.Name = "cbPagarCancelar";
            this.cbPagarCancelar.Size = new System.Drawing.Size(184, 21);
            this.cbPagarCancelar.TabIndex = 18;
            this.cbPagarCancelar.SelectedIndexChanged += new System.EventHandler(this.cbPagarCancelar_SelectedIndexChanged);
            // 
            // cbFormaPagamento
            // 
            this.cbFormaPagamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormaPagamento.Enabled = false;
            this.cbFormaPagamento.FormattingEnabled = true;
            this.cbFormaPagamento.Items.AddRange(new object[] {
            "A vista",
            "Duas vezes",
            "Três vezes",
            "Quatro ou mais vezes"});
            this.cbFormaPagamento.Location = new System.Drawing.Point(274, 186);
            this.cbFormaPagamento.Name = "cbFormaPagamento";
            this.cbFormaPagamento.Size = new System.Drawing.Size(171, 21);
            this.cbFormaPagamento.TabIndex = 19;
            this.cbFormaPagamento.SelectedIndexChanged += new System.EventHandler(this.cbFormaPagamento_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(35, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(233, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Informe a forma de pagamento:";
            // 
            // labelPagamento
            // 
            this.labelPagamento.AutoSize = true;
            this.labelPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPagamento.Location = new System.Drawing.Point(216, 244);
            this.labelPagamento.Name = "labelPagamento";
            this.labelPagamento.Size = new System.Drawing.Size(0, 20);
            this.labelPagamento.TabIndex = 22;
            // 
            // reais
            // 
            this.reais.AutoSize = true;
            this.reais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.reais.Location = new System.Drawing.Point(292, 244);
            this.reais.Name = "reais";
            this.reais.Size = new System.Drawing.Size(43, 20);
            this.reais.TabIndex = 24;
            this.reais.Text = "reais";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(81, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Valor a ser pago:";
            // 
            // _geraContrato
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(487, 363);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.reais);
            this.Controls.Add(this.labelPagamento);
            this.Controls.Add(gravarCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbFormaPagamento);
            this.Controls.Add(this.cbPagarCancelar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbFestas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btVoltar);
            this.Name = "_geraContrato";
            this.Text = "Contrato";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbFestas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbPagarCancelar;
        private System.Windows.Forms.ComboBox cbFormaPagamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelPagamento;
        private System.Windows.Forms.Label reais;
        private System.Windows.Forms.Label label4;
    }
}