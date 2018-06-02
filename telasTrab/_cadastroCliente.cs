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
        int codigo = 0;
        

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
            telefoneCliente.SelectionStart = 0;
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
            codigoCliente.Text = codigo.ToString();
        }

        private void _cadastroCliente_Load(object sender, EventArgs e)
        {
           codigo++;         
           codigoCliente.Text = codigo.ToString();
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
            cliente.dataNasc = dataNascCliente.Value.Date.ToString("dd/MM/yyyy");

            FileStream arquivo3 = new FileStream("clientes.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arquivo3);

            escreve.WriteLine(cliente.codigo + '*' + cliente.nome + '*' + cliente.endereco + '*' + cliente.telefone + 
                '*' + cliente.dataNasc);
            escreve.Close();
            arquivo3.Close();

            MessageBox.Show("Cliente cadastrado com sucesso!", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            
            if (MessageBox.Show("Deseja cadastrar outro cliente?", "Aviso", MessageBoxButtons.YesNo, 
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                codigo++;
                codigoCliente.Text = codigo.ToString();
                nomeCliente.Text = string.Empty;
                enderecoCliente.Text = string.Empty;
                telefoneCliente.Text = string.Empty;
            }
            else
            {
                codigo++;
                this.Close();
            }
        }

        private void telefoneCliente_MouseClick(object sender, MouseEventArgs e)
        {
            telefoneCliente.SelectionStart = 0;
        }
    }
}
