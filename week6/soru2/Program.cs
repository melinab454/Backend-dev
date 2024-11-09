namespace soru2;

class Vehicle
{
    public string Make;
    public int Age;
    public string Model;

    public void write()
    {
        Console.WriteLine($"Markası {Make} Modeli{Model} üretim Yılı {Age} ");
    }
}

class Car : Vehicle
{
    public string tipi;
    public int KacKisilik;
    public void write()
    {
        Console.WriteLine($"Markası: {Make} Modeli: {Model} üretim Yılı:  {Age} Kasa tipi: {tipi} kaç kişilik: {KacKisilik}");
    }






}

class Bicycle : Vehicle
{
    public string türü;
    public byte VitesSayısı;

    public void write()
    {
        Console.WriteLine($"Markası: {Make} Modeli: {Model} üretim Yılı:  {Age} Türü: {türü} vites sayısı: {VitesSayısı}");
    }
}

class Motorcyle : Vehicle
{
    public string SoğutmaTipi;
    public int cc;

    public void write()
    {
        Console.WriteLine($"Markası: {Make} Modeli: {Model} üretim Yılı:  {Age} soğutma tipi: {SoğutmaTipi} kaç cc: {cc} ");
    }


}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.Make = "Mercedes";
        car1.Model = "G63";
        car1.Age = 2024;
        car1.KacKisilik = 5;
        car1.tipi = "SUV";

        car1.write();


        Bicycle bicycle1 = new Bicycle();
        bicycle1.Make = "Ümit";
        bicycle1.Model = "G4";
        bicycle1.Age = 2019;
        bicycle1.türü = "Yarış bisikleti";
        bicycle1.VitesSayısı = 21;

        bicycle1.write();


        Motorcyle motorcyle1 = new Motorcyle();
        motorcyle1.Make = "HONDA";
        motorcyle1.Model = "X-ADV";
        motorcyle1.Age = 2024;
        motorcyle1.SoğutmaTipi = "Sıvı soğutma";
        motorcyle1.cc = 450;

        motorcyle1.write();
    }
}
