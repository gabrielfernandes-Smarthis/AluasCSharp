using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooCalculoAreaRetangulo
{
    internal class Retangulo
    {
        public Retangulo()
        {
            this.Largura = 0;
            this.Altura = 0;
        }
        public Retangulo(int largura, int altura)
        {
            this.Largura = largura;
            this.Altura = altura;
        }

        private int largura;

        public int Largura
        {
            get { return largura; }
            set 
            { 
                if(value >= 0) this.largura = value;
                else largura = 0;
            }
        }

        private int altura;

        public int Altura
        {
            get { return altura; }
            set 
            { 
                if(value >= 0) this.altura = value;
                else altura = 0;
            }
        }


        public int Area
        {
            get { return Largura * Altura; }
        }
        
        public void Resultado()
        {
            Console.WriteLine("A área do retângulo é: " + this.Area);
        }

        public void ExibirDados()
        {
            Console.WriteLine("A altura do retangulo é: " + this.Altura);
            Console.WriteLine("A Largura do retangulo é: " + this.Largura);
            Console.WriteLine("A área do retângulo é: " + this.Area);
        }
    }
}
