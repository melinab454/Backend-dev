using System;

namespace soru9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Listem = { 34, 57, 23, 86, 75, 88, 21, 11, 67, 44 };

            Console.WriteLine("Diziyi tersten yazdırma:");
            for (int i = Listem.Length - 1; i >= 0; i--)
            {
                Console.WriteLine($"sıra[{i}] = {Listem[i]}");
            }

            Console.WriteLine("Listenin ilk hali:");
            foreach (var eleman in Listem)
            {
                Console.Write(eleman + " ");
            }
            Console.WriteLine();
        }
    }
}
