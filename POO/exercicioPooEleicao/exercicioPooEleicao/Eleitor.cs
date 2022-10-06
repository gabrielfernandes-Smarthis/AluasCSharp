using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooEleicao
{
    internal class Eleitor : Pessoa
    {
        public string Titulo { get; set; }
        public string Zona { get; set; }
        public int Secao { get; set; }
        public Eleitor(string Nome, int Idade, string Sexo, string titulo, string zona, int secao) : base(Nome, Idade, Sexo) 
        {
            this.Titulo = titulo;
            this.Zona = zona;
            this.Secao = secao;
        }

        public void TituloEleito(string titulo)
        {
            this.Titulo = titulo;
        }

        public void ZonaoEleito(string zona)
        {
            this.Zona = zona;
        }

        public void SecaoEleito(int secao)
        {
            this.Secao = secao;
        }
    }
}
