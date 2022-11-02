using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadForm
{
    public partial class Form1 : Form
    {
        //Delegate com o formato do metodo que sera passado para a thread
        private delegate void AtualizarControle(Control controle, string propriedade, object valor);

        Thread t;

        public Form1()
        {
            InitializeComponent();
            t = new Thread(new ThreadStart(Tarefa)); //Criacao da thread para  executar o contador de segundos
            t.IsBackground = true;
        }

        private void btnPrincipal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Principal");
        }

        private void btnContador_Click(object sender, EventArgs e)
        {
            if (!t.IsAlive)
            {
                t.Start();
            }
        }

        //Metodo que invoca o metodo definir valor passando os valores e propriedade da label juntamente com o valor que deve ser alterado
        private void Tarefa()
        {
            while (true)
            {
                //DefinirValorPropriedade(lblResultado, "Text", DateTime.Now.Second.ToString()); 

                //Utilizando o Invoke para invocar o metodo definir valor
                lblResultado.Invoke(new Action(() => lblResultado.Text = DateTime.Now.Second.ToString()));
            }
        }

        private void DefinirValorPropriedade(Control controle, string propriedade, object valor)
        {
            //Verificar se o controle e de uma thread diferente, entao por meio da recursividade passar o metodo DefinirValorPropriedade para ser chamado no Invoke
            //caso o controle nao requer um invoke ira passar pelo foreach para preencher o controle da forma desejada passada na chamada do metodo
            if (controle.InvokeRequired)
            {
                AtualizarControle d = new AtualizarControle(DefinirValorPropriedade);
                controle.Invoke(d, new object[] { controle, propriedade, valor });
            }
            else
            {
                Type t = controle.GetType();//Pegar o tipo do controle 
                PropertyInfo[] props = t.GetProperties();//Pegar a propriedade que sera alterada

                foreach (PropertyInfo p in props)
                {
                    //Verificar qual a propriedade que sera alterada
                    if(p.Name.ToUpper() == propriedade.ToUpper())
                    {
                        p.SetValue(controle, valor, null);//Setar o valor para a propriedade
                    }
                }
            }
        }
    }
}
