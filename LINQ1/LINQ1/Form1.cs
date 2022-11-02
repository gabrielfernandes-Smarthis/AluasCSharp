using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQ1
{
    public partial class Form1 : Form
    {
        List<string> listaNomes;
        List<int> listaNumeros;
        Dictionary<string, double> listaProdutos;
        Dictionary<string, string> listaEstados;

        public Form1()
        {
            InitializeComponent();
            #region Lista de Nomes
            listaNomes = new List<string>();
            listaNomes.Add("Gabriel");
            listaNomes.Add("Marina");
            listaNomes.Add("Pedro");
            listaNomes.Add("Carlos");
            listaNomes.Add("Cleiton");
            listaNomes.Add("Maria");
            listaNomes.Add("Eduarda");
            listaNomes.Add("Victor");
            listaNomes.Add("Isabela");
            listaNomes.Add("Eduardo");
            listaNomes.Add("Gabrielle");
            listaNomes.Add("Mariana");
            listaNomes.Add("Andre");
            #endregion

            #region Lista de Numeros
            listaNumeros = new List<int>();
            listaNumeros.Add(1);
            listaNumeros.Add(21);
            listaNumeros.Add(13);
            listaNumeros.Add(44);
            listaNumeros.Add(9);
            listaNumeros.Add(20);
            listaNumeros.Add(37);
            listaNumeros.Add(18);
            listaNumeros.Add(29);
            listaNumeros.Add(10);
            listaNumeros.Add(19);
            #endregion

            #region Lista Produtos
            listaProdutos = new Dictionary<string, double>();
            listaProdutos.Add("Teclado USB", 49.95);
            listaProdutos.Add("Teclado PS2", 45.95);
            listaProdutos.Add("Mouse", 29.5);
            listaProdutos.Add("Monitor", 780.85);
            listaProdutos.Add("Memoria 16GB", 700.00);
            listaProdutos.Add("Memoria 8GB", 375.65);
            listaProdutos.Add("Processador", 1250);
            listaProdutos.Add("Placa Mae", 623.75);
            listaProdutos.Add("Gabinete mATX", 150);
            listaProdutos.Add("Gabinete ATX", 190);
            #endregion

            #region Lista de Estados
            listaEstados = new Dictionary<string, string>();
            listaEstados.Add("Rio de Janeiro", "Brasil");
            listaEstados.Add("New York", "Estados Unidos");
            listaEstados.Add("Sao Paulo", "Brasil");
            listaEstados.Add("Porto", "Portugal");
            listaEstados.Add("Lisboa", "Portugal");
            listaEstados.Add("Bahia", "Brasil");
            listaEstados.Add("Fortaleza", "Brasil");
            listaEstados.Add("Algarve", "Portugal");
            #endregion
        }

        private void btnExecutar_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            var res = from num in listaNumeros where num % 2 == 0 select num;

            foreach (var n in res)
            {
                lista.Items.Add(n);
            }

            string txt = txtConsulta.Text;
            IEnumerable<string> res_nomes = from nome in listaNomes 
                                            where nome.StartsWith(txt) 
                                            select nome;

            lista.Items.AddRange(res_nomes.ToArray());
        }

        private void btnWhere_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string txt = txtConsulta.Text.ToLower();
            var res = from nome in listaNomes 
                      where nome.ToLower().Contains(txt) 
                      select nome;

            lista.Items.AddRange(res.ToArray());
        }

        private void btnOrderBy_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            string txt = txtConsulta.Text.ToLower();

            //var res_num = from num in listaNumeros 
            //          orderby num descending
            //          where num <= 20
            //          select num;

            //var res_nomes = from nome in listaNomes
            //          orderby nome
            //          select nome;

            //foreach (var n in res)
            //{
            //    lista.Items.Add(n);
            //}

            var res = from produto in listaProdutos
                      orderby produto.Key
                      select produto;

            foreach (KeyValuePair<string, double> p in res)
            {
                lista.Items.Add(p.Key + " -> R$: " + p.Value);
            }
        }

        private void btnGroupBy_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            txtConsulta.Text = "";

            var res = from estado in listaEstados
                      group estado by estado.Value;

            foreach (var grupo in res)
            {
                lista.Items.Add(grupo.Key + ": ");
                foreach (var estado in grupo)
                {
                    lista.Items.Add("      -" + estado.Key);
                }
            }
        }

        private void btnAgregacao_Click(object sender, EventArgs e)
        {
            int cont1 = listaNomes.Count();
            int cont2 = (from nomes in listaNomes where nomes.StartsWith("G") select nomes).Count();
            lista.Items.Add(cont1 + " nomes");
            lista.Items.Add(cont2 + " nomes com letra G");
        }

        private void btnOperadoresElemento_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();

            int primeiro = listaNumeros.FirstOrDefault();
            lista.Items.Add(primeiro);

            int ultimo = listaNumeros.LastOrDefault();
            lista.Items.Add(ultimo);

            int elementoEm = listaNumeros.ElementAtOrDefault(3);
            lista.Items.Add(elementoEm);

            var consulta = from num in listaNumeros where num > 1000 select num;
            int numero = consulta.FirstOrDefault();
            lista.Items.Add(numero);
        }

        private void btnLINQLambda_Click(object sender, EventArgs e)
        {
            lista.Items.Clear();
            var cons1 = from nome in listaNomes select nome;//LINQ sem Lambda
            var cons2 = listaNomes.Select(nome => nome).Where(nome => nome.StartsWith("G"));//Lambda
            lista.Items.AddRange(cons2.ToArray());

        }
    }
}
