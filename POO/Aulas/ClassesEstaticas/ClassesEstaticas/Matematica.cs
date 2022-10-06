using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesEstaticas
{
    static class Matematica
    {
        public static int taxa;
        
        public static int Adicinar(int x)
        {
            return x + taxa;
        }
        public static int Subtrair(int x)
        {
            return x - taxa;
        }
        
    }
}
