namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        List<int> listem = new List<int>();
        Random random = new Random();


        for (int i = 0; i < 100; i++)
        {
            listem.Add(random.Next(1, 500));
        }

        Console.WriteLine("Oluşan liste:");
        for (int i = 0; i < listem.Count; i++)
        {
            Console.WriteLine($"{i + 1}. sayı: {listem[i]}");
        }

        int enBuyuk = listem[0];
        int enKucuk = listem[0];

        for (int i = 1; i < listem.Count; i++)
        {
            if (listem[i] > enBuyuk)
            {
                enBuyuk = listem[i];
            }

            if (listem[i] < enKucuk)
            {
                enKucuk = listem[i];
            }

        }
        Console.WriteLine($"En büyük sayı: {enBuyuk}");
        Console.WriteLine($"En küçük sayı: {enKucuk}");
    }
}
