using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carimbo
{
	class Caneta :  Interacao
	{
		private string cor;
		private string texto;
		private int carga;

		public Caneta(string Ptexto)
		{
			Texto = Ptexto;
		}

		private string Cor
		{
			get { return cor; }
			set { cor = value; }
		}

		private string Texto
		{
			get { return texto; }
			set { texto = value; }
		}

		private int Carga
		{
			get { return carga; }
			set { carga = value; }
		}

		public void usar()
		{
			if (Carga >= 1)
			{
				if (!String.IsNullOrEmpty(Texto))
				{
					if (!String.IsNullOrEmpty(Cor))
					{
						Console.WriteLine("(" + Texto + ") na cor " + Cor);
						Carga--;
					}
					else
					{
						Console.WriteLine("Imposível escrever - Caneta está sem cor.");
					}
				}
				else
				{
					Console.WriteLine("Imposível escreve - Caneta está sem texto.");
				}
			}
			else
			{
				Console.WriteLine("Imposível escrever - Caneta está sem carga.");
			}
		}
		public void carregar(string Pcor, int Pcarga)
		{
			trocarCor(Pcor);
			if (Pcarga < 1 && Pcarga > 10)
			{
				Console.WriteLine("A carga deve ser entre 1 e 10");
			}
			else
			{
				Carga = Pcarga;
			}
		}
		public void trocarCor(string Pcor)
		{
			if (Pcor == Cor)
			{
				Console.WriteLine("Caneta já está com esta cor.");
			}
			else
			{
				Cor = Pcor;
			}
		}
		public void trocarTexto(string Ptexto)
		{
			if (Ptexto == Texto)
			{
				Console.WriteLine("Caneta já está com este texto.");
			}
			else
			{
				Texto = Ptexto;
			}
		}
	}
}
