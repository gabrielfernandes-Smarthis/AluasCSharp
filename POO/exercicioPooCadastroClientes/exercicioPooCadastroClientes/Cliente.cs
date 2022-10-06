using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooCadastroClientes
{
    internal class Cliente
    {
        public string Nome;
        public string Telefone;
        public string CPF;
        
        public void Gravar()
        {
            //fazer
        }
        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();

            return clientes;
        }
    }
}
