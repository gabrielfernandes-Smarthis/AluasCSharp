using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introdução task
            //Task t1 = new Task(Tarefa);
            //t1.Start();

            //Task t2 = Task.Run(Tarefa);

            //Task.Factory.StartNew(Tarefa);

            //Task.Run(() => 
            //{ 
            //    for (int i = 0; i < 10; i++) 
            //    { 
            //        Console.WriteLine("Tarefa anonima"); 
            //    }
            //});

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine("Principal");
            //}
            #endregion

            #region Array de task
            //Task[] tasks =
            //{
            //    Task.Factory.StartNew(() => 
            //    {
            //        Console.WriteLine("Tarefa 1");
            //    }),

            //    Task.Factory.StartNew(() =>
            //    {
            //        Console.WriteLine("Tarefa 2");
            //    }),

            //    Task.Factory.StartNew(() =>
            //    {
            //        Console.WriteLine("Tarefa 3");
            //    })
            //};

            //Task.WaitAll(tasks);
            #endregion

            #region Retorno de task
            //Task<int> tarefa1 = Task.Factory.StartNew(() => Dobro(2));
            //Console.WriteLine(tarefa1.Result);
            #endregion

            #region Ordem execução task
                Task<int> tarefa1 = Task.Factory.StartNew(() =>
                {
                    return new Random().Next(10);
                });

                Task<int> tarefa2 = tarefa1.ContinueWith((num) =>
                {
                    return num.Result * 2;
                });

                Task<string> tarefa3 = tarefa2.ContinueWith((num) =>
                {
                    return "Resultado da tarefa: " + num.Result;
                });

                Console.WriteLine(tarefa3.Result);
            #endregion

            Console.ReadKey();
        }

        static int Dobro(int num)
        {
            return num * 2;
        }

        static private void Tarefa()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tarefa da task");
            }
        }
    }
}
