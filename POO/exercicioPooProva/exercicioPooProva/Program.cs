using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooProva
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Classe de Teste
            //Questoes
            String enuciado = "Qual a capital do Brasil?";
            List<String> alternativas = new List<string>();
            alternativas.Add("1 - São Paulo");
            alternativas.Add("2 - Rio de Janeiro");
            alternativas.Add("3 - Brasília");
            alternativas.Add("4 - Belo Horizonte");
            alternativas.Add("5 - Porto Alegre");
            Questao q1 = new Questao(enuciado, alternativas, 3);

            enuciado = "Qual a capital do Pará?";
            alternativas = new List<string>();
            alternativas.Add("1 - São Paulo");
            alternativas.Add("2 - Fortaleza");
            alternativas.Add("3 - Brasília");
            alternativas.Add("4 - Belém");
            alternativas.Add("5 - Porto Alegre");
            Questao q2 = new Questao(enuciado, alternativas, 4);

            enuciado = "Qual a capital do Rio Grande do Sul?";
            alternativas = new List<string>();
            alternativas.Add("1 - São Paulo");
            alternativas.Add("2 - Rio de Janeiro");
            alternativas.Add("3 - Brasília");
            alternativas.Add("4 - Belo Horizonte");
            alternativas.Add("5 - Porto Alegre");
            Questao q3 = new Questao(enuciado, alternativas, 5);

            enuciado = "Quanto e 2 + 2";
            alternativas = new List<string>();
            alternativas.Add("1 - 5");
            alternativas.Add("2 - 3");
            alternativas.Add("3 - 4");
            alternativas.Add("4 - 8");
            alternativas.Add("5 - 102");
            Questao q4 = new Questao(enuciado, alternativas, 3);

            enuciado = "Quando o Brasil foi colonizado ?";
            alternativas = new List<string>();
            alternativas.Add("1 - 1500");
            alternativas.Add("2 - 1980");
            alternativas.Add("3 - 1000");
            alternativas.Add("4 - 0");
            alternativas.Add("5 - 2001");
            Questao q5 = new Questao(enuciado, alternativas, 1);

            //Aluno
            Aluno a = new Aluno(2210480, "João", 16);

            //Prova
            String data = "10/10/2010";
            List<Questao> questoes = new List<Questao>();
            questoes.Add(q1);
            questoes.Add(q2);
            questoes.Add(q3);
            questoes.Add(q4);
            questoes.Add(q5);
            Prova p = new Prova(data, questoes, a);

            //Saida de dados
            p.MostrarProva();
            p.ExibirResultado();
            Console.ReadKey();
        }
    }
}
