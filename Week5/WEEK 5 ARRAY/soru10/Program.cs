using System;

namespace soru10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir cümle giriniz: ");
            string cümle = Console.ReadLine();
            string[] TersCümle = cümle.Split(' ');

            Console.Write($"Girilen cümle: {cümle}\n   Ters çevrilen hali: ");
            for (int i = TersCümle.Length - 1; i >= 0; i--)
            {
                Console.Write(TersCümle[i]);

                if (i > 0)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
