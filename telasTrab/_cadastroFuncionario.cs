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
    public partial class _cadastroFuncionario : Form
    {
        public static int codigo = 0;

        struct Funcionario
        {
            public string codigo;
            public string nome;
            public string telefone;
            public string funcao;
            public string salario; // deixamos como string para utilizarmos os símbolos de notação de dinheiro "R$" já que não era preciso fazer cálculos com esse valor
            public string tipo;
        }

        public _cadastroFuncionario()
        {
            InitializeComponent();

            outraFuncao.Enabled = false;

            FileStream arquivo = new FileStream("funcionarios.txt", FileMode.OpenOrCreate);
            arquivo.Close();
            FileStream arquivo2 = new FileStream("funcionarios.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arquivo2);

            string linha = " ";
            string[] dadosDoFuncionario;

            while (linha != null)
            {
                linha = ler.ReadLine();
                if (linha != null)
                {
                    dadosDoFuncionario = linha.Split('*');
                    codigo = Convert.ToInt32(dadosDoFuncionario[0]);
                }
            }
            arquivo2.Close();
            codigoFuncionario.Text = codigo.ToString();
        }

        private void _cadastroFuncionario_Load(object sender, EventArgs e)
        {
            codigo++;
            codigoFuncionario.Text = codigo.ToString();
        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void funcaoFuncionario_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (funcaoFuncionario.Text == "Outro(a)")
            {
                outraFuncao.Enabled = true;
            }
            else
            {
                outraFuncao.Enabled = false;
            }
        }


        private void btGravarFuncionario_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();

            funcionario.codigo = codigoFuncionario.Text;
            funcionario.nome = nomeFuncionario.Text;
            funcionario.telefone = telefoneFuncionario.Text;
            funcionario.tipo = tipoFuncionario.Text;

            if (funcaoFuncionario.Text == "Outro(a)")
            {
                funcionario.funcao = outraFuncao.Text;
            }
            else
            {
                funcionario.funcao = funcaoFuncionario.Text;
            }

            funcionario.salario = salarioFuncionario.Text;

            FileStream arquivo3 = new FileStream("funcionarios.txt", FileMode.Append);
            StreamWriter escreve = new StreamWriter(arquivo3);

            escreve.WriteLine(funcionario.codigo + '*' + funcionario.nome + '*' + funcionario.telefone + '*' + funcionario.tipo +
                '*' + funcionario.funcao + '*' + funcionario.salario);
            escreve.Close();

            MessageBox.Show("Funcionário(a) cadastrado(a) com sucesso!", "Aviso", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            if (MessageBox.Show("Deseja cadastrar outro(a) funcionário(a)?", "Aviso", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information) == DialogResult.Yes)
            {
                codigo++;
                codigoFuncionario.Text = codigo.ToString();
                nomeFuncionario.Text = string.Empty;
                telefoneFuncionario.Text = string.Empty;
                tipoFuncionario.Text = string.Empty;
                funcaoFuncionario.Text = string.Empty;
                salarioFuncionario.Text = string.Empty;
            }
            else
            {
                codigo++;
                this.Close();
            }
        }
    }
}
