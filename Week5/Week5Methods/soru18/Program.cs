namespace soru18;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Adınızı girin: ");
        string ad = Console.ReadLine();

        Console.Write("Soyadınızı girin: ");
        string soyad = Console.ReadLine();
        string tamIsim = ad + " " + soyad;

        Console.WriteLine("Tam İsim: " + tamIsim);
    }

}

