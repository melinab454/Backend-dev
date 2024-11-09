namespace soru8
{
    class Program
    {
        static void Main(string[] args)
        {
            double santigrat = 25;
            double fahrenheit = SantigratToFahrenheit(santigrat);
            Console.WriteLine($"{santigrat}°C = {fahrenheit}°F");
        }

        static double SantigratToFahrenheit(double santigrat)
        {
            return (santigrat * 9 / 5) + 32;
        }
    }
}
