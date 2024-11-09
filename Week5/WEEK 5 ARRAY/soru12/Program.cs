using System;
using System.Collections.Generic;

namespace soru12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listem = new List<int>();
            Random random = new Random();
            int GirilenSayi;

            for (int i = 0; i < 100; i++)
            {
                listem.Add(random.Next(1, 150));
            }

            Console.WriteLine("Oluşan liste:");
            int index = 1;
            foreach (var sayi in listem)
            {
                Console.WriteLine($"{index}. sayı: {sayi}");
                index++;
            }

            Console.Write("Bir sayı girin: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out GirilenSayi))
            {
                List<int> indeksler = new List<int>();
                index = 1;

                foreach (var sayi in listem)
                {
                    if (sayi == GirilenSayi)
                    {
                        indeksler.Add(index);
                    }
                    index++;
                }

                if (indeksler.Count > 0)
                {
                    Console.WriteLine($"Sayı: {GirilenSayi} - Pozisyonlar: {string.Join(", ", indeksler)}");
                }
                else
                {
                    Console.WriteLine($"{GirilenSayi} sayısı listede herhangi bir eşleşen sayı bulamadım.");
                }
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir sayı girin.");
            }
        }
    }
}
