using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransferirArquivoCliente
{
    class FTCliente
    {
        static IPEndPoint ipEnd_cliente;
        static Socket clienteSock_clientes;
        public static string EnderecoIP = "127.0.0.1";
        public static int PortaHost = 1000;
        public static Label LabelMensagem;

        public static void EnviarArquivo(string arquivo)
        {
            try
            {
                ipEnd_cliente = new IPEndPoint(IPAddress.Parse(EnderecoIP), PortaHost);
                clienteSock_clientes =  new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);

                string pasta = "";

                pasta += arquivo.Substring(0, arquivo.LastIndexOf("\\") + 1);
                arquivo = arquivo.Substring(arquivo.LastIndexOf("\\") + 1);

                byte[] nomeArquivoByte = Encoding.UTF8.GetBytes(arquivo);
                if (nomeArquivoByte.Length > 50000 * 1024)
                {
                    LabelMensagem.Invoke(new Action(() =>
                    {
                        LabelMensagem.ForeColor = Color.Red;
                        LabelMensagem.Text = "O tamanha do arquivo e maior que 50Mb, envie um arquivo menor!";
                    }));
                    return;
                }

                string caminhaCompleto = pasta + arquivo;

                byte[] fileData = File.ReadAllBytes(caminhaCompleto);
                //Buffer com os dados do arquivo a ser enviado para o servidor
                byte[] clientData = new byte[4 + nomeArquivoByte.Length + fileData.Length];
                byte[] nomeArquivoLen = BitConverter.GetBytes(nomeArquivoByte.Length);


                nomeArquivoLen.CopyTo(clientData, 0);
                nomeArquivoByte.CopyTo(clientData, 4);
                fileData.CopyTo(clientData, 4 + nomeArquivoByte.Length);
                clienteSock_clientes.Connect(ipEnd_cliente);
                clienteSock_clientes.Send(clientData, 0, clientData.Length, 0);
                clienteSock_clientes.Close();

                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Green;
                    LabelMensagem.Text = "Arquivo [" + arquivo + "] transferido.";
                }));
            }
            catch (Exception ex)
            {

                LabelMensagem.Invoke(new Action(() =>
                {
                    LabelMensagem.ForeColor = Color.Red;
                    LabelMensagem.Text = "Falha, o servidor nao esta atendendo... " + ex.Message;
                }));
            }
            finally
            {
                clienteSock_clientes.Close();
            }
        }
        
    }
}
