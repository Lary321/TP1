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
                        labelPagamento.Text = contrato.valorFinal.ToString().Replace(".", ",");
                    }
                }
            }
            contrato.desconto = double.Parse(contrato.valor) - (contrato.valorFinal);
            contrato.formaPagamento = cbFormaPagamento.Text;

        }



        //grava contrato
        private void gravarCliente_Click(object sender, EventArgs e)
        {

            string[] todaLinhaContrato;
            string linhaContra = " ";

            //FileStream arqEscreve = new FileStream("contratos.txt", FileMode.Append);
            


            FileStream contratoArq = new FileStream("contratos.txt", FileMode.Open);
            StreamReader lerArqContra = new StreamReader(contratoArq);
            StreamWriter escreveContra = new StreamWriter(contratoArq);
            Contrato contrato = new Contrato();

           

            while (linhaContra != null)
            {
                linhaContra = lerArqContra.ReadLine();
                if (linhaContra != null)
                {
                    
                    todaLinhaContrato = linhaContra.Split('*');
                    

                    if (linhaContra.Contains(cbFestas.Text))
                    {
                        string texto1 = (todaLinhaContrato[0] + '*' + todaLinhaContrato[1] + '*' + "" + '*' + "" + '*' + "" + '*' +
                            "PENDENTE" + '*' + todaLinhaContrato[6]);
                        string texto2 = (todaLinhaContrato[0] + '*' + todaLinhaContrato[1] + '*' + contrato.desconto.ToString() + '*' + contrato.valorFinal.ToString()
                                + '*' + contrato.formaPagamento + '*' + "PAGO" + '*' + todaLinhaContrato[6]);
                        string texto = linhaContra.Replace(texto1, texto2);
                        /*
                        var texto = lerArqContra.ReadLine().Replace
                            (todaLinhaContrato[0] + '*' + todaLinhaContrato[1] + '*' + "" + '*' + "" + '*' + "" + '*' +
                            "PENDENTE" + '*' + todaLinhaContrato[6],

                            todaLinhaContrato[0] + '*' + todaLinhaContrato[1] + '*' + contrato.desconto.ToString() + '*' + contrato.valorFinal.ToString()
                            + '*' + contrato.formaPagamento + '*' + "PAGO" + '*' + todaLinhaContrato[6]);*/
                        escreveContra.Write(texto);
                        
                    }
                    
                    
                    /*if(todaLinhaContrato[6] == cbFestas.Text)
                    {
                        todaLinhaContrato[2] = contrato.desconto.ToString();
                        todaLinhaContrato[3] = contrato.valorFinal.ToString();
                        todaLinhaContrato[4] = contrato.formaPagamento;
                        todaLinhaContrato[6] = "PAGO";

                        escreveContra.WriteLine(todaLinhaContrato[0] + '*' + todaLinhaContrato[1] + '*' + todaLinhaContrato[2] +
                             '*' + todaLinhaContrato[3] + '*' + todaLinhaContrato[4] + '*' + todaLinhaContrato[5] + '*' + 
                             todaLinhaContrato[6]);
                    }*/
                }
            }
            escreveContra.Close();
            //lerArqContra.Close();
            



            contrato.formaPagamento = cbFormaPagamento.Text;
           
        }

        private void _geraContrato_Load_1(object sender, EventArgs e)
        {
          
        }
    }
}
