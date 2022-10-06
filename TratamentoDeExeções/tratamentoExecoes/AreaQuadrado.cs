using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamentoExecoes
{
    internal class AreaQuadrado
    {
        public static float Quad(float bas, float alt)
        {
            if (bas <= 0 || alt <= 0)
            {
                throw new Exception("Base ou altura devem ser maiores que zero");
            }
            return bas * alt;
        }
    }
}
