namespace soru6;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir sayı giriniz...");
        int sayi = Convert.ToInt32(Console.ReadLine());

        if (sayi % 2 == 0)
        {
            Console.WriteLine("Girilen sayı çifttir...");
        }
        else
        {
            Console.WriteLine("Girilen sayı tektir...");
        }
    }
}
