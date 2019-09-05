using System;

namespace Calculator
{
    public class Calculator
    {
        public double Add(double a, double b)
        {
            double sum = a + b;
            Accumulator = sum;
            return sum;
            
        }

        public double Subtract(double a, double b)
        {
            double sum = a - b;
            Accumulator = sum;
            return sum;
        }

        public double Multiply(double a, double b)
        {
            double sum = a * b;
            Accumulator = sum;
            return sum;
        }

        public double Power(double a, double b)
        {
            double sum =  Math.Pow(a, b);
            Accumulator = sum;
            return sum;
        }

        public double Divide(double a, double b)
        {
            if (b > 0)
            {
                double sum = a / b;
                Accumulator = sum;
                return sum;
            }

            try
            {
                Console.WriteLine(a / b);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero");

            }

            return 0;

        }
        public double Accumulator { get; private set; }
    }
}
