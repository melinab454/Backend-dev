namespace soru9;

class Program
{
    static void Main(string[] args)
    {

        int[] sayilar = { 10, 20, 3, 5, 15, -2, 8 };
        int enKucuk = sayilar[0];

        foreach (int sayi in sayilar)
        {
            if (sayi < enKucuk)
            {
                enKucuk = sayi;
            }
        }

        Console.WriteLine($"Dizideki en küçük sayı: {enKucuk}");
    }
}
