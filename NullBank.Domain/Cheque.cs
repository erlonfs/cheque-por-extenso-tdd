namespace NullBank.Domain
{
	public class Cheque
	{
		public decimal Valor { get; }
		public string ValorPorExtenso { get; }

		private int _unidade = 0;
		private int _dezena = 0;
		private int _centena = 0;
		private int _milhar = 0;
		private int _milhao = 0;
		private int _bilhao = 0;

		public Cheque(decimal valor)
		{
			var text = valor.ToString().ToCharArray();

			_unidade = int.Parse(text[text.Length - 1].ToString());
			_dezena = text.Length >= 2 ? int.Parse(text[text.Length - 2].ToString()) : 0;
			_centena = text.Length >= 3 ? int.Parse(text[text.Length - 3].ToString()) : 0;
			_milhar = text.Length >= 4 ? int.Parse(text[text.Length - 4].ToString()) : 0;
			_milhao = text.Length >= 5 ? int.Parse(text[text.Length - 5].ToString()) : 0;
			_bilhao = text.Length >= 6 ? int.Parse(text[text.Length - 6].ToString()) : 0;

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

			var dezenaPorExtenso = ObterDezena();
			var unidadePorExtenso = ObterUnidade();

			if (!string.IsNullOrWhiteSpace(dezenaPorExtenso) && !string.IsNullOrWhiteSpace(unidadePorExtenso))
			{
				dezenaPorExtenso += " e ";
			}

			return $"{dezenaPorExtenso}{unidadePorExtenso} {moeda}";
		}

		private string ObterUnidade()
		{
			if(_dezena > 0)
			{
				if (_dezena == 1) return string.Empty;
			}

			switch (_unidade)
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

		private string ObterDezena()
		{
			if (_dezena <= 0 ) return string.Empty;

			switch (_dezena)
			{
				case 1:
					return ObterUnidadeDezena();
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

		private string ObterUnidadeDezena()
		{
			switch (_unidade)
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
