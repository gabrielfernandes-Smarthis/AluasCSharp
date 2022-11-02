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

namespace Arquivo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pasta = "G:\\AulasC#\\";
            string arquivo = "teste.txt";

            //Verificar existencia do arquivo
            bool res = File.Exists(pasta + arquivo);
            label1.Text = res.ToString();

            //Deletar um arquivo
            File.Delete(pasta + arquivo);

            //Verificar se o arquivo ja existe e caso nao exista criar o arquivo
            if (!File.Exists(pasta + arquivo))
            {
                File.Create(pasta + arquivo).Close();
                label1.Text = "Arquivo foi criado";
            }
            else
            {
                label1.Text = "Arquivo ja existe";
            }

            //Verificar se o arquivo ja existe e caso exista copiar ele com o nome "Copia"
            if (File.Exists(pasta + arquivo))
            {
                File.Copy(pasta + arquivo, pasta + "Copia.txt", true);
                label1.Text = "Arquivo copiado";
            }
            else
            {
                label1.Text = "Arquivo nao existe";
            }

            //Mover o arquivo e alterar o nome
            File.Move(pasta + arquivo, pasta + "Movido.txt");

            //Escrever no arquivo
            File.WriteAllText(pasta + arquivo, "Teste de escrita de arquivo", Encoding.Default);

            //Ler o arquivo
            string textoArquivo = File.ReadAllText(pasta + arquivo, Encoding.Default);
            label1.Text = textoArquivo;
        }
    }
}
