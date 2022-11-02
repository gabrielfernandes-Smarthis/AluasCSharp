using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colecoes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            //Array
            string[] nomesArray = new string[3];
            nomesArray[0] = "Pedro";
            nomesArray[1] = "Leandro";
            nomesArray[2] = "Eduarda";

            //Lista
            List<string> nomes = new List<string>();
            nomes.Add("Gabriel");
            nomes.Add("Marina");
            nomes.AddRange(nomesArray);

            if (nomes.Remove("Leandro"))
            {
                MessageBox.Show("Lucas Removido");
            }
            else
            {
                MessageBox.Show("Nao foi possivel remover");
            }

            if (nomes.Contains("Cleiton"))
            {
                MessageBox.Show("Contem");
            }
            else
            {
                MessageBox.Show("Nao contem");
            }

            MessageBox.Show("Numero de elementos na lista: " + nomes.Count);

            //nomes.Sort();

            MessageBox.Show("Gabriel esta no indice: " + nomes.IndexOf("Gabriel"));

            nomes.Insert(2, "Cleiton");
            nomes.RemoveAt(3);

            foreach (string n in nomes)
            {
                lista.Items.Add(n);
            }
        }

        private void btnHashSet_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            HashSet<string> veiculos = new HashSet<string>()
            {
                "Carro",
                "Moto",
                "Aviao",
                "Navio",
                "Carro"
            };

            if (veiculos.Add("Carro"))
            {
                MessageBox.Show("Carro adicionado");
            }
            else
            {
                MessageBox.Show("Carro nao adicionado");
            }

            if (veiculos.Contains("Navio"))
            {
                MessageBox.Show("Contem");
            }
            else
            {
                MessageBox.Show("Nao Contem");
            }

            veiculos.Remove("Carro");
            MessageBox.Show("Numero de elementos no HashSet: " + veiculos.Count);
            MessageBox.Show(veiculos.ElementAt(0));

            foreach (string v in veiculos)
            {
                lista.Items.Add(v);
            }
        }

        private void btnDictionary_Click(object sender, EventArgs e)
        {
            Dictionary<int, string> alunos = new Dictionary<int, string>()
            {
                { 2210550 , "Lucas" },
                { 2210551 , "Pedro" },
                { 2210552 , "Leandro" },
                { 2210553 , "Eduarda" }
            };

            alunos.Add(2210480, "Gabriel Gomes");
            
            if (alunos.ContainsKey(2210550))
            {
                MessageBox.Show("O aluno existe");
            }
            else
            {
                MessageBox.Show("O aluno nao existe");
            }
            
            if (alunos.ContainsValue("Lucas"))
            {
                MessageBox.Show("O aluno existe");
            }
            else
            {
                MessageBox.Show("O aluno nao existe");
            }
            
            foreach (KeyValuePair<int, string> a in alunos)
            {
                lista.Items.Add(a.Value);
            }
        }
    }
}
