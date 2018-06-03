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
        int codigo = 0;
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
                    cbFestas.Items.Add(todaLinhaFesta[1]);
                }
            } while (linhaFesta != null);
            arquivoFestas.Close();
            lerFestas.Close();

            //inserindo codigo festa
            FileStream contratoArq = new FileStream("contratos.txt", FileMode.Open);
            StreamReader lerArqContra = new StreamReader(contratoArq);

            while (linhaFesta != null)
            {
                linhaFesta = lerArqContra.ReadLine();
                if (linhaFesta != null)
                {
                    todaLinhaFesta = linhaFesta.Split('*');
                    codigo = Convert.ToInt32(todaLinhaFesta[0]);
                }
            }
            contratoArq.Close();
            lerArqContra.Close();
            codigoContrato.Text = codigo.ToString();
        }

       

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
            Contrato contrato = new Contrato();
            if(cbPagarCancelar.Text=="Pagar contrato")
            {
                cbFormaPagamento.Enabled = true;
                contrato.status = "PAGO";
            }
            else
            {
                cbFormaPagamento.SelectedIndex = -1;
                cbFormaPagamento.Enabled = false;
                contrato.status = "CANCELADO";
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
                    if (todaLinhaAquivo[1] == cbFestas.Text)
                    {
                        contrato.diaSemana = todaLinhaAquivo[3];
                        contrato.qtdConvidados = todaLinhaAquivo[5];
                        contrato.codigoFesta = todaLinhaAquivo[0];
                    }
                }
            } while (linhaArquivo != null);
            arquivoFesta.Close();
            lerArquivoFesta.Close();
            
            if (contrato.qtdConvidados == "30")
                {
                    if (contrato.diaSemana == "Segunda-feira" || contrato.diaSemana == "Terça-feira" ||
                        contrato.diaSemana == "Quarta-feira" || contrato.diaSemana == "Quinta-feira")
                    {
                        contrato.valor = "1899,00";
                        labelPagamento.Text = contrato.valor.ToString();

                        if (cbFormaPagamento.Text == "A vista")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                        {
                            contrato.valorFinal = 1899.00;
                            labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                        }
                    }
                    if (contrato.diaSemana == "Sexta-feira" || contrato.diaSemana == "Sábado" ||
                         contrato.diaSemana == "Domingo")
                    {
                        contrato.valor = "2090,00";
                        labelPagamento.Text = contrato.valor.ToString();
                        if (cbFormaPagamento.Text == "A vista")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                        {
                            contrato.valorFinal = 2090.00;
                            labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                        }

                    }
                }
            if (contrato.qtdConvidados == "50")
                {
                    if (contrato.diaSemana == "Segunda-feira" || contrato.diaSemana == "Terça-feira" ||
                     contrato.diaSemana == "Quarta-feira" || contrato.diaSemana == "Quinta-feira")
                    {
                        contrato.valor = "2199,00";
                        if (cbFormaPagamento.Text == "A vista")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                            labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                        }
                        if (cbFormaPagamento.Text == "Duas vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                            labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                        }
                        if (cbFormaPagamento.Text == "Três vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                            labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                        }
                        if (cbFormaPagamento.Text == "Quatro ou mais vezes")
                        {
                            contrato.valorFinal = 2199.00;
                            labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                        }
                    }
                    if (contrato.diaSemana == "Sexta-feira" || contrato.diaSemana == "Sábado" ||
                         contrato.diaSemana == "Domingo")
                    {
                        contrato.valor = "2299,00";
                        if (cbFormaPagamento.Text == "A vista")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                        {
                            contrato.valorFinal = 2299.00;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                    }
                }
            if (contrato.qtdConvidados == "80")
                {
                    if (contrato.diaSemana == "Segunda-feira" || contrato.diaSemana == "Terça-feira" ||
                        contrato.diaSemana == "Quarta-feira" || contrato.diaSemana == "Quinta-feira")
                    {
                        contrato.valor = "3199,00";
                        labelPagamento.Text = contrato.valor.ToString();
                        if (cbFormaPagamento.Text == "A vista")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                        {
                            contrato.valorFinal = 3199.00;
                            labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                        }
                    }
                    if (contrato.diaSemana == "Sexta-feira" || contrato.diaSemana == "Sábado" ||
                         contrato.diaSemana == "Domingo")
                    {
                        contrato.valor = "3499,00";
                        labelPagamento.Text = contrato.valor.ToString();
                        if (cbFormaPagamento.Text == "A vista")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                        {
                            contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                            labelPagamento.Text = contrato.valorFinal.ToString();
                        }
                        if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                        {
                            contrato.valorFinal = 3499.00;
                            labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                        }
                    }
                }
            if (contrato.qtdConvidados == "100")
            {
                if (contrato.diaSemana == "Segunda-feira" || contrato.diaSemana == "Terça-feira" ||
                 contrato.diaSemana == "Quarta-feira" || contrato.diaSemana == "Quinta-feira")
                {
                    contrato.valor = "3799,00";
                    labelPagamento.Text = contrato.valor.ToString();
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString();
                    }
                    if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString();
                    }
                    if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString();
                    }
                    if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 3799.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
                if (contrato.diaSemana == "Sexta-feira" || contrato.diaSemana == "Sábado" ||
                     contrato.diaSemana == "Domingo")
                {
                    contrato.valor = "3999,00";
                    labelPagamento.Text = contrato.valor.ToString();
                    if (cbFormaPagamento.Text == "A vista")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.90;
                        labelPagamento.Text = contrato.valorFinal.ToString();
                    }
                    if (cbFormaPagamento.SelectedItem.ToString() == "Duas vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.95;
                        labelPagamento.Text = contrato.valorFinal.ToString();
                    }
                    if (cbFormaPagamento.SelectedItem.ToString() == "Três vezes")
                    {
                        contrato.valorFinal = double.Parse(contrato.valor) * 0.98;
                        labelPagamento.Text = contrato.valorFinal.ToString();
                    }
                    if (cbFormaPagamento.SelectedItem.ToString() == "Quatro ou mais vezes")
                    {
                        contrato.valorFinal = 3999.00;
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".",",");
                    }
                }
            }
        }

        private void gravarCliente_Click(object sender, EventArgs e)
        {

            FileStream arqEscreve = new FileStream("contratos.txt", FileMode.Append);
            StreamWriter escreveContra = new StreamWriter(arqEscreve);

            Contrato contrato = new Contrato();

            contrato.codigoContrato = codigoContrato.Text;
            contrato.formaPagamento = cbFormaPagamento.Text;

            

            escreveContra.WriteLine(contrato.codigoContrato + '*' + '*' + contrato.valor + '*' + contrato.valorFinal +
                '*' + contrato.formaPagamento + '*' + contrato.status + '*' + contrato.codigoFesta);
           
        }

        private void _geraContrato_Load_1(object sender, EventArgs e)
        {
            codigo++;
            codigoContrato.Text = codigo.ToString();
        }
    }
}
