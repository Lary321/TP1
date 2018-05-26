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
    public partial class telaRelatorio : Form
    {
        public telaRelatorio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        private void telaRelatorio_Load(object sender, EventArgs e)
        {

        }

        private void rTBrelatorioCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Data")
            {
                gBdataFesta.Enabled = true;
                gBnomeCliente.Enabled = false;
            }
            else
            {
                gBdataFesta.Enabled = false;
                gBnomeCliente.Enabled = true;
            }
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
