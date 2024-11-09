using System;
using System.Collections.Generic;

namespace soru8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listem = new List<int>();
            Random random = new Random();
            Console.Write("Bir sayı giriniz");
            int GirilenDeğer = Convert.ToInt32(Console.ReadLine());
            bool bulundu = false;

            for (int i = 0; i < 10; i++)
            {
                listem.Add(random.Next(1, 100));
            }
            foreach (var OluşanListem in listem)
            {
                Console.WriteLine(OluşanListem + "");
            }

            foreach (var kontrol in listem)
            {
                if (kontrol == GirilenDeğer)
                {
                    Console.WriteLine($"Sayı bulundu: {kontrol}");
                    bulundu = true;
                }
            }


            if (!bulundu)
            {
                Console.WriteLine("Kontrol edildiğinde eşleşen bir değer bulunamadı...");
            }
        }
    }
}
