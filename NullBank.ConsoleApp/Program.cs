using NullBank.Domain;
using System;

namespace NullBank.ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			for (long valor = 1; valor <= 1000000000; valor++)
			{
				var cheque = new Cheque(valor);
				Console.WriteLine(cheque.ValorPorExtenso);
			}
		}
	}
}
