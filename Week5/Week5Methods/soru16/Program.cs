namespace soru16;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Bir kelime girin: ");
        string kelime = Console.ReadLine();

        int sol = 0;
        int sag = kelime.Length - 1;
        bool palindromMu = true;

        while (sol < sag)
        {
            if (kelime[sol] != kelime[sag])
            {
                palindromMu = false;
                break;
            }
            sol++;
            sag--;
        }

        if (palindromMu)
        {
            Console.WriteLine("Kelime bir palindromdur.");
        }
        else
        {
            Console.WriteLine("Kelime bir palindrom değildir.");
        }
    }
}

