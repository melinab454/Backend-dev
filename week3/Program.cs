using System.ComponentModel;

namespace hafta3;

class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("bir cümle giriniz:");
        // string cumle = Console.ReadLine();

        // int kelimesaiyi = cumle.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        // Console.WriteLine("kelime sayısı:" + kelimesaiyi);

        // SORU2
        //     Console.WriteLine("bir cümle giriniz:");
        // string cumle = Console.ReadLine();


        // string büyükharf = cumle.ToUpper();
        // string kucukHarf = cumle.ToLower();

        // Console.WriteLine(büyükharf + Environment.NewLine + kucukHarf);

        // SORU3
        //   Console.WriteLine("bir cümle giriniz:");
        // string cumle = Console.ReadLine();

        // Console.WriteLine("aranacak kelimeyi girin:");
        // string kelime = Console.ReadLine();

        // string[] kelimeler = cumle.Split(' ');
        // int sayac = 0;
        // for (int i = 0; i < kelimeler.Length; i++)
        // {
        //     if (kelimeler[i].Equals(kelime, StringComparison.OrdinalIgnoreCase))
        //     {
        //         sayac++;
        //     }
        // }

        // Console.WriteLine($"Kelime '{kelime}' cümlede {sayac} kez geçiyor.");
        // {

        // }

        // SORU4
        //  Console.WriteLine("bir metin giriniz:");
        // string metin = Console.ReadLine();
        // string temizCumle = metin.Trim();
        // Console.WriteLine("Temizlenmiş cümle: \"" + temizCumle + "\"");

        // SORU5
        //     Console.WriteLine("bir  cümle giriniz:");
        // string cümle = Console.ReadLine();

        // Console.WriteLine("aranacak cümleyi girin:");
        // string aranacak = Console.ReadLine();
        // int indeks = cümle.IndexOf(aranacak, StringComparison.OrdinalIgnoreCase);
        // if (indeks == 0)
        // {
        //     Console.WriteLine("aranan metin bulunamadı");
        // }
        // else
        // {
        //     Console.WriteLine(indeks);
        // }


        // NUMBER METOTLARI
        // soru1

        //  Console.WriteLine("Ondalıklı bir sayı giriniz:");
        // double sayi = Convert.ToDouble(Console.ReadLine());
        // int yuvarlananSayi = (int)Math.Round(sayi);
        // Console.WriteLine("En yakın tam sayı " + yuvarlananSayi);

        // soru 2
        //  Console.WriteLine("1. sayıyı girin:");
        // int sayi1 = Convert.ToInt32(Console.ReadLine());
        // Console.WriteLine("2. sayıyı girin:");
        // int sayi2 = Convert.ToInt32(Console.ReadLine());
        // if (sayi1 < sayi2)
        // {
        //     Console.WriteLine("sayı 2 büyüktür sayı 1");
        // }
        // else
        // {
        //     Console.WriteLine("sayı 1 küçüktür sayı 2 ");
        // }
        // Soru 3
        //  Console.WriteLine("Bir sayı girin:");
        // double sayi = Convert.ToDouble(Console.ReadLine());


        // double mutlakDeger = Math.Abs(sayi);
        // Console.WriteLine("Sayının mutlak değeri: " + mutlakDeger);

        // soru4
        //    Console.WriteLine("bir sayı giriniz:");
        // double sayi = Convert.ToDouble(Console.ReadLine());
        // double kareKök = Math.Sqrt(sayi);
        // Console.WriteLine("sayının karekökü:" + kareKök);

        // soru5
        //  Console.WriteLine("Taban sayısını girin:");
        // double taban = Convert.ToDouble(Console.ReadLine());

        // Console.WriteLine("Üs sayısını girin:");
        // double us = Convert.ToDouble(Console.ReadLine());
        // double sonuc = Math.Pow(taban, us);
        // Console.WriteLine($"{taban}^{us} = {sonuc}");

        // DATETİME METOTLARI
        //    soru1
        //    Console.WriteLine("bir tarih girin (g.a.y) formarında ");
        // string tarihInput = Console.ReadLine();
        // DateTime tarih = Convert.ToDateTime(tarihInput);
        // string gun = tarih.DayOfWeek.ToString();
        // Console.WriteLine("Haftanın günü: " + gun);

        // soru2
        //  DateTime simdi = DateTime.Now;
        // Console.WriteLine("Şuanki tarih ve saat:" + simdi);

        // soru3
        //  Console.WriteLine("tarih giriniz:");
        // DateTime tarih = Convert.ToDateTime(Console.ReadLine());
        // Console.WriteLine("eklenecek gün sayısını girin:");
        // int eklenenGun = Convert.ToInt32(Console.ReadLine());
        // DateTime yeniTarihi = tarih.AddDays(eklenenGun);
        // Console.WriteLine("Yeni Tarih:" + yeniTarihi.ToShortDateString());

        // soru4
        //  Console.WriteLine("birinci tarihi girin:");
        // DateTime tarih1 = DateTime.Parse(Console.ReadLine());

        // Console.WriteLine("2.tarihi giriniz:");
        // DateTime tarih2 = DateTime.Parse(Console.ReadLine());

        // TimeSpan fark = tarih1 - tarih2;
        // Console.WriteLine("iki tarih arasındaki fark:" + fark);

        // soru8
        //   DateTime now = DateTime.Now;
        // string AyAdi = now.ToString("MMM");
        // Console.WriteLine("Şuanki ay adi:" + AyAdi);

        // soru9
        //  Console.WriteLine("1. tarihi girin:");
        // DateTime tarih1 = DateTime.Parse(Console.ReadLine());
        // Console.WriteLine("2.tarihi girin:");
        // DateTime tarih2 = DateTime.Parse(Console.ReadLine());

        // if (tarih1 < tarih2)
        // {
        //     Console.WriteLine("1. tarih 2. tarihten önce");
        // }
        // else
        // {
        //     Console.WriteLine("2.tarhi 1. tarihten önce ");
        // }


        // if ,else,else if yapısı

        // soru1
        //   Console.WriteLine("bir sayı girin:");
        // int sayi = Convert.ToInt32(Console.ReadLine());

        // if (sayi < 0)
        // {
        //     Console.WriteLine("girilen sayı negatif");
        // }
        // else if (sayi > 0)
        // {
        //     Console.WriteLine("girilen sayı pozitif");
        // }
        // else
        // {
        //     Console.WriteLine("girilen sayı sıfırdır");
        // }

        // soru2
        //   Console.WriteLine("1.sayıyı giriniz:");
        // int sayi1 = int.Parse(Console.ReadLine());

        // Console.WriteLine("2.sayıyı giriniz:");
        // int sayi2 = int.Parse(Console.ReadLine());

        // Console.WriteLine("3. sayıyı giriniz:");
        // int sayi3 = int.Parse(Console.ReadLine());

        // int[] sayilar = { sayi1, sayi2, sayi3 };
        // Array.Sort(sayilar);
        // Array.Reverse(sayilar);
        // Console.WriteLine("Büyükten küçüğe sıralanmış sayılar: " + string.Join(", ", sayilar));


        // soru4
        //   Console.WriteLine("bir yıl giriniz:");
        // int yil = int.Parse(Console.ReadLine());
        // bool artikYil = (yil % 4 == 0 && yil % 100 != 0) || (yil % 400 == 0);
        // if (artikYil)
        // {
        //     Console.WriteLine(yil + "Artık bir yıldır");
        // }
        // else
        // {
        //     Console.WriteLine(yil + "artık bir yıl değil");
        // }
        // Console.WriteLine("1.kenar uzunluğu girin:");
        // double kenar1 = double.Parse(Console.ReadLine());

        // Console.WriteLine("2. kenar uzunluğu girin:");
        // double kenar2 = double.Parse(Console.ReadLine());

        // Console.WriteLine("3.kenar uzunluğu girinin:");
        // double kenar3 = double.Parse(Console.ReadLine());

        // bool ucgenOlusturulabilir = (kenar1 + kenar2 > kenar3) &&
        //                            (kenar1 + kenar3 > kenar2) &&
        //                            (kenar2 + kenar3 > kenar1);
        // if (ucgenOlusturulabilir)
        // {
        //     Console.WriteLine("bir üçgen oluşturabilir.");
        // }
        // else
        // {
        //     Console.WriteLine("bir üçgen oluşturulabilir.");
        // }


        // Console.Write("Notunuzu giriniz (0-100 arası): ");
        // double notu = double.Parse(Console.ReadLine());


        // char harfNotu;
        // if (notu < 0 || notu > 100)
        // {
        //     Console.WriteLine("Lütfen 0 ile 100 arasında bir not girin.");
        //     return;
        // }
        // else if (notu >= 85)
        // {
        //     harfNotu = 'A';
        // }
        // else if (notu >= 70)
        // {
        //     harfNotu = 'B';
        // }
        // else if (notu >= 60)
        // {
        //     harfNotu = 'C';
        // }
        // else if (notu >= 50)
        // {
        //     harfNotu = 'D';
        // }
        // else
        // {
        //     harfNotu = 'F';
        // }

        // soru7
        //  Console.WriteLine("Harf Notu: " + harfNotu);

        // Console.WriteLine("1.sayıyı giriniz:");
        // double sayi1 = double.Parse(Console.ReadLine());

        // Console.WriteLine("2.sayıyı girin:");
        // double sayi2 = double.Parse(Console.ReadLine());

        // Console.WriteLine("3.sayıyı girin:");
        // double sayi3 = double.Parse(Console.ReadLine());
        // double EnBuyukSayi = sayi1;

        // if (sayi2 > sayi1)
        // {
        //     Console.WriteLine("en büyük sayı sayi2");
        // }
        // if (sayi3 > sayi1)
        // {
        //     Console.WriteLine("en büyük sayı sayi3");
        // }

        // soru8
        //  Console.WriteLine("bir sayı giriniz:");
        // double sayi = double.Parse(Console.ReadLine());

        // if (sayi % 3 == 0 && sayi % 5 == 0)
        // {
        //     Console.WriteLine("bu sayı 3'e ve 5'e tam bölünür");
        // }
        // soru10
        //  Console.WriteLine("bir sayı girniz");
        // double sayi = double.Parse(Console.ReadLine());
        // bool asalMi = true;
        // if (sayi <= 1)
        // {
        //     asalMi = false;
        // }
        // else
        // {
        //     for (int i = 2; i <= Math.Sqrt(sayi); i++)
        //     {
        //         if (sayi % i == 0)
        //         {
        //             asalMi = false; Tam bölünüyorsa asal değildir
        //                      break;
        //         }
        //     }
        // }
        // if (asalMi)
        // {
        //     Console.WriteLine(sayi + " bir asal sayıdır.");
        // }
        // else
        // {
        //     Console.WriteLine(sayi + " bir asal sayı değildir.");
        // }
        // SWİTCH YAPISI
        // soru1
        //   Console.WriteLine(" 1-7 arası bir sayı giriniz");
        // int GunNo = int.Parse(Console.ReadLine());
        // switch (GunNo)
        // {
        //     case 1:
        //         Console.WriteLine("Pazartesi");
        //         break;
        //     case 2:
        //         Console.WriteLine("Salı");
        //         break;
        //     case 3:
        //         Console.WriteLine("Çarşamba");
        //         break;
        //     case 4:
        //         Console.WriteLine("Perşembe");
        //         break;
        //     case 5:
        //         Console.WriteLine("Cuma");
        //         break;
        //     case 6:
        //         Console.WriteLine("Cumartesi");
        //         break;
        //     case 7:
        //         Console.WriteLine("Pazar");
        //         break;
        //     default:
        //         Console.WriteLine("Geçersiz bir sayı girdiniz! Lütfen 1-7 arası bir sayı girin.");
        //         break;
        // }
        // soru2
        //  Console.WriteLine("1-12 arası bir sayı giriniz:");
        // int AyNo = int.Parse(Console.ReadLine());
        // switch (AyNo)
        // {
        //     case 1:
        //         Console.WriteLine("ocak");
        //         break;
        //     case 2:
        //         Console.WriteLine("şubat");
        //         break;
        //     case 3:
        //         Console.WriteLine("mart");
        //         break;
        //     case 4:
        //         Console.WriteLine("nisan");
        //         break;
        //     case 5:
        //         Console.WriteLine("mayıs");
        //         break;
        //         12 ayın tamamı aynı şekilde olur...
        // }
        // soru3
        //  Console.WriteLine("birinci sayıyı girin:");
        // double sayi1 = double.Parse(Console.ReadLine());

        // Console.WriteLine("ikinci sayıyı girin:");
        // double sayi2 = double.Parse(Console.ReadLine());
        // Console.WriteLine("Yapmak istediğiniz işlemi girin: (*,-,+,/)");
        // char islem = Console.ReadLine()[0];

        // double sonuc;

        // switch (islem)
        // {
        //     case '+': sonuc = sayi1 + sayi2; break;
        //     case '-': sonuc = sayi1 - sayi2; break;
        //     case '*': sonuc = sayi1 * sayi2; break;
        //     case '/':
        //         if (sayi2 == 0) { Console.WriteLine("Hata: Sıfıra bölme!"); return; }
        //         sonuc = sayi1 / sayi2; break;
        //     default:
        //         Console.WriteLine("Geçersiz işlem!"); return;
        // }
        // Console.WriteLine("Sonuç: " + sonuc);

        // soru4
        //  Console.WriteLine("Bir harf giriniz:");
        // char harf = Console.ReadLine()[0];
        // char[] sesliHarfler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü',
        //                           'A', 'E', 'I', 'İ', 'O', 'Ö', 'U', 'Ü' };
        // if (Array.Exists(sesliHarfler, h => h == harf))
        // {
        //     Console.WriteLine(harf + "bir sesli harftir");
        // }
        // else
        // {
        //     Console.WriteLine(harf + "bir sessiz harftir");
        // }

        // soru5
        //     Console.WriteLine("notunuzu giriniz (A,B,C,D):");
        // double not = double.Parse(Console.ReadLine());
        // string notu = Console.ReadLine().ToUpper();
        // switch (notu)
        // {
        //     case "A":
        //     case "B":
        //     case "C":
        //         Console.WriteLine("Geçtiniz!");
        //         break;
        //     case "D":
        //         Console.WriteLine("Geçtiniz, ama daha iyi bir not almanız gerek.");
        //         break;
        //     case "F":
        //         Console.WriteLine("Kaldınız.");
        //         break;
        //     default:
        //         Console.WriteLine("Geçersiz not girdiniz.");
        //         break;
        // }
        // soru7
        //  Console.WriteLine("1-5 arası bir sayı girin");
        // int sayi = Convert.ToInt32(Console.ReadLine());
        // string paraBirimi;

        // switch (sayi)
        // {
        //     case 1:
        //         paraBirimi = "1 Kr";
        //         break;
        //     case 2:
        //         paraBirimi = "5 Kr";
        //         break;
        //     case 3:
        //         paraBirimi = "10 Kr";
        //         break;
        //     case 4:
        //         paraBirimi = "25 Kr";
        //         break;
        //     case 5:
        //         paraBirimi = "50 Kr";
        //         break;
        //     default:
        //         paraBirimi = "Geçersiz bir sayı girdiniz!";
        //         break;
        // }
        // Console.WriteLine(paraBirimi);
        // soru8
        //          Console.WriteLine("0-6 arası bir sayı giriniz:");
        // int sayi = Convert.ToInt32(Console.ReadLine());
        // string sekil;
        // switch (sayi)
        // {
        //     case 0:
        //         sekil = "Nokta";
        //         break;
        //     case 1:
        //         sekil = "Çizgi";
        //         break;
        //     case 2:
        //         sekil = "Açı";
        //         break;
        //     case 3:
        //         sekil = "Üçgen";
        //         break;
        //     case 4:
        //         sekil = "Kare";
        //         break;
        //     case 5:
        //         sekil = "Beşgen";
        //         break;
        //     case 6:
        //         sekil = "Altıgen";
        //         break;
        //     default:
        //         sekil = "Geçersiz bir sayı girdiniz!";
        //         break;
        // }

        // Console.WriteLine(sekil);


        // Console.Write("1-5 arası bir sayı girin: ");
        // int sayi = Convert.ToInt32(Console.ReadLine());

        // string sayiSifati;

        // switch (sayi)
        // {
        //     case 1:
        //         sayiSifati = "Birinci";
        //         break;
        //     case 2:
        //         sayiSifati = "İkinci";
        //         break;
        //     case 3:
        //         sayiSifati = "Üçüncü";
        //         break;
        //     case 4:
        //         sayiSifati = "Dördüncü";
        //         break;
        //     case 5:
        //         sayiSifati = "Beşinci";
        //         break;
        //     default:
        //         sayiSifati = "Geçersiz bir sayı girdiniz!";
        //         break;
        // }

        // Console.WriteLine(sayiSifati);
    }
}