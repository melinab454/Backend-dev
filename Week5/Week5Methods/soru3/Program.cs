namespace soru3;

class Program
{
    static void Main(string[] args)
    {

        Console.Write("Bir kelime giriniz: ");
        string kelime = Console.ReadLine();
        string tersKelime = KelimeyiTersCevir(kelime);
        Console.WriteLine("Tersine çevrilmiş kelime: " + tersKelime);
    }

    static string KelimeyiTersCevir(string kelime)
    {
        char[] karakterDizisi = kelime.ToCharArray();
        Array.Reverse(karakterDizisi);
        return new string(karakterDizisi);
    }
}

