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

			var dezena = ObterDezena(valor);
			var unidade = ObterUnidade(valor);

			if (!string.IsNullOrWhiteSpace(dezena) && !string.IsNullOrWhiteSpace(unidade))
			{
				dezena += " e ";
			}

			return $"{dezena}{unidade} {moeda}";
		}

		private string ObterUnidade(decimal valor)
		{
			var text = valor.ToString().ToCharArray();
			var unidade = Int32.Parse(text[text.Length - 1].ToString());

			if(text.Length > 1)
			{
				var dezena = Int32.Parse(text[text.Length - 2].ToString());
				if (dezena == 1) return string.Empty;
			}

			switch (unidade)
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
			var text = valor.ToString().ToCharArray();
			if (text.Length < 2) return string.Empty;

			var dezena = Int32.Parse(text[text.Length - 2].ToString());

			switch (dezena)
			{
				case 1:
					return ObterUnidadeDezena(valor);
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

		private string ObterUnidadeDezena(decimal valor)
		{
			var text = valor.ToString().ToCharArray();
			var unidadeDezena = Int32.Parse(text[text.Length - 1].ToString());

			switch (unidadeDezena)
			{
				case 0:
					return "Dez";
				case 1:
					return "Onze";
				case 2:
					return "Doze";
				case 3:
					return "Treze";
				case 4:
					return "Quatorze";
				case 5:
					return "Quinze";
				case 6:
					return "Dezesseis";
				case 7:
					return "Dezessete";
				case 8:
					return "Dezoito";
				case 9:
					return "Dezenove";
				default:
					return string.Empty;
			}

		}

	}
}
