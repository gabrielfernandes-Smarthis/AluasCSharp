using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooProva
{
    internal class Prova
    {
        public Prova(String data, List<Questao> questoes, Aluno aluno)
        {
            this.Data = data;
            this.Questoes = questoes;
            this.Aluno = aluno;
            this.Nota = 0;
        }

        public String Data { get; set; }
        public List<Questao> Questoes { get; set; }
        public Aluno Aluno { get; set; }
        public int Nota { get; set; }

        public void MostrarProva()
        {
            foreach (Questao q in this.Questoes)
            {
                q.MostrarQuestao();
                Console.Write("Digite a alternativa correta: ");
                int r = int.Parse(Console.ReadLine());
                if (q.Resultado(r))
                {
                    this.Nota+=2;
                }
            }
        }
        public void ExibirResultado() 
        {
            Console.WriteLine("Aluno: " + this.Aluno.Nome);
            Console.WriteLine("Nota: " + this.Nota);
        }
    }
}
