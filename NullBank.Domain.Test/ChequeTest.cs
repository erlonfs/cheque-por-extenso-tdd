using FluentAssertions;
using System;
using Xunit;

namespace NullBank.Domain.Test
{
	public class ChequeTest
	{
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
		public void Quando_for__dezena_e_unidade__devera_constar_valores_corretamente(decimal valor, string valorPorExtenso)
		{
			var cheque = new Cheque(valor);

			cheque.Valor.Should().Be(valor);
			cheque.ValorPorExtenso.Should().Be(valorPorExtenso);

		}
	}
}
