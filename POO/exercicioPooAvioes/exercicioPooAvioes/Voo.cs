using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooAvioes
{
    public class Voo
    {
        public string dataVoo { get; set; }
        public string destino { get; set; }
        public string origem { get; set; }
        public string nrVoo { get; set; }
        public int qntLugares { get; set; }
        public Voo(string dataVoo, string destino, string origem, string nrVoo, int qntLugares)
        {
            this.dataVoo = dataVoo;
            this.destino = destino;
            this.origem = origem;
            this.nrVoo = nrVoo;
            this.qntLugares = qntLugares;
        }

        public bool EfetuarReserva()
        {
            if (this.qntLugares > 0)
            {
                this.qntLugares--;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CancelarReserva()
        {
            if (this.qntLugares < 150)
            {
                this.qntLugares++;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
