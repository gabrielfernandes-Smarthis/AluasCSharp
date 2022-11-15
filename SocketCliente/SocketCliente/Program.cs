using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SocketCliente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);
                socket.Connect(endPoint);
                Console.WriteLine("Conectado com exito");
                Console.WriteLine("Insira uma informacao para enviar: \n");

                string info = Console.ReadLine();
                byte[] infoEnviar = Encoding.UTF8.GetBytes(info);

                socket.Send(infoEnviar, 0, infoEnviar.Length, SocketFlags.None);
            }
            catch (Exception ex)
            {

                Console.WriteLine("Nao foi possivel conectar ao servidor " + ex.Message); ;
            }
            finally
            {
                socket.Close();
            }
            Console.WriteLine("Precione uma tecla para finalizar");
            Console.ReadKey();
        }
    }
}
