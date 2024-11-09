using System.Globalization;

namespace soru3;

class Program
{
    static void Main(string[] args)
    {
        List<int> Listem = new List<int> { };
        List<int> Çift = new List<int> { };
        List<int> tek = new List<int> { };
        Random random = new Random();

        int hesap;

        for (int i = 0; i < 10; i++)
        {
            Listem.Add(random.Next(1, 300));
        }
        foreach (int liste in Listem)
        {
            Console.WriteLine(" Elemanlar:" + String.Join(",", liste));
            {
                if (liste % 2 == 0)
                {
                    Çift.Add(liste);
                }
                else
                {
                    tek.Add(liste);
                }

            }

        }
        Console.WriteLine("çift Eleman olanlar: " + string.Join(", ", Çift));
        Console.WriteLine("Tek eleman olanlar: " + string.Join(", ", tek));


    }

}
