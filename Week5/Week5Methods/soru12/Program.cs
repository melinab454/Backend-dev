namespace soru12;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Bir tarih girin (gg,aa,yy formatında): ");
        string tarih = Console.ReadLine();

        if (DateTime.TryParse(tarih, out DateTime date))
        {
            Console.WriteLine($"Girdiğiniz tarih: {date.ToShortDateString()} -> {date.DayOfWeek}");
        }
        else
        {
            Console.WriteLine("Geçersiz bir tarih girdiniz.");
        }
    }
}
