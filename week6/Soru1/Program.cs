namespace soru1;

class Animal
{
    public string Name;
    public string spacies;
    public byte age;

    public void özellik()
    {
        Console.WriteLine($"{Name}\n{spacies}\n{age}");



    }


}

class Lion : Animal
{
    public void Makesound()
    {

        Console.WriteLine($"{Name}\n{spacies}\n{age}  Kükrüyor");

    }


}
class Eagle : Animal
{
    public void Makesound()
    {

        Console.WriteLine($"{Name}\n{spacies}\n{age} ötüyor ");

    }


}
class Parakeet : Animal
{
    public void Makesound()
    {

        Console.WriteLine($"{Name}\n{spacies}\n{age} Ötüyor");

    }


}

class Program
{
    static void Main(string[] args)
    {
        Lion lion1 = new Lion();
        lion1.Name = "Aslan";
        lion1.spacies = "ASLAN";
        lion1.age = 120;

        lion1.Makesound();


        Parakeet parakeet1 = new Parakeet();
        parakeet1.Name = "Pamuk";
        parakeet1.spacies = "Muhabbet kuşu";
        parakeet1.age = 3;
        parakeet1.Makesound();


        Eagle eagle1 = new Eagle();
        eagle1.Name = "Şimşek";
        eagle1.spacies = "Kartal";
        eagle1.age = 6;
        eagle1.Makesound();


    }


}
