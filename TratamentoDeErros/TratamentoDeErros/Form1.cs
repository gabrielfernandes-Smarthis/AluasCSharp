using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TratamentoDeErros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] num = { 1, 2, 3, 4, 5 };

            //Bloco para tentar executar o comando
            try
            {
                string res = "";
                for (int i = 0; i < 10; i++) //For que passa o limite da array
                {
                    res += num[i] + " ";
                }
                label1.Text = res;
            }
            //Bloco para pegar o erro lançado e trata-lo
            catch (Exception ex)
            {
                label1.Text = "Erro\n" + ex.Message; //tratamento de erro 
            }
            //Bloco para executar uma operação independente do resultado do try catch
            finally
            {
                MessageBox.Show("Operacao finalizada");
            }
        }
    }
}
