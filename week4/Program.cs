namespachafta4;
class Prram

    stat void Main(string[] args)
    
 soru1
 Console.WriteLine("pozitif bir sayı giriniz:");
int sayi;
while (!int.TryParse(Console.ReadLine(), out sayi) || sayi <= 0)
{
    Console.WriteLine("lütfen geçerli bir sayı girini");
}
int toplam = 0;
for (int i = 0; i <= sayi; i++)
{
    toplam += i;
}
Console.WriteLine($" 1'den {sayi} 'ya kadar olan sayıların toplamı {toplam}'dır");
soru2
         Console.WriteLine("pozitif bir sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = 0; i <= sayi; i++)
{
    int kup = i * i * i;
    Console.WriteLine($"{i}^3 = {kup}");
}
soru3
        Console.WriteLine("pozitif bir tam sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{sayi}'sının tam bölenleri:");
for (int i = 0; i <= sayi; i++)
{
    if (sayi % i == 0)
    {
        Console.WriteLine(i);
    }
}
soru 4
         Console.WriteLine("pozitif bir sayı giriniz:");
int sayi = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= sayi; i++)
{
    for (int j = 1; j <= i; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}
soru6
         Console.WriteLine("10'dan büyük bir sayı girin:");
int sayi = Convert.ToInt32(Console.ReadLine());
for (int i = 0; i <= sayi; i++)
{
    int kare = i * i;
    Console.WriteLine($"{i}^2 = {kare}");
}
soru7
             Console.WriteLine("pozitif bir sayı giriniz");
int sayi = Convert.ToInt32(Console.ReadLine());
int toplam = 0;
for (int i = 2; i <= sayi; i += 2)
{
    toplam += i;
    Console.WriteLine($"1'den {sayi}'ye kadar olan çift sayıların toplamı: {toplam}");
    soru8
         Console.WriteLine("pozitif bir tam sayı giriniz:");
    int sayi = Convert.ToInt32(Console.ReadLine());
    for (int i = sayi; i >= 1; i--)
    {
        int kare = i * i;
        Console.WriteLine($"{i}^2 = {kare}");
    }
    soru10
         Console.Write("İlk pozitif tam sayıyı girin: ");
    int ilkSayi = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci pozitif tam sayıyı girin: ");
    int ikinciSayi = Convert.ToInt32(Console.ReadLine());
    long carpim = 1;
    for (int i = ilkSayi; i <= ikinciSayi; i++)
    {
        carpim *= i; // Çarpıma ekle
    }
    Console.WriteLine($"{ilkSayi} ile {ikinciSayi} arasındaki sayıların çarpımı: {carpim}");
    WHİLE SORULARI
        soru1
         int toplam = 0;
    while (true)
    {
        Console.WriteLine("bir sayı giriniz:");
        int sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi == 0)
        {
            break;
        }
        else if (sayi > 0)
        {
            toplam += sayi;
        }
        else
        {
            Console.WriteLine("geçerli bir sayı girin:");
        }
        Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
    }
    soru2
             Console.Write("Bir metin girin: ");
    string metin = Console.ReadLine();
    string buyukHarfliMetin = "";
    int i = 0;
    while (i < metin.Length)
    {
        if (Char.IsLetter(metin[i]))
        {
            buyukHarfliMetin += Char.ToUpper(metin[i]);
        }
        else
        {
            buyukHarfliMetin += metin[i];
        }
        i++;
    }
    Console.WriteLine("Sonuç: " + buyukHarfliMetin);
    soru3
            while (true)
    {
        Console.WriteLine("pozitif bir  sayı girin:");
        int sayi = int.Parse(Console.ReadLine());
        if (sayi < 0)
        {
            break;
        }
        Console.WriteLine($"{sayi} sayısının karesi: {sayi * sayi}");
    }
    soru4
            Console.Write("bir sayı giriniz:");
    int sayi = int.Parse(Console.ReadLine());
    int toplam = 0;
    while (sayi > 0)
    {
        toplam += sayi % 10;
        sayi /= 10;
    }
    Console.WriteLine("sayıların toplamı:" + toplam);
    soru5
         Console.WriteLine("lütfen bir sayı girin:");
    int sayi = int.Parse(Console.ReadLine());
    int tersSayi = 0;
    while (sayi > 0)
    {
        int basamak = sayi % 10;
        tersSayi = tersSayi * 10 + basamak;
        sayi /= 10;
    }
    Console.WriteLine("ters çevrilmiş sayı:" + tersSayi);
    soru7
         Console.WriteLine("Bir sayı girin:");
    int sayi = int.Parse(Console.ReadLine());
    Console.WriteLine("bir üst sınır giriniz:");
    int üstSinir = int.Parse(Console.ReadLine());
    while (sayi < üstSinir)
    {
        Console.WriteLine($"mevcut sayı:{sayi}");
        sayi *= 2;
    }
    Console.WriteLine($"Sonuç: {sayi} (Üst sınırı aştı!)");
    soru8
             int sayiAdedi = 0;
    int toplam = 0;
    double ortalama = 0;
    while (true)
    {
        Console.Write("Pozitif bir tam sayı girin (100'den büyük bir sayı girildiğinde program sona erer): ");
        int sayi = int.Parse(Console.ReadLine());
        if (sayi > 100)
        {
            break;
        }
        toplam += sayi;
        sayiAdedi++;
    }
    if (sayiAdedi > 0)
    {
        ortalama = (double)toplam / sayiAdedi;
        Console.WriteLine($"Girilen toplam sayı adedi: {sayiAdedi}");
        Console.WriteLine($"Girilen sayıların toplamı: {toplam}");
        Console.WriteLine($"Girilen sayıların ortalaması: {ortalama:F2}");
    }
    soru9
             Console.Write("Pozitif bir tam sayı girin: ");
    int sayi = int.Parse(Console.ReadLine());
    for (int i = 1; i <= sayi; i++)
    {
        if (IsAsal(i))
        {
            Console.WriteLine($"{i} - Asal");
        }
        else
        {
            Console.WriteLine($"{i} - Asal değil");
        }
    }
}
static bool IsAsal(int sayi)
{
    if (sayi <= 1) return false;
    for (int i = 2; i <= Math.Sqrt(sayi); i++)
    {
        if (sayi % i == 0)
        {
            return false;
        }
    }
    return true;
    soru10
         Console.Write("Birinci sayıyı girin: ");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.Write("İkinci sayıyı girin: ");
    int sayi2 = int.Parse(Console.ReadLine());
    long carpim = 1;
    for (int i = sayi1; i <= sayi2; i++)
    {
        carpim *= i;
    }
    Console.WriteLine($"Çarpım sonucu: {carpim}");
    MİN / MAX SORUSU
         int enBuyuk = int.MinValue;
    int enKucuk = int.MaxValue;
    for (int i = 1; i <= 5; i++)
    {
        Console.Write($"{i}. sayıyı girin: ");
        int sayi = int.Parse(Console.ReadLine());
        if (sayi > enBuyuk)
        {
            enBuyuk = sayi;
        }
        if (sayi < enKucuk)
        {
            enKucuk = sayi;
        }
    }
    Console.WriteLine($"En Büyük = {enBuyuk}  En Küçük = {enKucuk}");
}

