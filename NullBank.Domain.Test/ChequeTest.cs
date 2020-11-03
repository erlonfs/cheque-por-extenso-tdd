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
	}
}
