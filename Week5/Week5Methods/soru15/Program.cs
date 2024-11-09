namespace soru15;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = { 61, 120, 34, 5, 15, 44, 8 };
        int toplam = 0;

        for (int i = 0; i < sayilar.Length; i++)
        {
            toplam += sayilar[i];
        }
        double ortalama = toplam / (double)sayilar.Length;

        Console.WriteLine(ortalama);

    }
}
