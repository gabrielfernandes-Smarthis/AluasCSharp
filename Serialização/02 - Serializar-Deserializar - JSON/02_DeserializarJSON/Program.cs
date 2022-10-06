using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using _00_Biblioteca;
using System.Web.Script.Serialization;

namespace _02_DeserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(
                @"C:\Users\ggfer\OneDrive\Documentos\ArquivoSerializacao\02_serializarJSON.json"
            );
            string linhasDoarquivo = sr.ReadToEnd();

            JavaScriptSerializer serializador = new JavaScriptSerializer();
            Usuario usuario = (Usuario)serializador.Deserialize(linhasDoarquivo, typeof(Usuario));

            Console.WriteLine(
                "Usuario: {0}, CPF: {1}, Email: {2}",
                usuario.Nome,
                usuario.CPF,
                usuario.Email
            );
        }
    }
}
