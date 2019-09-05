using System;
using Calculator;
using NUnit.Framework;


namespace Calculator.Test.Unit
{
    [TestFixture]
    [Author("Troels Jensen")]
    public class CalculatorUnitTests
    {
        private Calculator _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new Calculator();
        }

        [TestCase(3, 2, 5)]
        [TestCase(-3, -2, -5)]
        [TestCase(-3, 2, -1)]
        [TestCase(3, -2, 1)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 5, 8)] //Denne skal fejle
        [TestCase(10, -7, 3)]
        [TestCase(48, -33, 15)]
        [TestCase(70, -1, 69)]
        [TestCase(419, 1, 420)]
        [TestCase(1300, 37, 1337)]
        public void Add_AddPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Add(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 1)]
        [TestCase(-3, -2, -1)]
        [TestCase(-3, 2, -5)]
        [TestCase(3, -2, 5)]
        [TestCase(22, 33, -11)]
        [TestCase(49, 7, 42)]
        [TestCase(120, -500, 620)]
        public void Subtract_SubtractPosAndNegNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Subtract(a, b), Is.EqualTo(result));
        }


        [TestCase(3, 2, 6)]
        [TestCase(-3, -2, 6)]
        [TestCase(-3, 2, -6)]
        [TestCase(3, -2, -6)]
        [TestCase(0, -2, 0)]
        [TestCase(-2, 0, 0)]
        [TestCase(0, 0, 0)]
        [TestCase(2, 2, 4)]
        [TestCase(3, 3, 9)] //fejl
        [TestCase(5, 5, 25)]
        public void Multiply_MultiplyNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Multiply(a, b), Is.EqualTo(result));
        }


        [TestCase(2, 3, 8)]
        [TestCase(2, -3, 0.125)]
        [TestCase(-2, -3, -0.125)]
        [TestCase(1, 10, 1)]
        [TestCase(1, -10, 1)]
        [TestCase(10, 0, 1)]
        [TestCase(4, 0.5, 2.0)]
		[TestCase(9, 0.5, 3.0)]
        public void Power_RaiseNumbers_ResultIsCorrect(double x, double exp, double result)
        {
            Assert.That(_uut.Power(x, exp), Is.EqualTo(result));
        }

        [TestCase(4, 2, 2)]
        [TestCase(10, 5, 2)]
        [TestCase(9, 3, 3)]
        [TestCase(3, 0, 0)]
        public void Divide_DivideNumbers_ResultIsCorrect(int a, int b, int result)
        {
            Assert.That(_uut.Divide(a, b), Is.EqualTo(result));
        }
    }
}
