using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _00_Biblioteca;
using System.Xml.Serialization;
using System.IO;

namespace _01_SerializarXML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Rafael Porto",
                CPF = "113.426.759-00",
                Email = "rafael@gmail.com"
            };

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            StreamWriter stream = new StreamWriter(
                @"C:\Users\ggfer\OneDrive\Documentos\ArquivoSerializacao\01_serializarXML.xml"
            );

            serializador.Serialize(stream, usuario);
        }
    }
}
