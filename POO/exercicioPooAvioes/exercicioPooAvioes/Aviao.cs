using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooAvioes
{
    public class Aviao
    {
        public string prefixo { get; set; }
        public string modelo { get; set; }
        public string fabricante { get; set; }
        public int qtdVoos { get; set; }


        private List<Voo> voos = new List<Voo>();
        
        public List<Voo> Voos
        {
            get { return voos; }
            set { voos = value; }

        }

        private List<Voo> voosCadastrado = new List<Voo>();

        public List<Voo> VoosCadastrado
        {
            get { return voosCadastrado; }
            set { voosCadastrado = value; }
        }

        public Aviao(string prefixo, string modelo, string fabricante)
        {
            this.prefixo = prefixo;
            this.modelo = modelo;
            this.fabricante = fabricante;
            this.qtdVoos = 0;
            this.voos.Add(new Voo("01/01/2018", "São Paulo", "Rio de Janeiro", "GOL123", 150));
            this.voos.Add(new Voo("01/03/2018", "São Paulo", "Fortaleza", "AZUL456", 150));
            this.voos.Add(new Voo("21/07/2018", "Fortaleza", "Paris", "GOL789", 150));
            this.voos.Add(new Voo("02/03/2018", "Rio de Janeiro", "Paris", "AZUL123", 150));
            this.voos.Add(new Voo("21/07/2018", "Miami", "Paris", "TAM123", 150));
        }

        public bool CadastrarVoo(string prefixo, int nrVoo)
        {
            if (this.prefixo == prefixo)
            {
                if (this.qtdVoos < 5)
                {
                    this.voosCadastrado.Add(this.voos[nrVoo]);
                    this.qtdVoos++;
                    return true;
                }
                else
                {
                    throw new Exception("Esse avião já tem 5 voos cadastrados");
                }
            }
            else
            {
                throw new Exception("Esse avião não existe");
            }
        }

        public Voo BuscarVoo(int nrVooCad)
        {
            if (this.voosCadastrado[nrVooCad] != null)
            {
                return this.voosCadastrado[nrVooCad];
            }
            else
            {
                throw new Exception("Esse voo não existe");
            }
        }
    }
}
