namespace CalculatorApp.Test;
using CalculatorApp;
using CalculatorApp.Repositiory;

public class Tests
{
    ICalculatorRepository calculatorReplository = new CalculatorRepository();

    

    [Test]
    public void TestToAddTwoNumbers()
    {
        //Assign--Intialization
        int expectedResult = 20;
        //Act---Call to the Development Code
        int actualResult=calculatorReplository.AddNumbers(10, 10);
        //Assert--Check the condition
        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    public void TestToMultiplyTwoNumbers()
    {
        int expectedResult = 100;
        int actualResult = calculatorReplository.Multiply(10, 10);
        Assert.AreEqual(expectedResult, actualResult);
    }
    [Test]
    [TestCase(new int[] {1,3,7,9})]
    public void TestToCheckAllEvenNumbers(int[] arr)
    {
        bool res = calculatorReplository.AreAllEvenNumbers(arr);
        Assert.That(res, Is.True);
    }
    [Test]
    [TestCase(1,1)]
    [TestCase(2,2)]
    [TestCase(3,6)]
    public void TestToCheckFactorial(int n,int expextedResult)
    {
       Assert.AreEqual(expextedResult,calculatorReplository.Factorial(n));
        
    }
}
