namespace soru14;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih girin (gg,aa,yy formatında): ");
        string tarih1 = Console.ReadLine();
        Console.WriteLine("Bir tarih girin (gg,aa,yy formatında): ");
        string tarih2 = Console.ReadLine();
        string format = "dd.MM.yyyy";


        if (DateTime.TryParseExact(tarih1, format, null, System.Globalization.DateTimeStyles.None, out DateTime gün1) &&
         DateTime.TryParseExact(tarih2, format, null, System.Globalization.DateTimeStyles.None, out DateTime gün2))
        {
            TimeSpan fark = gün1 - gün2;
            Console.WriteLine(Math.Abs(fark.Days));
        }
        else
        {
            Console.WriteLine("Geçersiz bir tarih girdiniz.");
        }
    }
}
