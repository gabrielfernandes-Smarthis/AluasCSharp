using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_DeserializarXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = new StreamReader(
                "C:\\Users\\ggfer\\OneDrive\\Documentos\\ArquivoSerializacao\\01_serializarXML.xml"
            );

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));
            Usuario usuario = (Usuario)serializador.Deserialize(stream);

            Console.WriteLine(
                "Usuario: {0}, CPF: {1}, Email: {2}",
                usuario.Nome,
                usuario.CPF,
                usuario.Email
            );
        }
    }
}
