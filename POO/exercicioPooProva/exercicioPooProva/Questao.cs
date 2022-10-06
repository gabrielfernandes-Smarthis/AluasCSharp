using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooProva
{
    public class Questao
    {
        public Questao(String enuciado, List<String> alternativas, int resposta)
        {
            this.Enuciado = enuciado;
            this.alternativas = alternativas;
            this.Resposta = resposta;
        }
        public String Enuciado { get; set; }
        private List<String> alternativas;
        public List<String> Alternativas
        {
            get { return alternativas; }
            set 
            {
                if (alternativas.Count == 5)
                    alternativas = value; 
                else
                    throw new Exception("A quantidade de alternativas deve ser 5");
            }
        }
        private int resposta;

        public int Resposta
        {
            get { return resposta; }
            set { resposta = value; }
        }


        public void MostrarQuestao()
        {
            Console.WriteLine(this.Enuciado);
            for (int i = 0; i < this.alternativas.Count; i++)
            {
                Console.WriteLine(this.alternativas[i]);
            }
        }
        
        public bool Resultado(int alter)
        {
            if (this.Resposta == alter) return true;
            else return false;
        }
    }
}
