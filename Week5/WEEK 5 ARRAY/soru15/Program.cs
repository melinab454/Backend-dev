using System;
using System.Collections.Generic;

namespace Soru15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listem = new List<int>();
            List<int> tekSayilar = new List<int>();
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                listem.Add(random.Next(1, 50));

            }
            foreach (var OluşanListem in listem)
            {
                Console.WriteLine(OluşanListem);

            }

            foreach (int sayi in listem)
            {
                if (sayi % 2 != 0)
                {
                    tekSayilar.Add(sayi);
                }
            }


            tekSayilar.Sort(); Console.WriteLine(listem);

            Console.WriteLine("Tek olan sayılar (küçükten büyüğe):");
            foreach (int sayi in tekSayilar)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
