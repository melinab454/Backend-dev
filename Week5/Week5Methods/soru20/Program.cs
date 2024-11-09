using System;

namespace soru20
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kelimeler = { "Dünyanın ", "bir", "başkenti", "olsa", "o ", "şehir", "İstanbul", "Olurdu" };
            string sonuc = StringBirleştir(kelimeler);
            Console.WriteLine(sonuc);
        }

        static string StringBirleştir(string[] dizi)
        {
            string birlesik = "";
            foreach (string kelime in dizi)
            {
                birlesik += kelime + " ";
            }
            return birlesik.Trim();
        }
    }
}
