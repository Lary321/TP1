using System;
using System.IO;
using System.Windows.Forms;

namespace telasTrab
{
    public partial class _cadastroFesta : Form
    {

        int codigo = 1000;

        public struct Festa
        {
            public string codigoFesta;
            public string codigoCliente;
            public string dataFesta;
            public string diaSemanaFesta;
            public string horarioFesta;
            public string qtdConvidados;
            public string tema;
        }

        public _cadastroFesta()
        {
            InitializeComponent();
            FileStream arq = new FileStream("festas.txt", FileMode.OpenOrCreate);
            arq.Close();

            string[] todaLinhaCliente;
            string[] todaLinhaFesta;
            string linhaCliente, linhaFesta = " ";

            //Inserindo clientes no combobox
            FileStream arquivoCliente = new FileStream("clientes.txt", FileMode.Open);
            StreamReader lerCliente = new StreamReader(arquivoCliente);

            do
            {
                linhaCliente = lerCliente.ReadLine();
                if (linhaCliente != null)
                {
                    todaLinhaCliente = linhaCliente.Split('*');
                    cbNomeCliente.Items.Add(todaLinhaCliente[1]);
                }
            } while (linhaCliente != null);
            arquivoCliente.Close();

            //vendo ultimo código de festa 
            FileStream festaArq = new FileStream("festas.txt", FileMode.Open);
            StreamReader lerArqFesta = new StreamReader(festaArq);

            while (linhaFesta != null)
            {
                linhaFesta = lerArqFesta.ReadLine();
                if (linhaFesta != null)
                {
                    todaLinhaFesta = linhaFesta.Split('*');
                    codigo = Convert.ToInt32(todaLinhaFesta[0]);
                }
            }
            festaArq.Close();
            codigoFesta.Text = codigo.ToString();
        }

        private void _cadastroFesta_Load(object sender, EventArgs e)
        {
            codigo++;
            codigoFesta.Text = codigo.ToString();

            dTPdataFesta.Value = DateTime.Now;
            cbDiaSemana.SelectedIndex = 0;
        }

        private void comboBoxDiaSemana_SelectedIndexChanged(object sender, EventArgs e)
        {
            //alterando dia da semana
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
            festa.qtdConvidados = cbQtdConvidados.Text;

        }

        private void timeHoradiaSemana1_ValueChanged(object sender, EventArgs e)
        {
            //altera horario dos dateTime
            timeHoradiaSemana2.Value = timeHoradiaSemana1.Value.AddHours(4);
        }

