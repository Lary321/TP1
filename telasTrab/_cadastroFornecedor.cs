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
using System.IO;

namespace telasTrab
{
    public partial class _cadastroFornecedor : Form
    {
        public static int codFornecedor = 0;

        struct Fornecedor
        {
            public string codigo;
            public string nome;
            public string telefone;
            public string produtoFornecido;
        }

        public _cadastroFornecedor()
        {
            InitializeComponent();

            outroProduto.Enabled = false;

            FileStream arquivo = new FileStream("fornecedores.txt", FileMode.OpenOrCreate);
            arquivo.Close();
            FileStream arquivo2 = new FileStream("fornecedores.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arquivo2);

            string linha = " ";
            string[] dadosDoFornecedor;

            while (linha != null)
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    dadosDoFornecedor = linha.Split('*');
                    codFornecedor = Convert.ToInt32(dadosDoFornecedor[0]);
                }
            }
            arquivo2.Close();
            codigoFornecedor.Text = codFornecedor.ToString();
        }

        private void _cadastroFornecedor_Load(object sender, EventArgs e)
        {
            codFornecedor++;
            codigoFornecedor.Text = codFornecedor.ToString();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void produtoFornecido_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (produtoFornecido.Text == "Outros")
            {
                outroProduto.Enabled = true;
            }
            else
            {
                outroProduto.Enabled = false;
            }
        }

        private void btGravarFornecedor_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();

            fornecedor.codigo = codigoFornecedor.Text;
            fornecedor.nome = nomeFornecedor.Text;
            fornecedor.telefone = telefoneFornecedor.Text;

            if (produtoFornecido.Text == "Outros")
            {
                fornecedor.produtoFornecido = outroProduto.Text;
            }
            else
            {
                fornecedor.produtoFornecido = produtoFornecido.Text;
            }

            FileStream arquivo3 = new FileStream("fornecedores.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arquivo3);

            escreve.WriteLine(fornecedor.codigo + '*' + fornecedor.nome + '*' + fornecedor.telefone + '*' + fornecedor.produtoFornecido);
            escreve.Close();

            MessageBox.Show("Fornecedor(a) cadastrado(a) com sucesso!", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (MessageBox.Show("Deseja cadastrar outro(a) fornecedor(a)?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                codFornecedor++;
                codigoFornecedor.Text = codFornecedor.ToString();
                nomeFornecedor.Text = string.Empty;
                telefoneFornecedor.Text = string.Empty;
                produtoFornecido.Text = string.Empty;
            }
            else
            {
                codFornecedor++;
                this.Close();
            }
        }
    }
}
