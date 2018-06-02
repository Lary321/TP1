using System;
using System.IO;
using System.Windows.Forms;

namespace telasTrab
{
    public partial class _cadastroFesta : Form
    {
        string[] todaLinha;
        string linha = "";
        int codigo = 0;

        public struct Festa
        {
            public string codigoFesta;
            public string nomeCliente;
            public string dataFesta;
            public string diaSemanaFesta;
            public string horarioFesta;
            public string qtdConvidados;
            public string tema;
        }

        public _cadastroFesta()
        {
            InitializeComponent();
            FileStream arq = new FileStream("festas.txt", FileMode.Append);
            arq.Close();

            if (!(File.Exists("clientes.txt")))
            {
                FileStream criaCliente = new FileStream("clientes.txt", FileMode.Append);
                criaCliente.Close();
            }

            string[] todaLinhaCliente;
            string[] todaLinhaFesta;
            string linhaCliente, linhaFesta = " ";

            //inserindo clientes no combobox
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

            //declarando variaveis
            Festa festa = new Festa();
            festa.dataFesta = " ";
            festa.diaSemanaFesta = " ";
            festa.horarioFesta = " ";
            festa.nomeCliente = " ";
            festa.qtdConvidados = " ";
            festa.tema = " ";

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


        //gravando contrato festa
        private void gravarFesta_Click(object sender, EventArgs e)
        {
            Festa festa = new Festa();

            //verificando se cliente foi selecionado 
            if (cbNomeCliente.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Selecione um cliente para o contrato!", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                cbNomeCliente.Focus();
                festa.nomeCliente = " ";
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
                FileStream arquivoHrFesta = new FileStream("festas.txt", FileMode.Open);
                StreamReader lerArq = new StreamReader(arquivoHrFesta);


                while (linha != null)
                {
                    linha = lerArq.ReadLine();
                    if (linha != null)
                    {
                        todaLinha = linha.Split('*');
                    }
                }
                arquivoHrFesta.Close();


                //verificando se o horário esta disponível
                if (cbHoraFestaSabado.Enabled == true)
                {
                    
                    if ((todaLinha[2] == dTPdataFesta.Value.ToString("dd/MM/yyyy")) 
                        && (todaLinha[4] == cbHoraFestaSabado.Text))
                    {
                        MessageBox.Show("Horário Indisponível!", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        festa.horarioFesta = " ";
                    }
                    else
                    {
                        festa.dataFesta = dTPdataFesta.Value.ToString("dd/MM/yyyy");
                        festa.horarioFesta = cbHoraFestaSabado.Text;
                    }
                }

                if ((timeHoradiaSemana1.Enabled == true) && (timeHoradiaSemana1.Enabled == true))
                {
                
                    DateTime horarioFesta = DateTime.Parse(todaLinha[4]);
                    DateTime horario = DateTime.Parse(timeHoradiaSemana1.Text);
                    


                    if ((todaLinha[2] == dTPdataFesta.Value.ToString("dd/MM/yyyy"))
                        && (((horarioFesta == horario) || (horarioFesta == horario.AddHours(1)) ||
                        (horarioFesta == horario.AddHours(2)) || (horarioFesta ==
                        horario.AddHours(3)) || (horarioFesta.AddHours(1) == horario) ||
                        (horarioFesta.AddHours(2) == horario) || (horarioFesta.AddHours(3) == horario))))
                    {
                        MessageBox.Show("Horário Indisponível!", "Aviso", MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        festa.horarioFesta = " ";
                    }
                    else
                    {
                        festa.dataFesta = dTPdataFesta.Value.ToString("dd/MM/yyyy");
                        festa.horarioFesta = (timeHoradiaSemana1.Text) + "a" + (timeHoradiaSemana2.Text);
                    }
                }
            }


            //verificando se o tema foi preenchido
            if(tbTemaFesta.Text == string.Empty)
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
            if ((festa.nomeCliente == " ") && (festa.dataFesta == " ") && (festa.diaSemanaFesta == " ") &&
                (festa.horarioFesta == " ") && (festa.qtdConvidados == " ") && (festa.tema == " "))
            {
                MessageBox.Show("Não foi possível gravar a festa, por\nfalta de dados.. ", "Aviso", MessageBoxButtons.OK,
                       MessageBoxIcon.Asterisk);
                return;
            }
            else 
            {
                if ((festa.nomeCliente != " ") && (festa.dataFesta != " ") && (festa.diaSemanaFesta != " ")
                && (festa.qtdConvidados != " ") && (festa.horarioFesta != " ") && (festa.tema != " "))
                { 
                    FileStream arquivo1 = new FileStream("festas.txt", FileMode.Append);
                    StreamWriter escreve = new StreamWriter(arquivo1);
                    if (festa.diaSemanaFesta == "Sábado") {
                        if(cbHoraFestaSabado.SelectedIndex == 0) { 
                            escreve.Write(festa.codigoFesta + '*' + festa.nomeCliente + '*' + festa.dataFesta + '*' + festa.diaSemanaFesta + '*' +
                                "12:00:00" + '*'+ "16:00:00" + '*' + festa.qtdConvidados + '*' + festa.tema + '*' + "PENDENTE");
                            escreve.WriteLine(" ");
                        }
                        if (cbHoraFestaSabado.SelectedIndex == 1)
                        {
                            escreve.Write(festa.codigoFesta + '*' + festa.nomeCliente + '*' + festa.dataFesta + '*' + festa.diaSemanaFesta + '*' +
                                "18:00:00" + '*' + "22:00:00" + '*' + festa.qtdConvidados + '*' + festa.tema + '*' + "PENDENTE");
                            escreve.WriteLine(" ");
                        }
                    }
                    else
                    {
                        escreve.Write(festa.codigoFesta + '*' + festa.nomeCliente + '*' + festa.dataFesta + '*' + festa.diaSemanaFesta + '*' +
                              timeHoradiaSemana1.Text + '*' + timeHoradiaSemana2.Text + '*' + festa.qtdConvidados + '*' + festa.tema + '*' + "PENDENTE");
                        escreve.WriteLine(" ");
                    }

                    MessageBox.Show("Dados gravados com sucesso!", "Aviso", MessageBoxButtons.OK,
                           MessageBoxIcon.Asterisk);
                    escreve.Close();

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
