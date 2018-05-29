namespace telasTrab
{
    partial class _cadastroCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(_cadastroCliente));
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nomeCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.enderecoCliente = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btGravarCliente = new System.Windows.Forms.Button();
            this.telefoneCliente = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btVoltar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.codigoCliente = new System.Windows.Forms.Label();
            this.dTPnascimentoCliente = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(25, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Data de Nascimento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(25, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Telefone:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(25, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nome:";
            // 
            // nomeCliente
            // 
            this.nomeCliente.Location = new System.Drawing.Point(30, 155);
            this.nomeCliente.Name = "nomeCliente";
            this.nomeCliente.Size = new System.Drawing.Size(380, 20);
            this.nomeCliente.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(25, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Endereço:";
            // 
            // enderecoCliente
            // 
            this.enderecoCliente.Location = new System.Drawing.Point(30, 220);
            this.enderecoCliente.Name = "enderecoCliente";
            this.enderecoCliente.Size = new System.Drawing.Size(380, 20);
            this.enderecoCliente.TabIndex = 18;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(451, 130);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(184, 283);
            this.pictureBox2.TabIndex = 20;
            this.pictureBox2.TabStop = false;
            // 
            // btGravarCliente
            // 
            this.btGravarCliente.Font = new System.Drawing.Font("Candara", 12.25F, System.Drawing.FontStyle.Bold);
            this.btGravarCliente.Image = ((System.Drawing.Image)(resources.GetObject("btGravarCliente.Image")));
            this.btGravarCliente.Location = new System.Drawing.Point(30, 382);
            this.btGravarCliente.Name = "btGravarCliente";
            this.btGravarCliente.Size = new System.Drawing.Size(117, 61);
            this.btGravarCliente.TabIndex = 21;
            this.btGravarCliente.Text = "Gravar ";
            this.btGravarCliente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btGravarCliente.UseVisualStyleBackColor = true;
            this.btGravarCliente.Click += new System.EventHandler(this.btGravarCliente_Click);
            // 
            // telefoneCliente
            // 
            this.telefoneCliente.Location = new System.Drawing.Point(29, 280);
            this.telefoneCliente.Mask = "(00)00000-0000";
            this.telefoneCliente.Name = "telefoneCliente";
            this.telefoneCliente.Size = new System.Drawing.Size(88, 20);
            this.telefoneCliente.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(25, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Código Cliente:";
            // 
            // btVoltar
            // 
            this.btVoltar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btVoltar.BackgroundImage")));
            this.btVoltar.Location = new System.Drawing.Point(29, 12);
            this.btVoltar.Name = "btVoltar";
            this.btVoltar.Size = new System.Drawing.Size(50, 50);
            this.btVoltar.TabIndex = 25;
            this.btVoltar.UseVisualStyleBackColor = true;
            this.btVoltar.Click += new System.EventHandler(this.btVoltar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Window;
            this.label2.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(121, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(481, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Para cadastrar um novo cliente, preencha os dados abaixo:";
            // 
            // codigoCliente
            // 
            this.codigoCliente.AutoSize = true;
            this.codigoCliente.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codigoCliente.Location = new System.Drawing.Point(141, 82);
            this.codigoCliente.Name = "codigoCliente";
            this.codigoCliente.Size = new System.Drawing.Size(0, 23);
            this.codigoCliente.TabIndex = 26;
            // 
            // dTPnascimentoCliente
            // 
            this.dTPnascimentoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTPnascimentoCliente.Location = new System.Drawing.Point(30, 350);
            this.dTPnascimentoCliente.Name = "dTPnascimentoCliente";
            this.dTPnascimentoCliente.Size = new System.Drawing.Size(200, 20);
            this.dTPnascimentoCliente.TabIndex = 27;
            this.dTPnascimentoCliente.Value = new System.DateTime(2018, 5, 26, 0, 0, 0, 0);
            // 
            // _cadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(704, 481);
            this.Controls.Add(this.dTPnascimentoCliente);
            this.Controls.Add(this.codigoCliente);
            this.Controls.Add(this.btVoltar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.telefoneCliente);
            this.Controls.Add(this.btGravarCliente);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.enderecoCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nomeCliente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "_cadastroCliente";
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this._cadastroCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomeCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox enderecoCliente;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btGravarCliente;
        private System.Windows.Forms.MaskedTextBox telefoneCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btVoltar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label codigoCliente;
        private System.Windows.Forms.DateTimePicker dTPnascimentoCliente;
    }
}