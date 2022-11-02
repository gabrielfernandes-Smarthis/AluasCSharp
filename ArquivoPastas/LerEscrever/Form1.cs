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

namespace LerEscrever
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEscreverTxt_Click(object sender, EventArgs e)
        {
            string path = "G:\\AulasC#\\TesteEscritatxt\\file.txt";
            StreamWriter wr = new StreamWriter(path, true, Encoding.Default);

            //Criar um arquivo e escrever uma linha nele
            string linha = txtConteudo.Text;
            wr.WriteLine(linha);

            //Criar um arquivo e escrever um texto nele
            string txt = txtConteudo.Text;
            wr.Write(txt);

            //Usar flush e dispose e uma boa pratica devido a economia de recusos utilizado pelo computador
            wr.Flush(); 
            wr.Dispose();

            wr.Close();//Fechar o aqruivo aberto para a escrita
            txtConteudo.Clear();
        }

        private void btnLerTxt_Click(object sender, EventArgs e)
        {
            txtConteudo.Clear();
            string path = "G:\\AulasC#\\TesteEscritatxt\\file.txt";
            StreamReader rd = new StreamReader(path, Encoding.Default);

            //Leitura do arquivo inteiro 
            string txt = rd.ReadToEnd();

            //Leitura do arquivo linha por linha
            string line = rd.ReadLine() + " ";
            while (line != null)
            {
                txtConteudo.Text += line + "\n";
                line = rd.ReadLine();
            }

            //Leitura do arquivo letra por letra
            while (!rd.EndOfStream)
            {
                char c = (char)rd.Read();
                txtConteudo.Text += c + " ";
            }

            rd.Dispose();
            rd.Close();
        }
    }
}
