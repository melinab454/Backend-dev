namespace soru13;

class Program
{
    static void Main(string[] args)
    {
        List<int> listem = new List<int>();
        List<int> ÇiftOlanlar = new List<int>();
        List<int> TekOlanlar = new List<int>();
        int ÇiftToplam = 0;
        int TekToplam = 0;
        Random random = new Random();


        for (int i = 0; i < 20; i++)
        {
            listem.Add(random.Next(1, 100));
        }

        Console.WriteLine("Oluşan liste:");
        for (int i = 0; i < listem.Count; i++)
        {
            Console.WriteLine($"{i + 1}. sayı: {listem[i]}");
        }
        foreach (var sayılar in listem)
        {
            if (sayılar % 3 == 0)
            {
                ÇiftOlanlar.Add(sayılar);
                ÇiftToplam += sayılar;

            }
            else
            {
                TekOlanlar.Add(sayılar);
                TekToplam += sayılar;
            }

        }
        Console.WriteLine("Çift olan sayıların toplamı: " + ÇiftToplam);
        Console.WriteLine("Tek olan sayıların toplamı:" + TekToplam);
    }
}
