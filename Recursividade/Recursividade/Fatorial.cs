using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public class Fatorial
    {
        public int CalculoFatorial(int num)
        {
            if (num <= 0)
            {
                return 1;
            }
            return num * CalculoFatorial(num - 1);
        }
    }
}
