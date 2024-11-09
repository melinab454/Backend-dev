namespace soru16;

class Program
{
    static void Main(string[] args)
    {
        int[] sayilar = new int[100];
        int toplam = 0;
        int sayac = 0;
        int girilenSayi;

        do
        {
            Console.Write("Bir sayı girin (çıkmak için 0 girin): ");
            girilenSayi = int.Parse(Console.ReadLine());

            if (girilenSayi != 0)
            {
                sayilar[sayac] = girilenSayi;
                toplam += girilenSayi;
                sayac++;
            }

        } while (girilenSayi != 0 && sayac < sayilar.Length);

        if (sayac > 0)
        {
            double ortalama = (double)toplam / sayac;
            Console.WriteLine("Girlen sayı:");
            for (int i = 0; i < sayac; i++)
            {
                Console.WriteLine(sayilar[i]);
            }
            Console.WriteLine($"Ortalama: {ortalama}");
        }
        else
        {
            Console.WriteLine("hatalı işlem lütfen kontrol ediniz....");
        }
    }
}

