using System;

namespace NullBank.Domain
{
	public class Cheque
	{
		public decimal Valor { get; }
		public string ValorPorExtenso { get; }

		public Cheque(decimal valor)
		{
			Valor = valor;

			switch (valor)
			{
				case 1:
					ValorPorExtenso = "Um Real";
					break;
				case 2:
					ValorPorExtenso = "Dois Reais";
					break;
				case 3:
					ValorPorExtenso = "Três Reais";
					break;
				case 4:
					ValorPorExtenso = "Quatro Reais";
					break;
				case 5:
					ValorPorExtenso = "Cinco Reais";
					break;
				case 6:
					ValorPorExtenso = "Seis Reais";
					break;
				case 7:
					ValorPorExtenso = "Sete Reais";
					break;
				case 8:
					ValorPorExtenso = "Oito Reais";
					break;
				case 9:
					ValorPorExtenso = "Nove Reais";
					break;
				default:
					break;
			}

		}

	}
}
