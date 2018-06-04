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
    public partial class telaRelatorio : Form
    {
        public telaRelatorio()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.ControlBox = false;
        }

        private void telaRelatorio_Load(object sender, EventArgs e)
        {
            rBRelatorioCliente.Checked = true;
            gBdataFesta.Hide();
        }

        private void rTBrelatorioCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btVoltar_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Close();
        }

        private void rBRelatorioCliente_CheckedChanged(object sender, EventArgs e)
        {
            if (rBRelatorioCliente.Checked == true)
            {
                gBnomeCliente.Show();
                gBnomeCliente.Enabled = true;
                gBdataFesta.Hide();
            }
        }

        private void rBRelatorioData_CheckedChanged(object sender, EventArgs e)
        {
            if (rBRelatorioData.Checked == true)
            {
                gBnomeCliente.Hide();
                gBdataFesta.Show();
                gBdataFesta.Enabled = true;
            }
        }

        private void btGerarRelatorio_Click(object sender, EventArgs e)
        {
            FileStream arquivo = new FileStream("clientes.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arquivo);

            FileStream arquivo1 = new FileStream("festas.txt", FileMode.Open);
            StreamReader ler1 = new StreamReader(arquivo1);

            FileStream arquivo2 = new FileStream("contratos.txt", FileMode.Open);
            StreamReader ler2 = new StreamReader(arquivo2);

            string linha = " ";
            string linha1 = " ";
            string linha2 = " ";
            string[] dadosDoCliente;
            string[] dadosDaFesta;
            string[] dadosDoContrato;
            int cont = 0;
            string codigoCliente = " ";
            string pesquisa = " ";
            string codigoFesta = " ";

            if (rBRelatorioCliente.Checked == true)
            {
                pesquisa = pesquisaNome.Text.ToUpper();
                do
                {
                    linha = ler.ReadLine();
                    if (linha != null)
                    {
                        dadosDoCliente = linha.Split('*');
                        if (dadosDoCliente[1].ToUpper() == pesquisa)
                        {
                            codigoCliente = dadosDoCliente[0];
                            // Trecho de código baseado no tutorial fornecido pelo NOME DO CARA 
                            // Fonte: WWW.COLOCAR O SITE AQUI.COM.BR
                            // Instanciando um FileStream do tipo PDF (criando o arquivo ou abrindo)
                            FileStream filestream = new FileStream("Relatorio_Cliente.pdf", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                            filestream.Close();

                            // Zerando os dados do arquivo PDF
                            FileStream filestream1 = new FileStream("Relatorio_Cliente.pdf", FileMode.Truncate, FileAccess.Write, FileShare.None);
                            filestream1.Close();

                            // Instanciando um FileStream para adicionar textos no arquivo
                            FileStream filestream2 = new FileStream("Relatorio_Cliente.pdf", FileMode.Append, FileAccess.Write, FileShare.None);
                            // Instanciando um documento de texto na biblioteca iTextSharp
                            var relatorio = new iTextSharp.text.Document();
                            // Instanciando um Writer para escrever no documento
                            var pdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(relatorio, filestream2);
                            // Abrindo o documento 
                            relatorio.Open();
                            // Determinando a fonte que será utilizada no documento e o tamanho da fonte 
                            var fonte = iTextSharp.text.FontFactory.GetFont("Times New Roman", 12);
                            var fonte1 = iTextSharp.text.FontFactory.GetFont("Times New Roman", 14);
                            // Variável utilizada para adicionar imagens e formas em um documento PDF no iTextSharp
                            var contentByte = pdfWriter.DirectContent;

                            // Inserindo imagem no relatorio em pdf (PARA FUNCIONAR TEM QUE ALTERAR O DIRETÓRIO DA IMAGEM) 
                            /*var imagem = iTextSharp.text.Image.GetInstance("E:/PUC MINAS/1º Período/Disciplinas/Lab. Algoritmos e Técnicas de Programação/TP1/TP1/_imagens/imagemRelatorioCliente.png");
                            imagem.ScaleToFit(700, 200);
                            imagem.SetAbsolutePosition(32, 625);
                            imagem.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                            contentByte.AddImage(imagem);*/

                            // inserindo os dados da festa no relatorio em pdf
                            var paragrafo = new iTextSharp.text.Paragraph();
                            paragrafo = new iTextSharp.text.Paragraph("\n\n\n\n\n\n\n\n\n Dados do(a) Cliente", fonte1);
                            paragrafo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                            relatorio.Add(paragrafo);

                            paragrafo = new iTextSharp.text.Paragraph("Código: " + dadosDoCliente[0] + "\nNome: " + dadosDoCliente[1] + "\nEndereço: " + dadosDoCliente[2] + "\nTelefone:" + dadosDoCliente[3]
                                + "\nData de Nascimento: " + dadosDoCliente[4]);
                            paragrafo.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED;
                            relatorio.Add(paragrafo);

                            paragrafo = new iTextSharp.text.Paragraph("\nDados da(s) Festa(s) associada(s)", fonte1);
                            paragrafo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                            relatorio.Add(paragrafo);

                            do
                            {
                                linha1 = ler1.ReadLine();
                                if (linha1 != null)
                                {
                                    dadosDaFesta = linha1.Split('*');
                                    {
                                        codigoFesta = dadosDaFesta[0];
                                        if (dadosDaFesta[6] == codigoCliente)
                                        {

                                            paragrafo = new iTextSharp.text.Paragraph("Código: " + dadosDaFesta[0] + "\nQuantidade de Convidados: " + dadosDaFesta[1] + "\nData: " + dadosDaFesta[2] + "\nDia da Semana: " + dadosDaFesta[3] + "\nHorário: " + dadosDaFesta[4]
                                               + "\nTema: " + dadosDaFesta[5] + "\n\n", fonte);
                                            paragrafo.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED;
                                            relatorio.Add(paragrafo);
                                            cont++;
                                        }
                                    }
                                }
                            } while (linha1 != null);

                            paragrafo = new iTextSharp.text.Paragraph("\nDados do(s) Contrato(s) associado(s)", fonte1);
                            paragrafo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                            relatorio.Add(paragrafo);

                            do
                            {
                                linha2 = ler2.ReadLine();
                                if (linha2 != null)
                                {
                                    dadosDoContrato = linha2.Split('*');
                                    {
                                        if (dadosDoContrato[6] == codigoFesta)
                                        {

                                            paragrafo = new iTextSharp.text.Paragraph("Código: " + dadosDoContrato[0] + "\nValor Total: " + dadosDoContrato[1] + "\nDesconto: " + dadosDoContrato[2] + "\nValor Final: " + dadosDoContrato[3] + "\nForma de Pagamento: " + dadosDoContrato[4]
                                               + "\nStatus: " + dadosDoContrato[6] + "\n\n", fonte);
                                            paragrafo.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED;
                                            relatorio.Add(paragrafo);
                                            cont++;
                                        }
                                    }
                                }
                            } while (linha1 != null);
                            relatorio.Close();
                            System.Diagnostics.Process.Start("Relatorio_Cliente.pdf");
                            pesquisaNome.Clear();
                        }
                    }
                } while (linha != null);
                if (linha == null && cont < 1)
                {
                    MessageBox.Show("Não existem festas associadas à este(a) cliente!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    pesquisaNome.Clear();
                }
                ler.Close();
                arquivo.Close();
                ler1.Close();
                arquivo1.Close();
            }
            else if (rBRelatorioData.Checked == true)
            {
                pesquisa = pesquisaData.Value.Date.ToString("dd/MM/yyyy");
                do
                {
                    linha = ler1.ReadLine();
                    if (linha != null)
                    {
                        dadosDaFesta = linha.Split('*');
                        {
                            if (dadosDaFesta[2] == pesquisa)
                            {
                                // Trecho de código baseado no tutorial fornecido pelo NOME DO CARA 
                                // Fonte: WWW.COLOCAR O SITE AQUI.COM.BR
                                // Instanciando um FileStream do tipo PDF (criando o arquivo ou abrindo)
                                FileStream filestream3 = new FileStream("Relatorio_Data.pdf", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                                filestream3.Close();

                                FileStream filestream4 = new FileStream("Relatorio_Data.pdf", FileMode.Truncate, FileAccess.Write, FileShare.None);
                                filestream4.Close();

                                // Instanciando um FileStream para adicionar textos no arquivo
                                FileStream filestream5 = new FileStream("Relatorio_Data.pdf", FileMode.Append, FileAccess.Write, FileShare.None);
                                // Instanciando um documento de texto na biblioteca iTextSharp
                                var relatorio = new iTextSharp.text.Document();
                                // Instanciando um Writer para escrever no documento
                                var pdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(relatorio, filestream5);
                                // Abrindo o documento 
                                relatorio.Open();
                                // Determinando a fonte que será utilizada no documento e o tamanho da fonte 
                                var fonte = iTextSharp.text.FontFactory.GetFont("Times New Roman", 12);
                                var fonte1 = iTextSharp.text.FontFactory.GetFont("Times New Roman", 14);
                                // Variável utilizada para adicionar imagens e formas em um documento PDF no iTextSharp
                                var contentByte = pdfWriter.DirectContent;

                                // Inserindo imagem no relatorio em pdf (PARA FUNCIONAR TEM QUE ALTERAR O DIRETÓRIO DA IMAGEM) 
                                /*var imagem = iTextSharp.text.Image.GetInstance("E:/PUC MINAS/1º Período/Disciplinas/Lab.Algoritmos e Técnicas de Programação/TP1/TP1/_imagens/RelatorioData.png");
                                imagem.ScaleToFit(700, 200);
                                imagem.SetAbsolutePosition(32, 625);
                                imagem.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                                contentByte.AddImage(imagem);*/

                                // inserindo os dados da festa no relatorio em pdf
                                var paragrafo = new iTextSharp.text.Paragraph();
                                paragrafo = new iTextSharp.text.Paragraph("\n\n\n\n\n\n\n\n\n Dados da Festa", fonte1);
                                paragrafo.Alignment = iTextSharp.text.Element.ALIGN_CENTER;
                                relatorio.Add(paragrafo);

                                paragrafo = new iTextSharp.text.Paragraph("Código: " + dadosDaFesta[0] + "\nQuantidade de Convidados: " + dadosDaFesta[1] + "\nData: " + dadosDaFesta[2] + "\nDia da Semana:" + dadosDaFesta[3]
                                    + "\nHorário: " + dadosDaFesta[4] + "\nTema: " + dadosDaFesta[5] + "\nCódigo do Cliente: " + dadosDaFesta[6]);
                                paragrafo.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED;
                                relatorio.Add(paragrafo);
                                cont++;
                                relatorio.Close();
                                System.Diagnostics.Process.Start("Relatorio_Data.pdf");
                            }
                        }
                    }
                } while (linha != null);

                if (linha == null && cont < 1)
                {
                    MessageBox.Show("Não existem festas marcadas para esta data!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
