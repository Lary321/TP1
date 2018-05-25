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
    public partial class telaCadastro : Form
    {
        public telaCadastro()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btCadastroFuncionario_Click(object sender, EventArgs e)
        {
            this.Hide();
            _cadastroFuncionario telaFuncionario = new _cadastroFuncionario();
            telaFuncionario.StartPosition = FormStartPosition.CenterScreen;
            telaFuncionario.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaFuncionario.ControlBox = false;
            telaFuncionario.ShowDialog();     
            this.Close();
  
        }

        private void Tela_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            
        }

        private void btCadastroFornecedor_Click(object sender, EventArgs e)
        {
            this.Hide();
            _cadastroFornecedor telaFornecedor = new _cadastroFornecedor();
            telaFornecedor.StartPosition = FormStartPosition.CenterScreen;
            telaFornecedor.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaFornecedor.ControlBox = false;
            telaFornecedor.ShowDialog();
            this.Close();
        }

        private void btCadastroCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            _cadastroCliente telaCliente = new _cadastroCliente();
            telaCliente.StartPosition = FormStartPosition.CenterScreen;
            telaCliente.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaCliente.ControlBox = false;
            telaCliente.ShowDialog();
            this.Close();
        }

        private void btCadastroFesta_Click(object sender, EventArgs e)
        {
            this.Hide();
            _cadastroFesta telaFesta = new _cadastroFesta();
            telaFesta.StartPosition = FormStartPosition.CenterScreen;
            telaFesta.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaFesta.ControlBox = false;
            telaFesta.ShowDialog();
            this.Close();
        }

        private void telaCadastro_Load(object sender, EventArgs e)
        {

        }
    }
}
