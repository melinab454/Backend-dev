namespace soru1;

class Program
{
    static void Main(string[] args)
    {

        int EmeklilikYası = 65;
        bool kontrol = false;
        while (!kontrol)
        {
            Console.Write("Lütfen yaşınızı giriniz: ");

            if (int.TryParse(Console.ReadLine(), out int yas))
            {
                if (yas >= 0)
                {
                    kontrol = true;

                }
                if (yas >= EmeklilikYası)
                {
                    Console.WriteLine("Emeklilik yaşınız dolmuştur...");
                }

                else
                {
                    int hesap = EmeklilikYası - yas;
                    Console.WriteLine($"Emeklilik yaşınızın dolmasına {hesap} sene var ");
                }

            }
            else
            {
                Console.WriteLine("Hatalı değer girdiniz lütfen kontrol edip tekrar deneyiniz...");
            }
        }



    }
}
