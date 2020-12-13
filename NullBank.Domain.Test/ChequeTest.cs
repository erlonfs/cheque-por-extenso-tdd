using FluentAssertions;
using System;
using Xunit;

namespace NullBank.Domain.Test
{
	public class ChequeTest
	{
		[Theory]
		[InlineData(0.01, "Um Centavo")]
		[InlineData(0.02, "Dois Centavos")]
		[InlineData(0.03, "Três Centavos")]
		[InlineData(0.04, "Quatro Centavos")]
		[InlineData(0.05, "Cinco Centavos")]
		[InlineData(0.06, "Seis Centavos")]
		[InlineData(0.07, "Sete Centavos")]
		[InlineData(0.08, "Oito Centavos")]
		[InlineData(0.09, "Nove Centavos")]
		public void Quando_for__unidade_de_centavos__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);
		}

		[Theory]
		[InlineData(0.10, "Dez Centavos")]
		[InlineData(0.11, "Onze Centavos")]
		[InlineData(0.12, "Doze Centavos")]
		[InlineData(0.13, "Treze Centavos")]
		[InlineData(0.14, "Quatorze Centavos")]
		[InlineData(0.15, "Quinze Centavos")]
		[InlineData(0.16, "Dezesseis Centavos")]
		[InlineData(0.17, "Dezessete Centavos")]
		[InlineData(0.18, "Dezoito Centavos")]
		[InlineData(0.19, "Dezenove Centavos")]
		[InlineData(0.20, "Vinte Centavos")]
		[InlineData(0.30, "Trinta Centavos")]
		[InlineData(0.40, "Quarenta Centavos")]
		[InlineData(0.50, "Cinquenta Centavos")]
		[InlineData(0.60, "Sessenta Centavos")]
		[InlineData(0.70, "Setenta Centavos")]
		[InlineData(0.80, "Oitenta Centavos")]
		[InlineData(0.90, "Noventa Centavos")]
		public void Quando_for__dezena_de_centavos__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(1, "Um Real")]
		[InlineData(2, "Dois Reais")]
		[InlineData(3, "Três Reais")]
		[InlineData(4, "Quatro Reais")]
		[InlineData(5, "Cinco Reais")]
		[InlineData(6, "Seis Reais")]
		[InlineData(7, "Sete Reais")]
		[InlineData(8, "Oito Reais")]
		[InlineData(9, "Nove Reais")]
		public void Quando_for__unidade__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(10, "Dez Reais")]
		[InlineData(20, "Vinte Reais")]
		[InlineData(30, "Trinta Reais")]
		[InlineData(40, "Quarenta Reais")]
		[InlineData(50, "Cinquenta Reais")]
		[InlineData(60, "Sessenta Reais")]
		[InlineData(70, "Setenta Reais")]
		[InlineData(80, "Oitenta Reais")]
		[InlineData(90, "Noventa Reais")]
		public void Quando_for__dezena__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(11, "Onze Reais")]
		[InlineData(12, "Doze Reais")]
		[InlineData(13, "Treze Reais")]
		[InlineData(14, "Quatorze Reais")]
		[InlineData(15, "Quinze Reais")]
		[InlineData(16, "Dezesseis Reais")]
		[InlineData(17, "Dezessete Reais")]
		[InlineData(18, "Dezoito Reais")]
		[InlineData(19, "Dezenove Reais")]
		[InlineData(21, "Vinte e Um Reais")]
		[InlineData(22, "Vinte e Dois Reais")]
		[InlineData(23, "Vinte e Três Reais")]
		[InlineData(24, "Vinte e Quatro Reais")]
		[InlineData(25, "Vinte e Cinco Reais")]
		[InlineData(26, "Vinte e Seis Reais")]
		[InlineData(27, "Vinte e Sete Reais")]
		[InlineData(28, "Vinte e Oito Reais")]
		[InlineData(29, "Vinte e Nove Reais")]
		[InlineData(31, "Trinta e Um Reais")]
		[InlineData(41, "Quarenta e Um Reais")]
		[InlineData(51, "Cinquenta e Um Reais")]
		[InlineData(61, "Sessenta e Um Reais")]
		[InlineData(71, "Setenta e Um Reais")]
		[InlineData(81, "Oitenta e Um Reais")]
		[InlineData(91, "Noventa e Um Reais")]
		[InlineData(92, "Noventa e Dois Reais")]
		[InlineData(93, "Noventa e Três Reais")]
		[InlineData(94, "Noventa e Quatro Reais")]
		[InlineData(95, "Noventa e Cinco Reais")]
		[InlineData(96, "Noventa e Seis Reais")]
		[InlineData(97, "Noventa e Sete Reais")]
		[InlineData(98, "Noventa e Oito Reais")]
		[InlineData(99, "Noventa e Nove Reais")]
		public void Quando_for__dezena_e_unidade__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(100, "Cem Reais")]
		[InlineData(101, "Cento e Um Reais")]
		[InlineData(110, "Cento e Dez Reais")]
		[InlineData(111, "Cento e Onze Reais")]
		[InlineData(200, "Duzentos Reais")]
		[InlineData(300, "Trezentos Reais")]
		[InlineData(400, "Quatrocentos Reais")]
		[InlineData(500, "Quinhentos Reais")]
		[InlineData(600, "Seiscentos Reais")]
		[InlineData(700, "Setecentos Reais")]
		[InlineData(800, "Oitocentos Reais")]
		[InlineData(900, "Novecentos Reais")]
		public void Quando_for__centenas__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(1000, "Um Mil Reais")]
		[InlineData(1001, "Um Mil e Um Reais")]
		[InlineData(2000, "Dois Mil Reais")]
		[InlineData(2222, "Dois Mil e Duzentos e Vinte e Dois Reais")]
		[InlineData(2011, "Dois Mil e Onze Reais")]
		[InlineData(10000, "Dez Mil Reais")]
		[InlineData(11000, "Onze Mil Reais")]
		[InlineData(99000, "Noventa e Nove Mil Reais")]
		public void Quando_for__milhar__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(1000000, "Um Milhão de Reais")]
		[InlineData(2000000, "Dois Milhões de Reais")]
		[InlineData(10000000, "Dez Milhões de Reais")]
		[InlineData(11000000, "Onze Milhões de Reais")]
		[InlineData(100000000, "Cem Milhões de Reais")]
		[InlineData(101293114, "Cento e Um Milhões e Duzentos e Noventa e Três Mil e Cento e Quatorze Reais")]
		public void Quando_for__milhao__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(1000, "Um Mil Reais")]
		[InlineData(10000, "Dez Mil Reais")]
		[InlineData(100000, "Cem Mil Reais")]
		[InlineData(1000000, "Um Milhão de Reais")]
		[InlineData(10000000, "Dez Milhões de Reais")]
		[InlineData(100000000, "Cem Milhões de Reais")]
		[InlineData(1000000000, "Um Bilhão de Reais")]
		public void Quando_for__do_mil_ao_bilhao_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(1.21, "Um Real e Vinte e Um Centavos")]
		[InlineData(150.41, "Cento e Cinquenta Reais e Quarenta e Um Centavos")]
		[InlineData(93.03, "Noventa e Três Reais e Três Centavos")]
		[InlineData(1199841.09, "Um Milhão e Cento e Noventa e Nove Mil e Oitocentos e Quarenta e Um Reais e Nove Centavos")]
		[InlineData(101000, "Cento e Um Mil Reais")]
		[InlineData(1000001, "Um Milhão e Um Reais")]
		public void Quando_for__numeros_diversos__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}

		[Theory]
		[InlineData(-1)]
		[InlineData(0)]
		[InlineData(1000000001)]
		public void Quando_criar_um_cheque__com_valores_invalidos__devera_lancar_erro(long valor)
		{
			Action action = () => new Cheque(valor);
			action.Should().Throw<ArgumentOutOfRangeException>().And.ParamName.Should().Be("valor");
		}

	}
}
