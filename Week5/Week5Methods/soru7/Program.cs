namespace soru7;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Saat bilgilerini giriniz... örnek(13:03:05)");
        int saat = int.Parse(Console.ReadLine());
        int dakika = int.Parse(Console.ReadLine());
        int saniye = int.Parse(Console.ReadLine());

        Console.WriteLine($"{saat}:{dakika}:{saniye}");
    }
}
