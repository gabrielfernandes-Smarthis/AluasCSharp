using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criacao de uma thread secundaria
            Thread t = new Thread(new ThreadStart(Tarefa));
            t.IsBackground = true;//Define a thread secundaria como uma thread de fundo que finaliza quando a thread principal termina
            t.Start();
            t.Join();//Aguarda a thread secundaria terminar

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Pricipal");
                Thread.Sleep(500);//Timeout de 0.5 segundo
            }

            Console.ReadKey();
        }

        static void Tarefa() 
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa executada");
                Thread.Sleep(500);//Timeout de 1 segundo
            }
        }
    }
}
