using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace telasTrab
{
    public partial class telaCadastro : Form
    {
        // Função construtora da classe telaCadastro 
        public telaCadastro()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        // Botão para acessar a tela de cadastros dos funcionários 
        private void btCadastroFuncionario_Click(object sender, EventArgs e)
        {
            
            _cadastroFuncionario telaFuncionario = new _cadastroFuncionario();
            telaFuncionario.StartPosition = FormStartPosition.CenterScreen;
            telaFuncionario.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaFuncionario.ControlBox = false;
            telaFuncionario.ShowDialog();     
            
        }

        private void Tela_Closed(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        // Botão para acessar a tela de cadastros dos fornecedores 
        private void btCadastroFornecedor_Click(object sender, EventArgs e)
        {
            
            _cadastroFornecedor telaFornecedor = new _cadastroFornecedor();
            telaFornecedor.StartPosition = FormStartPosition.CenterScreen;
            telaFornecedor.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaFornecedor.ControlBox = false;
            telaFornecedor.ShowDialog();
           
        }

        // Botão para acessar a tela de cadastro dos clientes 
        private void btCadastroCliente_Click(object sender, EventArgs e)
        {
          
            _cadastroCliente telaCliente = new _cadastroCliente();
            telaCliente.StartPosition = FormStartPosition.CenterScreen;
            telaCliente.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaCliente.ControlBox = false;
            telaCliente.ShowDialog();
            
        }

        // Botão para acessar a tela de cadastro das festas 
        private void btCadastroFesta_Click(object sender, EventArgs e)
        {
           
            _cadastroFesta telaFesta = new _cadastroFesta();
            telaFesta.StartPosition = FormStartPosition.CenterScreen;
            telaFesta.FormBorderStyle = FormBorderStyle.FixedSingle;
            telaFesta.ControlBox = false;
            telaFesta.ShowDialog();
            
        }

        // Botão para voltar para a tela anterior (menu principal) 
        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }
    }
}
