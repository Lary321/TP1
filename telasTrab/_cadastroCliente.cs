using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace telasTrab
{
    public partial class _cadastroCliente : Form
    {
        public struct Cliente
        {
            public string nome;
            public string endereco;
            public string telefone;
            public string dataNasc;
        }

        public _cadastroCliente()
        {
            InitializeComponent();
            Cliente cliente = new Cliente();
            cliente.nome = nomeCliente.Text;
            cliente.endereco = enderecoCliente.Text;
            cliente.telefone = telefoneCliente.Text;
            cliente.dataNasc = dtNascCliente.Text;
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }


        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

    }
}
