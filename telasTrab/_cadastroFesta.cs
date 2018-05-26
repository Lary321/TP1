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
    public partial class _cadastroFesta : Form
    {
        public _cadastroFesta()
        {
            InitializeComponent();
        }

        private void _cadastroFesta_Load(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void comboBoxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            
            if(comboBoxDiaSemana.Text == "Sábado")
            {
                cbHoraFestaSabado.Enabled = true;
                timeHoradiaSemana1.Enabled = false;
                timeHoradiaSemana2.Enabled = false;
            }
            else
            {
                cbHoraFestaSabado.Enabled = false;
                timeHoradiaSemana1.Enabled = true;
                timeHoradiaSemana2.Enabled = true;
            }
        }

        private void timeHoradiaSemana1_ValueChanged(object sender, EventArgs e)
        {
            timeHoradiaSemana2.Value = timeHoradiaSemana1.Value.AddHours(4);
        }

        private void gravarCliente_Click(object sender, EventArgs e)
        {
            DateTimePicker dateTimePicker1 = new DateTimePicker();
            string data = dateTimePicker1.Value.ToString();
            string nomeCliente = tbNomeCliente.Text;
            MessageBox.Show(nomeCliente,data);
        }
    }
}
