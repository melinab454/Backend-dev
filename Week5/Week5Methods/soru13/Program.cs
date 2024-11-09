namespace soru13;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir metin giriniz...");
        string metin = Console.ReadLine();
        int sayaç = 0;


        for (int i = 0; i < metin.Length; i++)
        {
            if (char.IsLetter(metin[i]))
            {
                sayaç++;
            }

        }

    }
}
