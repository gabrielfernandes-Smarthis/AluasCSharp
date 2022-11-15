using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Net;

namespace SoketServer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Criar um objeto socket e definir um endereco de ip e porta para comunicacao
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080);

            socket.Bind(endPoint);
            socket.Listen(5);//Escutar ate 5 vezes antes de parar

            Console.WriteLine("Escutando...");

            Socket escutar = socket.Accept();//Aceitar a requisisao

            byte[] bytes = new byte[255];//Definir o tamanho da informacao recebida
            int tamanho = escutar.Receive(bytes, 0, bytes.Length, SocketFlags.None);

            Array.Resize(ref bytes, tamanho);

            Console.WriteLine("Cliente falou: ");
            Console.WriteLine(Encoding.Default.GetString(bytes));

            socket.Close();
            Console.WriteLine("Servidor Finalizado\n Pressione qualquer tecla para finalizar");
            Console.ReadKey();
        }
    }
}
