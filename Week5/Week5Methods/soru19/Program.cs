namespace soru19;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Alt sınır değerini girin: ");
        int sayi1 = int.Parse(Console.ReadLine());

        Console.Write("Üst sınır değerini girin: ");
        int sayi2 = int.Parse(Console.ReadLine());

        Console.WriteLine($"{sayi1} ile {sayi2} arasındaki asal sayılar:");

        for (int sayi = sayi1; sayi <= sayi2; sayi++)
        {
            bool asal = true;

            if (sayi < 2)
                asal = false;

            for (int i = 2; i <= Math.Sqrt(sayi); i++)
            {
                if (sayi % i == 0)
                {
                    asal = false;
                    break;
                }
            }

            if (asal)
            {
                Console.WriteLine(sayi);
            }
        }
    }
}
