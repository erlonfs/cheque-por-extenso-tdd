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
			var text = valor.ToString();

			_unidade = int.Parse(text[text.Length - 1].ToString());//0
			_dezena = text.Length >= 2 ? int.Parse(text.Substring(text.Length - 2, 2).ToString()) : 0;//00
			_centena = text.Length >= 3 ? int.Parse(text.Substring(text.Length - 3, 3).ToString()) : 0;//000
			_milhar = text.Length >= 4 && text.Length <= 6 ? int.Parse(text.Substring(0, text.Length).ToString()) : 0;//000000
			_milhao = text.Length >= 7 ? int.Parse(text.Substring(text.Length - 7, 7).ToString()) : 0;//000000000
			_bilhao = text.Length >= 13 ? int.Parse(text.Substring(text.Length - 13, 13).ToString()) : 0;//0000000000000

			Valor = valor;
			ValorPorExtenso = ObterValorPorExtenso(valor);
		}

		private string ObterValorPorExtenso(decimal valor)
		{
			var moeda = "Real";

			if (valor > 1)
			{
				moeda = "Reais";
			}
			
			var unidadePorExtenso = ObterUnidade(_unidade);
			var dezenaPorExtenso = ObterDezena(_dezena);
			var centenaPorExtenso = ObterCentena(_centena);
			var milharPorExtenso = ObterMilhar(_milhar);
			var milhaoPorExtenso = ObterMilhao(_milhao);
			var bilhaoPorExtenso = ObterBilhao();

			var valorPorExtenso = $"{bilhaoPorExtenso}{milhaoPorExtenso}{milharPorExtenso}{centenaPorExtenso}{dezenaPorExtenso}";

			if (string.IsNullOrWhiteSpace(valorPorExtenso))
			{
				valorPorExtenso = $"{unidadePorExtenso}";
			}

			return $"{valorPorExtenso} {moeda}";
		}

		private string ObterUnidade(int unidade)
		{
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

		private string ObterDezena(int dezena)
		{
			if (dezena <= 0) return string.Empty;

			var text = dezena.ToString().ToCharArray();
			var dezenaUnidade = int.Parse(text[text.Length - 2].ToString());//0
			var unidade = int.Parse(text[text.Length - 1].ToString());//0

			var unidadeDezenaPorExtenso = ObterUnidade(unidade);

			switch (dezenaUnidade)
			{
				case 1:
					return ObterUnidadeDezena(unidade);
				case 2:
					return $"Vinte{(string.IsNullOrWhiteSpace(unidadeDezenaPorExtenso) ? string.Empty : " e " + unidadeDezenaPorExtenso)}";
				case 3:
					return $"Trinta{(string.IsNullOrWhiteSpace(unidadeDezenaPorExtenso) ? string.Empty : " e " + unidadeDezenaPorExtenso)}";
				case 4:
					return $"Quarenta{(string.IsNullOrWhiteSpace(unidadeDezenaPorExtenso) ? string.Empty : " e " + unidadeDezenaPorExtenso)}";
				case 5:
					return $"Cinquenta{(string.IsNullOrWhiteSpace(unidadeDezenaPorExtenso) ? string.Empty : " e " + unidadeDezenaPorExtenso)}";
				case 6:
					return $"Sessenta{(string.IsNullOrWhiteSpace(unidadeDezenaPorExtenso) ? string.Empty : " e " + unidadeDezenaPorExtenso)}";
				case 7:
					return $"Setenta{(string.IsNullOrWhiteSpace(unidadeDezenaPorExtenso) ? string.Empty : " e " + unidadeDezenaPorExtenso)}";
				case 8:
					return $"Oitenta{(string.IsNullOrWhiteSpace(unidadeDezenaPorExtenso) ? string.Empty : " e " + unidadeDezenaPorExtenso)}";
				case 9:
					return $"Noventa{(string.IsNullOrWhiteSpace(unidadeDezenaPorExtenso) ? string.Empty : " e " + unidadeDezenaPorExtenso)}";
				default:
					return string.Empty;
			}
		}

		private string ObterUnidadeDezena(int unidadeDezena)
		{
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

		private string ObterCentena(int centena)
		{
			if (centena <= 0) return string.Empty;

			var text = centena.ToString().ToCharArray();
			var centenaUnidade = int.Parse(text[text.Length - 3].ToString());//000

			switch (centenaUnidade)
			{
				case 1:
					return "Cem";
				case 2:
					return "Duzentos";
				case 3:
					return "Trezentos";
				case 4:
					return "Quatrocentos";
				case 5:
					return "Quinhentos";
				case 6:
					return "Seiscentos";
				case 7:
					return "Setecentos";
				case 8:
					return "Oitocentos";
				case 9:
					return "Novecentos";
				default:
					return string.Empty;
			}
		}
		
		private string ObterMilhar(int milhar)
		{
			if (milhar <= 0) return string.Empty;

			var text = milhar.ToString();
			var milharUnidade = int.Parse(text.Substring(text.Length - 4, 1).ToString());//[0]000
			var milharDezena = text.Length >= 5 ? int.Parse(text.Substring(text.Length - 5, 2).ToString()) : 0;//00[0]0
			var milharCentena = text.Length >= 6 ? int.Parse(text.Substring(text.Length - 6, 3).ToString()) : 0;//000000

			var unidadePorExtenso = ObterUnidade(milharUnidade);
			var dezenaPorExtenso = ObterDezena(milharDezena);
			var centenaPorExtenso = ObterCentena(milharCentena);

			return $"{centenaPorExtenso}{dezenaPorExtenso}{unidadePorExtenso} Mil";

		}


		private string ObterMilhao(int milhao)
		{
			if (milhao <= 0) return string.Empty;

			var text = milhao.ToString();
			var milhaoUnidade = int.Parse(text.Substring(text.Length - 7, 1).ToString());//1000000
			var milhaoDezena = text.Length >= 8 ? int.Parse(text.Substring(text.Length - 8, 2).ToString()) : 0;//00[0]0
			var milhaoCentena = text.Length >= 9 ? int.Parse(text.Substring(text.Length - 9, 3).ToString()) : 0;//000000

			var unidadePorExtenso = ObterUnidade(milhaoUnidade);
			var dezenaPorExtenso = ObterDezena(milhaoDezena);
			var centenaPorExtenso = ObterCentena(milhaoCentena);

			return $"{centenaPorExtenso}{dezenaPorExtenso}{unidadePorExtenso} Milhão de";
		}

		private string ObterBilhao()
		{
			if (_bilhao <= 0) return string.Empty;

			switch (_bilhao)
			{
				case 1:
					return "Bilhão";
				default:
					return string.Empty;
			}
		}

	}
}
