namespace soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listem = new List<int>();
            Random random = new Random();
            Dictionary<int, List<int>> tekrarEdenler = new Dictionary<int, List<int>>();

            for (int i = 0; i < 100; i++)
            {
                listem.Add(random.Next(1, 150));
            }

            Console.WriteLine("Oluşan liste:");
            for (int i = 0; i < listem.Count; i++)
            {
                Console.WriteLine($"{i + 1}. sayı: {listem[i]}");
            }
            Console.WriteLine();

            for (int i = 0; i < listem.Count; i++)
            {
                int sayi = listem[i];

                if (tekrarEdenler.ContainsKey(sayi))
                {
                    tekrarEdenler[sayi].Add(i + 1);
                }
                else
                {
                    tekrarEdenler[sayi] = new List<int> { i + 1 };
                }
            }

            Console.WriteLine("Tekrar eden eleman:");
            foreach (var sayı in tekrarEdenler)
            {
                if (sayı.Value.Count > 1)
                {
                    Console.WriteLine($"Sayı: {sayı.Key} -  {string.Join(", ", sayı.Value)}");
                }
            }
        }
    }
}
