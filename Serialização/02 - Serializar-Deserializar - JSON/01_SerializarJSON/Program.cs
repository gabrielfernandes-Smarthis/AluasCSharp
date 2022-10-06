using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using _00_Biblioteca;

namespace _01_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "Jose Costa",
                CPF = "152.455.024-45",
                Email = "jose@gmail.com"
            };

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            string stringObjSerializado = serializador.Serialize(usuario);

            StreamWriter sw = new StreamWriter(
                @"C:\Users\ggfer\OneDrive\Documentos\ArquivoSerializacao\02_serializarJSON.json"
            );
            sw.WriteLine(stringObjSerializado);
            sw.Close();
        }
    }
}
