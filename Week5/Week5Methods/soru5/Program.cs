namespace soru5;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir isim giriniz...");
        string isim = Console.ReadLine();

        for (int i = 0; i < isim.Length; i++)
        {
            Console.Write(isim[i].ToString().ToUpper());
        }
        Console.WriteLine();

    }
}

