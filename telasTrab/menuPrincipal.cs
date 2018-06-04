using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace telasTrab
{
    public partial class menuPrincipal : Form
    {
        // Inicialização do Menu Principal
        public menuPrincipal()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Botão que abre o menu de cadastros
        private void novoCadastro_Click(object sender, EventArgs e)
        {

            telaCadastro telaCadastro = new telaCadastro();
            telaCadastro.StartPosition = FormStartPosition.CenterScreen;
            telaCadastro.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaCadastro.ControlBox = false;
            telaCadastro.ShowDialog();

        }

        // Botão que abre a tela de pesquisas 
        private void pesquisarCadastro_Click(object sender, EventArgs e)
        {
            if (File.Exists("festas.txt") || File.Exists("funcionarios.txt") || File.Exists("fornecedores.txt"))
            {
                telaConsulta telaConsulta = new telaConsulta();
                telaConsulta.StartPosition = FormStartPosition.CenterScreen;
                telaConsulta.FormBorderStyle = FormBorderStyle.FixedSingle;
                telaConsulta.ControlBox = false;
                telaConsulta.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não existem dados para serem pesquisados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        // Botão que abre a tela de gerar relatórios 
        private void relatorio_Click(object sender, EventArgs e)
        {
            if (File.Exists("festas.txt"))
            {
                telaRelatorio telaRelatorio = new telaRelatorio();
                telaRelatorio.StartPosition = FormStartPosition.CenterScreen;
                telaRelatorio.FormBorderStyle = FormBorderStyle.FixedSingle;
                telaRelatorio.ControlBox = false;
                telaRelatorio.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não existem festas cadastradas!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        // Botão para sair do sistema 
        private void sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Ate mais!", "", MessageBoxButtons.OK);
                Application.Exit();
            }
            else
            {
                return;
            }
        }

        private void atualizarContrato_Click(object sender, EventArgs e)
        {
            if (File.Exists("contratos.txt"))
            {
                _geraContrato geraContrato = new _geraContrato();
                geraContrato.StartPosition = FormStartPosition.CenterScreen;
                geraContrato.FormBorderStyle = FormBorderStyle.FixedSingle;
                geraContrato.ControlBox = false;
                geraContrato.ShowDialog();
            }
            else
            {
                MessageBox.Show("Não existem contratos cadastrados!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
