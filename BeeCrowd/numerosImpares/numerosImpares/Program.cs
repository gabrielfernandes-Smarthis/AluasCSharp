using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numerosImpares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = 9;
            int X = 1;
            int Y = 0;
            for (int i = 0; i < X; i++)
            {
                if (A % 2 != 0)
                {
                    Console.WriteLine(A);
                    Y++;
                    if (Y == 6)
                        break;
                }
                X++;
                A++;
            }
        }
    }
}
