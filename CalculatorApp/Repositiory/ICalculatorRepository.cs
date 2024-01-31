using System;
namespace CalculatorApp.Repositiory
{
	public interface ICalculatorRepository
	{
		int AddNumbers(int num1, int num2);
		int Multiply(int num1, int num2);
		public bool AreAllEvenNumbers(int[] arr);
		public int Factorial(int n);

    }
}

