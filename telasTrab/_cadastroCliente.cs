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
using System.IO;

namespace telasTrab
{
    public partial class _cadastroCliente : Form
    {
        static int codigo = 1;

        public struct Cliente
        {
            public string codigo;
            public string nome;
            public string endereco;
            public string telefone;
            public string dataNasc;
        }

        public _cadastroCliente()
        {
            InitializeComponent();
            FileStream arquivo = new FileStream("clientes.txt", FileMode.OpenOrCreate);
            arquivo.Close();
            FileStream arquivo2 = new FileStream("clientes.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arquivo2);

            string linha = " ";
            string[] dadosDoCliente;

            while (linha != null)
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    dadosDoCliente = linha.Split('*');
                    codigo = Convert.ToInt32(dadosDoCliente[0]);
                }
            }
            arquivo2.Close();
        }

        private void _cadastroCliente_Load(object sender, EventArgs e)
        {
            codigo++;
            codigoCliente.Text = codigo.ToString();
        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void btGravarCliente_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente();

            cliente.codigo = codigoCliente.Text;
            cliente.nome = nomeCliente.Text;
            cliente.endereco = enderecoCliente.Text;
            cliente.telefone = telefoneCliente.Text;
            cliente.dataNasc = dtNascCliente.Text;

            FileStream arquivo3 = new FileStream("clientes.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arquivo3);

            escreve.WriteLine(cliente.codigo + '*' + cliente.nome + '*' + cliente.endereco + '*' + cliente.telefone +
                '*' + cliente.dataNasc);
            escreve.Close();
            MessageBox.Show("Cliente cadastrado com Sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
            codigo++;
        }
    }
}
