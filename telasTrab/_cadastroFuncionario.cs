using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telasTrab
{
    public partial class _cadastroFuncionario : Form
    {
        public _cadastroFuncionario()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
          /*this.Hide();
            telaCadastro telaCadastro = new telaCadastro();
            telaCadastro.Closed += (s, args) => this.Close(); |encontrei essa linha de codigo mas nao sei o que
            significa|
            telaCadastro.StartPosition = FormStartPosition.CenterScreen;
            telaCadastro.Show();
          */
            this.Hide();
            telaCadastro telaMenuCadastro = new telaCadastro();
            telaMenuCadastro.StartPosition = FormStartPosition.CenterScreen;
            telaMenuCadastro.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaMenuCadastro.ShowDialog();
            this.Close();


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
