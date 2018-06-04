using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telasTrab
{
    public partial class _geraContrato : Form
    {
        string[] todaLinhaAquivo;
        string linhaArquivo;

        public struct Contrato
        {
            public string valor;
            public double valorFinal;
            public string status;
            public string qtdConvidados;
            public string diaSemana;
            public string codigoFesta;
            public string codigoContrato;
            public string formaPagamento;
            public double desconto;

        }

        public _geraContrato()
        {
            InitializeComponent();
            FileStream arqContra = new FileStream("contratos.txt", FileMode.Append);
            arqContra.Close();

            //inserindo Festas no combobox
            string[] todaLinhaFesta;
            string linhaFesta;

            FileStream arquivoFestas = new FileStream("festas.txt", FileMode.Open);
            StreamReader lerFestas = new StreamReader(arquivoFestas);
            do
            {
                linhaFesta = lerFestas.ReadLine();
                if (linhaFesta != null)
                {
                    todaLinhaFesta = linhaFesta.Split('*');
                    cbFestas.Items.Add(todaLinhaFesta[0]);
                }
            } while (linhaFesta != null);
            lerFestas.Close();
        }

        // Botão para voltar para a tela anterior 
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void cbFestas_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbPagarCancelar.Enabled = true;
        }

        //pagar ou cancelar 
        private void cbPagarCancelar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPagarCancelar.Text == "Pagar")
            {
                cbFormaPagamento.Enabled = true;
            }
            else
            {
                cbFormaPagamento.SelectedIndex = -1;
                cbFormaPagamento.Enabled = false;

                labelPagamento.Text = "";
            }
        }

        //forma pagamento
        private void cbFormaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Contrato contrato = new Contrato();

            FileStream arquivoFesta = new FileStream("festas.txt", FileMode.Open);
            StreamReader lerArquivoFesta = new StreamReader(arquivoFesta);

            do
            {
                linhaArquivo = lerArquivoFesta.ReadLine();
                if (linhaArquivo != null)
                {
                    todaLinhaAquivo = linhaArquivo.Split('*');
                    if (todaLinhaAquivo[0] == cbFestas.Text)
                    {
                        contrato.diaSemana = todaLinhaAquivo[3];
                        contrato.qtdConvidados = todaLinhaAquivo[5];
                        contrato.codigoFesta = todaLinhaAquivo[0];

                    }
                }
            } while (linhaArquivo != null);

            lerArquivoFesta.Close();

            if (contrato.qtdConvidados == "30")
            {
                if (contrato.diaSemana == "Segunda-feira" || contrato.diaSemana == "Terça-feira" ||
                    contrato.diaSemana == "Quarta-feira" || contrato.diaSemana == "Quinta-feira")
                {
                    contrato.valor = "1899.00";
                    labelPagamento.Text = contrato.valor.ToString();

                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 1899.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
                else if (contrato.diaSemana == "Sexta-feira" || contrato.diaSemana == "Sábado" || contrato.diaSemana == "Domingo")
                {
                    contrato.valor = "2090.00";
                    labelPagamento.Text = contrato.valor.ToString();
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 2090.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }

                }
            }
            else if (contrato.qtdConvidados == "50")
            {
                if (contrato.diaSemana == "Segunda-feira" || contrato.diaSemana == "Terça-feira" ||
                 contrato.diaSemana == "Quarta-feira" || contrato.diaSemana == "Quinta-feira")
                {
                    contrato.valor = "2199.00";
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.Text == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.Text == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.Text == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 2199.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
                else if (contrato.diaSemana == "Sexta-feira" || contrato.diaSemana == "Sábado" ||
                     contrato.diaSemana == "Domingo")
                {
                    contrato.valor = "2299.00";
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 2299.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
            }
            else if (contrato.qtdConvidados == "80")
            {
                if (contrato.diaSemana == "Segunda-feira" || contrato.diaSemana == "Terça-feira" ||
                    contrato.diaSemana == "Quarta-feira" || contrato.diaSemana == "Quinta-feira")
                {
                    contrato.valor = "3199.00";
                    labelPagamento.Text = contrato.valor.ToString();
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 3199.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
                else if (contrato.diaSemana == "Sexta-feira" || contrato.diaSemana == "Sábado" ||
                     contrato.diaSemana == "Domingo")
                {
                    contrato.valor = "3499.00";
                    labelPagamento.Text = contrato.valor.ToString();
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 3499.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
            }
            else if (contrato.qtdConvidados == "100")
            {
                if (contrato.diaSemana == "Segunda-feira" || contrato.diaSemana == "Terça-feira" ||
                 contrato.diaSemana == "Quarta-feira" || contrato.diaSemana == "Quinta-feira")
                {
                    contrato.valor = "3799.00";
                    labelPagamento.Text = contrato.valor.ToString();
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 3799.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
                else if (contrato.diaSemana == "Sexta-feira" || contrato.diaSemana == "Sábado" ||
                     contrato.diaSemana == "Domingo")
                {
                    contrato.valor = "3999.00";
                    labelPagamento.Text = contrato.valor.ToString();
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = (double.Parse(contrato.valor) * 0.98);
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                    else if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 3999.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
            }
            contrato.valorFinal = double.Parse(labelPagamento.Text);
            contrato.desconto = (double.Parse(contrato.valor) - (contrato.valorFinal));
        }


        //grava contrato
        private void gravarContrato_Click(object sender, EventArgs e)
        {
            Contrato contrato = new Contrato();

            string[] todaLinhaContrato;
            string linhaContrato = " ";

            FileStream contratoArq = new FileStream("contratos.txt", FileMode.Open);
            StreamReader lerArqContrato = new StreamReader(contratoArq);
            StringBuilder stringBuilder = new StringBuilder();

            while (linhaContrato != null)
            {
                linhaContrato = lerArqContrato.ReadLine();
                if (linhaContrato != null)
                {
                    todaLinhaContrato = linhaContrato.Split('*');
                    {
                        if (todaLinhaContrato[6] == cbFestas.Text)
                        {
                            if (cbPagarCancelar.Text == "Pagar")
                            {
                                contrato.valorFinal = double.Parse(labelPagamento.Text);
                                contrato.formaPagamento = cbFormaPagamento.Text;
                                contrato.status = "PAGO";
                                contrato.desconto = (double.Parse(todaLinhaContrato[1]) - contrato.valorFinal);

                                linhaContrato = linhaContrato.Replace(linhaContrato, todaLinhaContrato[0] + '*' + todaLinhaContrato[1] + '*' + contrato.desconto + '*' + contrato.valorFinal
                                            + '*' + contrato.formaPagamento + '*' + contrato.status + '*' + todaLinhaContrato[6]);

                                MessageBox.Show("Valor pago com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            }
                            else if (cbPagarCancelar.Text == "Cancelar contrato")
                            {
                                contrato.status = "CANCELADO";
                                linhaContrato = linhaContrato.Replace(linhaContrato, todaLinhaContrato[0] + '*' + todaLinhaContrato[1] + '*' + contrato.desconto + '*' + contrato.valorFinal.ToString()
                                            + '*' + contrato.formaPagamento + '*' + contrato.status + '*' + todaLinhaContrato[6]);
                                MessageBox.Show("Contrato cancelado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        stringBuilder.AppendLine(linhaContrato);
                    }
                }
            }
            lerArqContrato.Close();

            FileStream contratoArq2 = new FileStream("contratos.txt", FileMode.Open);
            StreamWriter escreverContrato = new StreamWriter(contratoArq2);

            escreverContrato.Write(stringBuilder);
            contrato.formaPagamento = cbFormaPagamento.Text;
            escreverContrato.Close();

            contratoArq.Close();
        }

        private void _geraContrato_Load_1(object sender, EventArgs e)
        {

        }
    }
}
