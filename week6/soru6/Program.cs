namespace Soru6
{
    class Program
    {
        class Calculator
        {
            public double Add(double a, double b) => a + b;
            public double Subtract(double a, double b) => a - b;
            public double Multiply(double a, double b) => a * b;
            public double Divide(double a, double b) => b != 0 ? a / b : throw new DivideByZeroException();
        }

        class ScientificCalculator : Calculator
        {
            public double Sin(double a) => Math.Sin(a);
            public double Cos(double a) => Math.Cos(a);
        }

        static void Main(string[] args)
        {
            var calculator = new Calculator();
            Console.WriteLine(calculator.Add(5, 3));
            Console.WriteLine(calculator.Subtract(5, 3));

            var scientificCalculator = new ScientificCalculator();
            Console.WriteLine(scientificCalculator.Sin(Math.PI / 2));
            Console.WriteLine(scientificCalculator.Cos(0));
        }
    }
}