        private void gravarFesta_Click(object sender, EventArgs e)
        {
            Festa festa = new Festa();

            //verificando se cliente foi selecionado 
            if (cbNomeCliente.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecione um cliente para o contrato!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cbNomeCliente.Focus();
                festa.codigoCliente = " ";
            }
            else
            {
                FileStream arquivoCliente2 = new FileStream("clientes.txt", FileMode.Open);
                StreamReader lerCliente = new StreamReader(arquivoCliente2);
                string linhaCliente = " ";
                string[] dadosCliente;

                do
                {
                    linhaCliente = lerCliente.ReadLine();
                    if (linhaCliente != null)
                    {
                        dadosCliente = linhaCliente.Split('*');
                        if (cbNomeCliente.Text == dadosCliente[1])
                        {
                            festa.codigoCliente = dadosCliente[0];
                        }
                    }
                } while (linhaCliente != null);
                lerCliente.Close();
                arquivoCliente2.Close();
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
            FileStream arquivoHrFesta = new FileStream("festas.txt", FileMode.Open);
            StreamReader lerArq = new StreamReader(arquivoHrFesta);
            string[] todaLinha;
            string linha = " ";
            string horarioFesta = " ";
            int cont = 0;

            if (cbHoraFestaSabado.Enabled == true)
            {
                if (cbHoraFestaSabado.SelectedIndex.Equals(-1))
                {
                    MessageBox.Show("Selecione um horário para sua festa", "Aviso", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    cbHoraFestaSabado.Focus();
                }
                else
                {
                    // Verificando horários aos sábados

                    horarioFesta = cbHoraFestaSabado.Text;
                    while (linha != null)
                    {
                        linha = lerArq.ReadLine();
                        if (linha != null)
                        {
                            todaLinha = linha.Split('*');
                            //VERIFICANDO SE HORÁRIO ESTA DISPONIVEL
                            if ((todaLinha[2] == dTPdataFesta.Value.Date.ToString("dd/MM/yyyy")) && (todaLinha[4].Equals(horarioFesta)))
                            {
                                MessageBox.Show("Horário Indisponível!", "Aviso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);
                                festa.horarioFesta = " ";
                                festa.dataFesta = " ";
                                cont++;
                            }
                            else
                            {
                                festa.dataFesta = dTPdataFesta.Value.Date.ToString("dd/MM/yyyy");
                                festa.horarioFesta = cbHoraFestaSabado.Text;
                                cont++;
                            }
                        }
                    }
                    if ((linha == null) && (cont == 0))
                    {
                        festa.dataFesta = dTPdataFesta.Value.Date.ToString("dd/MM/yyyy");
                        festa.horarioFesta = cbHoraFestaSabado.Text;
                    }
                }
            }
            else if ((timeHoradiaSemana1.Enabled == true))//dia de semana
            {
                while (linha != null)
                {
                    linha = lerArq.ReadLine();
                    if (linha != null)
                    {
                        todaLinha = linha.Split('*');
                        if (todaLinha[2] == dTPdataFesta.Value.Date.ToString("dd/MM/yyyy"))
                        {
                            MessageBox.Show("Data Indisponível!", "Aviso", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                            festa.horarioFesta = " ";
                            festa.dataFesta = " ";
                            cont++;
                        }
                        else
                        {
                            festa.dataFesta = dTPdataFesta.Value.Date.ToString("dd/MM/yyyy");
                            festa.horarioFesta = ((timeHoradiaSemana1.Value.TimeOfDay) + " as " + (timeHoradiaSemana2.Value.TimeOfDay));
                            cont++;
                        }
                    }
                }
            }
            if ((linha == null) && (cont == 0))
            {
                festa.dataFesta = dTPdataFesta.Value.Date.ToString("dd/MM/yyyy");
                festa.horarioFesta = ((timeHoradiaSemana1.Value.TimeOfDay) + " as " + (timeHoradiaSemana2.Value.TimeOfDay));
            }

            arquivoHrFesta.Close();

            //verificando se o tema foi preenchido
            if (tbTemaFesta.Text == string.Empty)
            {
                MessageBox.Show("Insira um tema pra festa!", "Aviso", MessageBoxButtons.OK,
                                    MessageBoxIcon.Exclamation);
                tbTemaFesta.Focus();
                festa.tema = " ";
            }
            else
            {
                festa.tema = tbTemaFesta.Text;
            }

            //verificando qtd convidados
            if (cbQtdConvidados.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecione uma quantidade de convidados para a festa!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cbQtdConvidados.Focus();
                festa.qtdConvidados = " ";
            }
            else
            {
                festa.qtdConvidados = cbQtdConvidados.Text;
            }

            // CADASTRANDO 
            festa.codigoFesta = codigoFesta.Text;
            if ((festa.codigoCliente == " ") && (festa.dataFesta == " ") && (festa.diaSemanaFesta == " ") &&
                (festa.horarioFesta == " ") && (festa.qtdConvidados == " ") && (festa.tema == " "))
            {
                MessageBox.Show("Não foi possível gravar a festa, pois\nos dados não foram informados!", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Asterisk);
            }
            else if ((festa.qtdConvidados != " ") && (festa.dataFesta != " ") && (festa.diaSemanaFesta != " ") && (festa.horarioFesta != " ") && (festa.tema != " ") && (festa.codigoCliente != " "))
            {
                FileStream arquivo1 = new FileStream("festas.txt", FileMode.Append);
                StreamWriter escreve = new StreamWriter(arquivo1);

                ////////escrevendo no arquivo
                escreve.WriteLine(festa.codigoFesta + '*' + festa.qtdConvidados + '*' + festa.dataFesta + '*' + festa.diaSemanaFesta + '*' + festa.horarioFesta + '*' + festa.tema + '*' + festa.codigoCliente);
                /////////

                MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                escreve.Close();

                //verificando se irá cadastrar outra festa
                if (MessageBox.Show("Deseja cadastrar outra FESTA?", "Aviso", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    codigo++;
                    codigoFesta.Text = codigo.ToString();

                    cbNomeCliente.SelectedIndex = -1;
                    cbDiaSemana.SelectedIndex = -1;
                    cbQtdConvidados.SelectedIndex = -1;
                    tbTemaFesta.Text = string.Empty;
                }
                else
                {
                    codigo++;
                    this.Close();
                }
            }
        }

        private void cbNomeCliente_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        //comboBox qtd de convidados
        private void cbQtdConvidados_SelectedIndexChanged(object sender, EventArgs e)
        {
            Festa festa = new Festa();
            festa.diaSemanaFesta = cbDiaSemana.Text;

            festa.qtdConvidados = cbQtdConvidados.Text;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

    }
}
