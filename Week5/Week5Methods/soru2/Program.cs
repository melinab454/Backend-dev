namespace soru2;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen karşılaştırmak istediğniz sayıları giriniz...");
        int sayi1 = Convert.ToInt32(Console.ReadLine());
        int sayi2 = Convert.ToInt32(Console.ReadLine());

        if (sayi1 > sayi2)
        {
            Console.WriteLine($" Sayı {sayi1}  {sayi2} den büyüktür...");


        }
        else if (sayi1 < sayi2)
        {
            Console.WriteLine($"sayı {sayi2} sayı {sayi1} den büyüktür....");

        }
        else if (sayi1 == sayi2)
        {
            Console.WriteLine("Girilen sayılar birbirleri ile eşittir...");

        }
        else
        {
            Console.WriteLine("Hatalı değer girdiniz...");
        }


    }
}
