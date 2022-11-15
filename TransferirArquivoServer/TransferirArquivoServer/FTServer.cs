using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoServer
{
    class FTServer
    {
        static IPEndPoint ipEnd_servidor;
        static Socket sock_Servidor;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static string PastaRecepcaoArquivos = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\";
        public static ListBox ListaMensagem;

        public static void InicializarServidor()
        {
            try
            {
                ipEnd_servidor = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);
                sock_Servidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
                sock_Servidor.Bind(ipEnd_servidor);
            }
            catch (Exception ex)
            {
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro ao inicializar o servidor \n" + ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
            }

            try
            {
                sock_Servidor.Listen(100);
                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Aguardando receber os arquivos...");
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));

                Socket clienteSock = sock_Servidor.Accept();//Aceitando conexao com cliente e guardando na variavel clienteSock
                clienteSock.ReceiveBufferSize = 16384;

                byte[] dadosCliente = new byte[1024 * 50000];
                int tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);
                int tamanhoNomeArquivo = BitConverter.ToInt32(dadosCliente, 0);
                string nomeArquivo = Encoding.UTF8.GetString(dadosCliente, 4, tamanhoNomeArquivo);

                //Salvando as informacoes recebidas em um arquivo existente ou criando um arquivo para salvar as informacoes
                BinaryWriter bWriter = new BinaryWriter(File.Open(PastaRecepcaoArquivos + nomeArquivo, FileMode.Append));
                bWriter.Write(dadosCliente, 4 + tamanhoNomeArquivo, tamanhoBytesRecebidos - 4 - tamanhoNomeArquivo);

                while(tamanhoBytesRecebidos > 0)
                {
                    tamanhoBytesRecebidos = clienteSock.Receive(dadosCliente, dadosCliente.Length, 0);

                    if (tamanhoBytesRecebidos == 0)
                    {
                        bWriter.Close();
                    }
                    else
                    {
                        bWriter.Write(dadosCliente, 0, tamanhoBytesRecebidos);
                    }

                    ListaMensagem.Invoke(new Action(() =>
                    {
                        ListaMensagem.Items.Add("Arquivo recebido e aquivado [" + nomeArquivo + "]");
                        ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                    }));
                    bWriter.Close();
                    clienteSock.Close();
                }

            }
            catch (SocketException ex)
            {

                ListaMensagem.Invoke(new Action(() =>
                {
                    ListaMensagem.Items.Add("Erro ao receber o arquivo:\n" + ex.Message);
                    ListaMensagem.SetSelected(ListaMensagem.Items.Count - 1, true);
                }));
            }
            finally
            {
                sock_Servidor.Close();
                sock_Servidor.Dispose();
                InicializarServidor();
            }
        }
    }
}
