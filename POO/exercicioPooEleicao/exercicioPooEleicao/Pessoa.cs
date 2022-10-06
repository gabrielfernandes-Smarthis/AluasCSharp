using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooEleicao
{
    public class Pessoa
    {
        public Pessoa(string nome, int idade, string sexo)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Sexo = sexo;
        }
        public string Nome{ get; set; }
        public int Idade { get; set; }
        public string Sexo { get; set; }
    }
}
