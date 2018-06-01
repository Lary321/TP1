using System;
using System.IO;
using System.Windows.Forms;

namespace telasTrab
{
    public partial class _cadastroFesta : Form
    {
        string[] todaLinha;
        string linha;
      

        public _cadastroFesta()
        {
            InitializeComponent();
            FileStream arq = new FileStream("festa.txt", FileMode.Append);
            arq.Close();

            if (!(File.Exists("clientes.txt")))
            {
                FileStream criaCliente = new FileStream("clientes.txt", FileMode.Append);
                criaCliente.Close();
            }

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
            public string statusPagamento;
        }
        
        private void _cadastroFesta_Load(object sender, EventArgs e)
        {
            cBformaPagamento.SelectedIndex = 0;
            labelValorTotal.Text = "0";
            labelValorEstipulado.Text = "0";
            dTPdataFesta.Value = DateTime.Now;

            gBpagamentoSimNao.Enabled = false;
        }

        private void comboBoxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            //alterando dia da semana
            if (cbDiaSemana.Text == "Sábado" )
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
            //altera horario dos dateTime
            timeHoradiaSemana2.Value = timeHoradiaSemana1.Value.AddHours(4);
        }


        //gravando contrato festa
        private void gravarCliente_Click(object sender, EventArgs e)
        {
            Festa festa = new Festa();

            //verificando se cliente foi selecionado 
            if (cbNomeCliente.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecione um cliente para o contrato!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cbNomeCliente.Focus();
            }
            else
            {
                festa.nomeCliente = cbNomeCliente.Text;
            }
            
            //verificando se dia da semana foi selecionado
            if (cbDiaSemana.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecione um dia da semana para a festa!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cbDiaSemana.Focus();
            }
            else
            {
                festa.diaSemanaFesta = cbDiaSemana.Text;   
            }

            //verificando horario
            if (cbHoraFestaSabado.Enabled == true)
            {
                if (cbHoraFestaSabado.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Selecione um horário para sua festa", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    cbHoraFestaSabado.Focus();
                }
            }
            else
            {
                FileStream arquivo4 = new FileStream("festa.txt", FileMode.Open);
                StreamReader ler = new StreamReader(arquivo4);
                do
                {
                    linha = ler.ReadLine();
                    if (linha != null)
                    {
                        todaLinha = linha.Split('*');
                    }

                } while (linha != null);
                ler.Close();

                //verificando se o horário esta disponível
                if (cbHoraFestaSabado.Enabled == true)
                {
                    if ((todaLinha[1] == dTPdataFesta.Value.ToString("dd/MM/yyyy")) &&
                        (todaLinha[3] == cbHoraFestaSabado.Text))
                    {
                        MessageBox.Show("Horário Indisponível!", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                    }
                    else
                    {
                        festa.dataFesta = dTPdataFesta.Value.ToString("dd/MM/yyyy");
                        festa.horarioFesta = cbHoraFestaSabado.Text;
                    }
                }

                if ((timeHoradiaSemana1.Enabled == true) && (timeHoradiaSemana1.Enabled == true))
                {
                    festa.horarioFesta = (timeHoradiaSemana1.Text) + "a" + (timeHoradiaSemana2.Text);
                    if ((todaLinha[1] == dTPdataFesta.Value.ToString("dd/MM/yyyy")) &&
                        (todaLinha[3] == festa.horarioFesta))
                    {
                        MessageBox.Show("Horário Indisponível!", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        festa.horarioFesta = null;
                    }
                    else
                    {
                        festa.dataFesta = dTPdataFesta.Value.ToString("dd/MM/yyyy");
                        festa.horarioFesta = (timeHoradiaSemana1.Text) + "a" + (timeHoradiaSemana2.Text);
                    }
                }
            }

            //verificando qtd convidados
            if (cbQtdConvidados.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecione uma quantidade de convidados para a festa!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cbQtdConvidados.Focus();
            }
            else
            {
                festa.qtdConvidados = cbQtdConvidados.Text;
            }

            //verificando se foi pago ou nao
            if (gBpagamentoSimNao.Enabled == true)
            {
                if((rBpagamentoNao.Checked == false) && (rBpagamentoSim.Checked == false))
                {
                    MessageBox.Show("Selecione se irá pagar agora ou não!", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    gBpagamentoSimNao.Focus();
                }
                else
                { 
                    if (rBpagamentoNao.Checked == true)
                    {
                        festa.statusPagamento = "PENDENTE";
                    }
                    if(rBpagamentoSim.Checked == true)
                    {
                        festa.statusPagamento = "PAGO";
                    }
                }
            }




            // CADASTRANDO FESTA
            if ((festa.nomeCliente != " ") && (festa.dataFesta != " ") && (festa.diaSemanaFesta != " ") && 
                (festa.horarioFesta != " ") && (festa.statusPagamento != " "))
            {
                FileStream arquivo = new FileStream("festa.txt", FileMode.Append);
                StreamWriter escreve = new StreamWriter(arquivo);


                escreve.Write(festa.nomeCliente + '*' + festa.dataFesta + '*' + festa.diaSemanaFesta + '*' +
                    festa.horarioFesta + '*' + festa.statusPagamento);
                escreve.WriteLine(" ");

                MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Asterisk);               
            }
            
            

            /*
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
                festa.horarioFesta + '*' + festa.status);
            escreve.WriteLine(" ");
            escreve.Close();
            */
        }

        private void cbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {


        }
        //se radio button 'Sim' é selecionado
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

        //se radio button 'Não' é selecionado
        private void rBpagamentoNao_CheckedChanged(object sender, EventArgs e)
        {
            
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

        //comboBox forma de pagamento
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

        //comboBox qtd de convidados
        private void cbQtdConvidados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Festa festa = new Festa();
            festa.diaSemanaFesta = cbDiaSemana.Text;
            gBpagamentoSimNao.Enabled = true;

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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
