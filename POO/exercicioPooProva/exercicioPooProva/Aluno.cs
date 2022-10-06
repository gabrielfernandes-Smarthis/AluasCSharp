using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooProva
{
    internal class Aluno
    {
        public Aluno()
        {
            this.Matricula = 0;
            this.Nome = "";
            this.Idade = 0;
        }
        public Aluno(int matricula, String nome, int idade)
        {
            this.Matricula = matricula;
            this.Nome = nome;
            this.Idade = idade;
        }
        public int Matricula{ get; set; }
        public String Nome{ get; set; }
        private int idade;
        public int Idade
        {
            get { return idade; }
            set 
            {
                if (value >= 16)
                    idade = value;
                else
                    throw new Exception("O aluno precisa ter pelo menos 16 anos");
            }
        }


    }
}
