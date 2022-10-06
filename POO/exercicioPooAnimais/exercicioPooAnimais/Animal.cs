using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicioPooAnimais
{
    internal class Animal
    {
		private String nome;

		public String NomeAnimal
		{
			get { return this.nome; }
			set { this.nome = value; }
		}

		private String tipo;

		public String Tipo
		{
			get { return this.tipo; }
			set 
			{
                if (value == "Cachorro" || value == "Gato" || value == "Peixe")
                {
					this.tipo = value;
				}
				else
				{
					this.tipo = "Peixe";
				}
					
			}
		}

	}
}
