using System;
namespace CalculatorApp.Repositiory
{
	public class CalculatorRepository:ICalculatorRepository
	{
		
		public CalculatorRepository()
		{
		}

        public int AddNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }
        public bool AreAllEvenNumbers(int[] arr)
        {
            bool result = true;
            foreach(int num in arr)
            {
                if (num % 2 == 0)
                {
                    result = false;
                }
                else result = true;
            }
            return result;
        }
        public int Factorial(int n) {
            return Enumerable.Range(1, n).Aggregate(1, (a, b) => a * b);
                }
    }
}

