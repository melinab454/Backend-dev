namespace soru14;

class Program
{
    static void Main(string[] args)
    {
        List<int> listem = new List<int>();
        List<int> üçebölünenler = new List<int>();
        int toplam = 0;
        Random random = new Random();


        for (int i = 0; i < 10; i++)
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
                üçebölünenler.Add(sayılar);
                toplam += sayılar;

            }

        }
        Console.WriteLine("Üçe bölünen sayıların toplamı: " + toplam);
    }
}
