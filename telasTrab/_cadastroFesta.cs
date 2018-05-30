using System;
using System.IO;
using System.Windows.Forms;

namespace telasTrab
{
    public partial class _cadastroFesta : Form
    {
        string[] todaLinha;
        string linha;
        static string statusPago = "PAGO";
        static string statusPendente = "PENDENTE";

        public _cadastroFesta()
        {
            InitializeComponent();
            FileStream arq = new FileStream("festa.txt", FileMode.Append);
            arq.Close();

            FileStream arquivo = new FileStream("clientes.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arquivo);
            do
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    todaLinha = linha.Split('*');
                    cbNomeCliente.Items.Add(todaLinha[1]);

                }
            } while (linha != null);
            ler.Close();
        }

        public struct Festa
        {
            public string nomeCliente;
            public string dataFesta;
            public string diaSemanaFesta;
            public string horarioFesta;
            public string qtdConvidados;
            public string valorPagamento;
            public double valorFinalPagamento;
        }

        private void _cadastroFesta_Load(object sender, EventArgs e)
        {
            cBformaPagamento.SelectedIndex = 0;
            labelValorTotal.Text = "0";
            labelValorEstipulado.Text = "0";
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void comboBoxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbDiaSemana.Text == "Sábado")
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

            Festa festa = new Festa();
            festa.diaSemanaFesta = cbDiaSemana.Text;
            //verificando qtd convidados e dia da semana informando o preço
            if (cbQtdConvidados.Text == "30")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                    festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "1899,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2090,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "50")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "2199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2299,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "80")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3499,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "100")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3799,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3999,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }

            if (rBpagamentoSim.Checked == true)
            {
                if (cBformaPagamento.SelectedItem.ToString() == "À vista")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.90;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 2x")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.95;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 3x")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.98;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 4x ou mais")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento);
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }

            }
            if (rBpagamentoNao.Checked == true)
            {
                festa.valorPagamento = labelValorEstipulado.Text;
                festa.valorFinalPagamento = double.Parse(festa.valorPagamento);
                labelValorTotal.Text = festa.valorPagamento;

            }
        }

        private void timeHoradiaSemana1_ValueChanged(object sender, EventArgs e)
        {
            timeHoradiaSemana2.Value = timeHoradiaSemana1.Value.AddHours(4);
        }

        private void gravarCliente_Click(object sender, EventArgs e)
        {
            Festa festa = new Festa();
            //pegando valores dos campos
            festa.nomeCliente = cbNomeCliente.Text;
            festa.dataFesta = dTPdataFesta.Value.Date.ToString("dd/MM/yyyy");
            festa.diaSemanaFesta = cbDiaSemana.Text;
            festa.qtdConvidados = cbQtdConvidados.Text;



            //verificando horário da festa referente ao dia
            if (festa.diaSemanaFesta == "Sábado")
            {
                festa.horarioFesta = cbHoraFestaSabado.Text;
            }
            else
            {
                festa.horarioFesta = (timeHoradiaSemana1.Text) + "a" + (timeHoradiaSemana2.Text);
            }


            FileStream arquivo = new FileStream("festa.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arquivo);


            escreve.Write(festa.nomeCliente + '*' + festa.dataFesta + '*' + festa.diaSemanaFesta + '*' +
                festa.horarioFesta);
            escreve.WriteLine(" ");
            escreve.Close();

        }

        private void cbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void rBpagamentoSim_CheckedChanged(object sender, EventArgs e)
        {
            cBformaPagamento.Enabled = true;
            Festa festa = new Festa();
            festa.diaSemanaFesta = cbDiaSemana.Text;

            

            //verificando qtd convidados e dia da semana informando o preço
            if (cbQtdConvidados.Text == "30")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                    festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "1899,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2090,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "50")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "2199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2299,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "80")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3499,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "100")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3799,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3999,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }

            if (rBpagamentoSim.Checked == true)
            {
                if (cBformaPagamento.SelectedItem.ToString() == "À vista")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.90;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 2x")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.95;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 3x")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.98;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 4x ou mais")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento);
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }

            }
        }

        private void rBpagamentoNao_CheckedChanged(object sender, EventArgs e)
        {
            //cBformaPagamento.SelectedIndex = ;
            cBformaPagamento.Enabled = false;
            labelValorTotal.Text = labelValorEstipulado.Text;

            Festa festa = new Festa();
            festa.diaSemanaFesta = cbDiaSemana.Text;
            //verificando qtd convidados e dia da semana informando o preço
            if (cbQtdConvidados.Text == "30")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                    festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "1899,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2090,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "50")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "2199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2299,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "80")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3499,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "100")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3799,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3999,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }



        }

        private void cBformaPagamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            Festa festa = new Festa();
            festa.valorPagamento = labelValorEstipulado.Text;
            //verificando se será feito pagamento ou não
            if (rBpagamentoSim.Checked == true)
            {
                if (cBformaPagamento.SelectedItem.ToString() == "À vista")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.90;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 2x")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.95;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 3x")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.98;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 4x ou mais")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento);
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }

            }
            if (rBpagamentoNao.Checked == true)
            {
                festa.valorPagamento = labelValorEstipulado.Text;
                festa.valorFinalPagamento = double.Parse(festa.valorPagamento);
                labelValorTotal.Text = festa.valorPagamento;

            }

           
            festa.diaSemanaFesta = cbDiaSemana.Text;
            //verificando qtd convidados e dia da semana informando o preço
            if (cbQtdConvidados.Text == "30")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                    festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "1899,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2090,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "50")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "2199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2299,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "80")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3499,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "100")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3799,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3999,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
        }

        private void cbQtdConvidados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Festa festa = new Festa();
            festa.diaSemanaFesta = cbDiaSemana.Text;
            //verificando qtd convidados e dia da semana informando o preço
            if (cbQtdConvidados.Text == "30")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                    festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "1899,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2090,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "50")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "2199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "2299,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "80")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3199,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3499,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }
            if (cbQtdConvidados.Text == "100")
            {
                if (festa.diaSemanaFesta == "Segunda-feira" || festa.diaSemanaFesta == "Terça-feira" ||
                 festa.diaSemanaFesta == "Quarta-feira" || festa.diaSemanaFesta == "Quinta-feira")
                {
                    festa.valorPagamento = "3799,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
                if (festa.diaSemanaFesta == "Sexta-feira" || festa.diaSemanaFesta == "Sábado" ||
                     festa.diaSemanaFesta == "Domingo")
                {
                    festa.valorPagamento = "3999,00";
                    labelValorEstipulado.Text = festa.valorPagamento.ToString();
                }
            }

            if (rBpagamentoSim.Checked == true)
            {
                if (cBformaPagamento.SelectedItem.ToString() == "À vista")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.90;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 2x")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.95;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 3x")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento) * 0.98;
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }
                if (cBformaPagamento.SelectedItem.ToString() == "Parcelado 4x ou mais")
                {
                    festa.valorFinalPagamento = double.Parse(festa.valorPagamento);
                    labelValorTotal.Text = festa.valorFinalPagamento.ToString();
                }

            }
            if (rBpagamentoNao.Checked == true)
            {
                festa.valorPagamento = labelValorEstipulado.Text;
                festa.valorFinalPagamento = double.Parse(festa.valorPagamento);
                labelValorTotal.Text = festa.valorPagamento;

            }
        }

        private void gBpagamentoSimNao_Enter(object sender, EventArgs e)
        {
            
        }

        private void gBalteracoesPagamento_Enter(object sender, EventArgs e)
        {

        }
    }
}
