namespace soru17;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = { 44, 44, 34, 34, 15, 44, 8 };


        var tekrarEdenler = sayilar.GroupBy(x => x).Where(g => g.Count() > 1).Select(g => g.Key).ToList();

        Console.WriteLine("Tekrar eden sayılar:");
        foreach (var sayi in tekrarEdenler)
        {
            Console.WriteLine(sayi);
        }
    }
}
