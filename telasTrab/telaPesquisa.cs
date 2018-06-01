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
    public partial class telaPesquisa : Form
    {
        public telaPesquisa()
        {
            InitializeComponent();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void tipoPessoaPesquisada_SelectedIndexChanged(object sender, EventArgs e)
        {
            pesquisaTextBox.Clear();
            mostrarPesquisa.Clear();
            if (tipoPessoaPesquisada.Text == "Cliente")
            {
                frasePesquisa.Text = ("Insira abaixo o nome do cliente que deseja pesquisar");
            }
            else if (tipoPessoaPesquisada.Text == "Fornecedor")
            {
                frasePesquisa.Text = ("Insira abaixo o nome do fornecedor que deseja pesquisar");
            }
            else if (tipoPessoaPesquisada.Text == "Funcionário")
            {
                frasePesquisa.Text = ("Insira abaixo o nome do funcionário que deseja pesquisar");
            }
        }

        private void btPesquisar_Click(object sender, EventArgs e)
        {
            string pesquisa = pesquisaTextBox.Text;
            if (tipoPessoaPesquisada.Text == "Cliente")
            {
                FileStream arquivo = new FileStream("Clientes.txt", FileMode.Open);
                StreamReader ler = new StreamReader(arquivo);
                string[] dadosCliente;
                string linha = " ";
                int cont = 0;
                mostrarPesquisa.Clear();
                do
                {
                    linha = ler.ReadLine();
                    if (linha != null)
                    {
                        dadosCliente = linha.Split('*');
                        if (dadosCliente[1].ToUpper().Contains(pesquisa.ToUpper()))
                        {
                            mostrarPesquisa.AppendText("Dados do Cliente\n");
                            mostrarPesquisa.AppendText("Código: " + dadosCliente[0] + "\n");
                            mostrarPesquisa.AppendText("Nome: " + dadosCliente[1] + "\n");
                            mostrarPesquisa.AppendText("Endereço: " + dadosCliente[2] + "\n");
                            mostrarPesquisa.AppendText("Telefone: " + dadosCliente[3] + "\n");
                            mostrarPesquisa.AppendText("Data de Nascimento: " + dadosCliente[4] + "\n\n");
                            cont++;
                        }
                    }

                } while (linha != null);
                if (cont == 0)
                {
                    mostrarPesquisa.AppendText("Nenhum resultado encontrado!");
                }
                ler.Close();
                arquivo.Close();
            }
            else if (tipoPessoaPesquisada.Text == "Fornecedor")
            {
                FileStream arquivo1 = new FileStream("Fornecedores.txt", FileMode.Open);
                StreamReader ler1 = new StreamReader(arquivo1);
                string[] dadosFornecedor;
                string linha = " ";
                int cont = 0;
                mostrarPesquisa.Clear();
                do
                {
                    linha = ler1.ReadLine();
                    if (linha != null)
                    {
                        dadosFornecedor = linha.Split('*');
                        if (dadosFornecedor[1].ToUpper().Contains(pesquisa.ToUpper()))
                        {
                            mostrarPesquisa.AppendText("Dados do Fornecedor\n");
                            mostrarPesquisa.AppendText("Código: " + dadosFornecedor[0] + "\n");
                            mostrarPesquisa.AppendText("Nome: " + dadosFornecedor[1] + "\n");
                            mostrarPesquisa.AppendText("Endereço: " + dadosFornecedor[2] + "\n");
                            mostrarPesquisa.AppendText("Telefone: " + dadosFornecedor[3] + "\n");
                            mostrarPesquisa.AppendText("Data de Nascimento: " + dadosFornecedor[4] + "\n\n");
                            cont++;
                        }
                    }

                } while (linha != null);
                if (cont == 0)
                {
                    mostrarPesquisa.AppendText("Nenhum resultado encontrado!");
                }
                ler1.Close();
                arquivo1.Close();
            }
            else if (tipoPessoaPesquisada.Text == "Funcionário")
            {
                FileStream arquivo2 = new FileStream("Funcionarios.txt", FileMode.Open);
                StreamReader ler2 = new StreamReader(arquivo2);
                string[] dadosFuncionario;
                string linha = " ";
                int cont = 0;
                mostrarPesquisa.Clear();
                do
                {
                    linha = ler2.ReadLine();
                    if (linha != null)
                    {
                        dadosFuncionario = linha.Split('*');
                        if (dadosFuncionario[1].ToUpper().Contains(pesquisa.ToUpper()))
                        {
                            mostrarPesquisa.AppendText("Dados do Funcionário\n");
                            mostrarPesquisa.AppendText("Código: " + dadosFuncionario[0] + "\n");
                            mostrarPesquisa.AppendText("Nome: " + dadosFuncionario[1] + "\n");
                            mostrarPesquisa.AppendText("Endereço: " + dadosFuncionario[2] + "\n");
                            mostrarPesquisa.AppendText("Telefone: " + dadosFuncionario[3] + "\n");
                            mostrarPesquisa.AppendText("Data de Nascimento: " + dadosFuncionario[4] + "\n\n");
                            cont++;
                        }
                    }

                } while (linha != null);
                if (cont == 0)
                {
                    mostrarPesquisa.AppendText("Nenhum resultado encontrado!");
                }
                ler2.Close();
                arquivo2.Close();
            }
        }
    }
}
