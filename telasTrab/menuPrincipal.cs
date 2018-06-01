using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telasTrab
{
    public partial class menuPrincipal : Form
    {
        public menuPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void novoCadastro_Click(object sender, EventArgs e)
        {
            
            telaCadastro telaCadastro = new telaCadastro();
            telaCadastro.StartPosition = FormStartPosition.CenterScreen;
            telaCadastro.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaCadastro.ControlBox = false;
            telaCadastro.ShowDialog();
            
        }

        private void pesquisarCadastro_Click(object sender, EventArgs e)
        {
            telaConsulta telaConsulta = new telaConsulta();
            telaConsulta.StartPosition = FormStartPosition.CenterScreen;
            telaConsulta.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaConsulta.ControlBox = false;
            telaConsulta.ShowDialog();
        }

        private void relatorio_Click(object sender, EventArgs e)
        {
            telaRelatorio telaRelatorio = new telaRelatorio();
            telaRelatorio.StartPosition = FormStartPosition.CenterScreen;
            telaRelatorio.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaRelatorio.ControlBox = false;
            telaRelatorio.ShowDialog();
        }

        private void sair_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Deseja realmente sair?","Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ate mais!","", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                return;
            }                       
        }

        private void menuPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
