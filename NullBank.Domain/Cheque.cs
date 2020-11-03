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
			ValorPorExtenso = ObterValorPorExtenso(valor);
		}

		private string ObterValorPorExtenso(decimal valor)
		{
			var moeda = "Real";

			if(valor > 1)
			{
				moeda = "Reais";
			}

			return $"{ObterDezena(valor)}{ObterUnidade(valor)} {moeda}";
		}

		private string ObterUnidade(decimal valor)
		{
			if (valor < 1) return string.Empty;
			if (valor > 9) return string.Empty;

			switch (valor)
			{
				case 1:
					return "Um";
				case 2:
					return "Dois";
				case 3:
					return "Três";
				case 4:
					return "Quatro";
				case 5:
					return "Cinco";
				case 6:
					return "Seis";
				case 7:
					return "Sete";
				case 8:
					return "Oito";
				case 9:
					return "Nove";
				default:
					return string.Empty;
			}
		}

		private string ObterDezena(decimal valor)
		{
			switch (valor / 10)
			{
				case 1:
					return "Dez";
				case 2:
					return "Vinte";
				case 3:
					return "Trinta";
				case 4:
					return "Quarenta";
				case 5:
					return "Cinquenta";
				case 6:
					return "Sessenta";
				case 7:
					return "Setenta";
				case 8:
					return "Oitenta";
				case 9:
					return "Noventa";
				default:
					return string.Empty;
			}
		}

	}
}
