using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tratamentoExecoes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float area = 0;

            try
            {
                area = AreaQuadrado.Quad(10f, 0f);
                Console.WriteLine("Area do quadrado: {0}", area);
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro:{0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Fim do programa");
            }
        }
    }
}
