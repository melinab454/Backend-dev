namespace Soru11;

class Program
{
    static void Main(string[] args)
    {

        string[] Ünlü = { "a", "e", "ı", " i", "o", "ö", " u", "ü" };
        Console.Write("Lütfen bir kelime giriniz...");
        string kelime = Console.ReadLine();
        int sayaç = 0;


        for (int i = 0; i < kelime.Length; i++)
        {
            char c = Char.ToLower(kelime[i]);
            if (Array.Exists(Ünlü, element => element == c.ToString())) ;
            {
                sayaç++;
            }

        }
        Console.WriteLine($"Girdiğiniz kelimedeki ünlü harf sayısı: {sayaç}");
    }
}
