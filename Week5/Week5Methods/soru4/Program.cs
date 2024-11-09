namespace soru4;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Vize notunu giriniz: ");
        double vize = Convert.ToDouble(Console.ReadLine());

        Console.Write("Final notunu giriniz: ");
        double final = Convert.ToDouble(Console.ReadLine());

        double ortalama = (vize * 0.30) + (final * 0.70);
        Console.WriteLine("Ortalamanız: " + ortalama);

        if (ortalama >= 50)
        {
            Console.WriteLine("Geçtiniz!");
        }
        else
        {
            Console.WriteLine("Kaldınız!");
        }
    }
}

