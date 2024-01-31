using CalculatorApp.Repositiory;

ICalculatorRepository calculatorRepository = new CalculatorRepository();
Console.WriteLine(calculatorRepository.AddNumbers(1,2));
