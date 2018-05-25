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
    public partial class _cadastroCliente : Form
    {
        public _cadastroCliente()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            telaCadastro telaMenuCadastro = new telaCadastro();
            telaMenuCadastro.StartPosition = FormStartPosition.CenterScreen;
            telaMenuCadastro.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaMenuCadastro.ShowDialog();
            this.Close();
        }
    }
}
