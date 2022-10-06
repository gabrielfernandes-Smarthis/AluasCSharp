using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooAnimais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaração de variáveis
            Animal a1 = new Animal();
            Animal a2 = new Animal();
            Animal a3 = new Animal();
            Animal a4 = new Animal();
            Animal a5 = new Animal();
            int tlCachorro = 0, tlGato = 0, tlPeixe = 0;

            String[] nomeAnimal = new String[5];
            String[] tipoAnimal = new String[5];
            //Entrada de dados
            Console.WriteLine("Controle de animais");
            for (int i = 1; i <= 5; i++)
            {
                Console.Write("Informe o nome do " + i + "º animal: ");
                nomeAnimal[i-1] = Console.ReadLine();
                Console.Write("Informe o tipo do " + i + "º animal: ");
                tipoAnimal[i - 1] = Console.ReadLine();
            }
            //Atribuição de valores
            a1.NomeAnimal = nomeAnimal[0];
            a1.Tipo = tipoAnimal[0];
            a2.NomeAnimal = nomeAnimal[1];
            a2.Tipo = tipoAnimal[1];
            a3.NomeAnimal = nomeAnimal[2];
            a3.Tipo = tipoAnimal[2];
            a4.NomeAnimal = nomeAnimal[3];
            a4.Tipo = tipoAnimal[3];
            a5.NomeAnimal = nomeAnimal[4];
            a5.Tipo = tipoAnimal[4];

            //Contagem quantidade de cada tipo de animal
            if (a1.Tipo == "Cachorro") tlCachorro++;
            if (a1.Tipo == "Gato") tlGato++;
            if (a1.Tipo == "Peixe") tlPeixe++;
            if (a2.Tipo == "Cachorro") tlCachorro++;
            if (a2.Tipo == "Gato") tlGato++;
            if (a2.Tipo == "Peixe") tlPeixe++;
            if (a3.Tipo == "Cachorro") tlCachorro++;
            if (a3.Tipo == "Gato") tlGato++;
            if (a3.Tipo == "Peixe") tlPeixe++;
            if (a4.Tipo == "Cachorro") tlCachorro++;
            if (a4.Tipo == "Gato") tlGato++;
            if (a4.Tipo == "Peixe") tlPeixe++;
            if (a5.Tipo == "Cachorro") tlCachorro++;
            if (a5.Tipo == "Gato") tlGato++;
            if (a5.Tipo == "Peixe") tlPeixe++;

            //Saída de dados
            Console.WriteLine("Total de cachorros: " + tlCachorro);
            Console.WriteLine("Total de gatos: " + tlGato);
            Console.WriteLine("Total de peixes: " + tlPeixe);
            Console.ReadKey();
        }
    }
}
