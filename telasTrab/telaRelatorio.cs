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
            FileStream arquivo = new FileStream("festa.txt", FileMode.Open);
            StreamReader ler = new StreamReader(arquivo);
            string linha = " ";
            string[] dadosDaFesta;
            int cont = 0;

            if (rBRelatorioCliente.Checked == true)
            {
                string pesquisa = Console.ReadLine();
                pesquisa = gBnomeCliente.Text;
                while (linha != null)
                {
                    linha = ler.ReadLine();
                    if (linha != null)
                    {
                        dadosDaFesta = linha.Split('*');
                        if (dadosDaFesta[0] == pesquisa)
                        {

                            FileStream filestream = new FileStream("Relatorio_cliente.pdf", FileMode.OpenOrCreate, FileAccess.Write, FileShare.None);
                            var relatorio = new iTextSharp.text.Document();
                            var pdfWriter = iTextSharp.text.pdf.PdfWriter.GetInstance(relatorio, filestream);
                            relatorio.Open();
                            var fonte = iTextSharp.text.FontFactory.GetFont("Times New Roman", 12);
                            var contentByte = pdfWriter.DirectContent;

                            var imagem = iTextSharp.text.Image.GetInstance("E:/PUC MINAS/1º Período/Disciplinas/Lab. Algoritmos e Técnicas de Programação/TP1/TP1/_imagens/imagemRelatorioCliente.png");
                            imagem.ScaleToFit(700, 200);
                            imagem.SetAbsolutePosition(32, 625);
                            imagem.Alignment = iTextSharp.text.Image.ALIGN_CENTER;
                            contentByte.AddImage(imagem);

                            var paragrafo = new iTextSharp.text.Paragraph();
                            paragrafo = new iTextSharp.text.Paragraph("Nome do Cliente: " + dadosDaFesta[0] + "Data da Festa: " + dadosDaFesta[1] , fonte);
                            paragrafo.Alignment = iTextSharp.text.Element.ALIGN_JUSTIFIED;
                            relatorio.Add(paragrafo);
                            relatorio.Close();
                            System.Diagnostics.Process.Start("Relatorio_cliente.pdf");

                        }
                        else if (linha == null && cont < 1)
                        {
                            Console.WriteLine("Cliente não cadastrado!");
                        }
                    }
                    cont = 0;
                }
            }
            else if (rBRelatorioData.Checked == true)
            {

            }
        }
    }
}