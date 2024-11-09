namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] randomNumber = { 42, 45, 21, 13, 75, 2, 7, 27, 8, 16 };

            // İlk ve son elemanı atlıyoruz
            for (int i = 1; i < randomNumber.Length - 1; i++)
            {
                // Hem önceki hem sonraki elemanla kıyaslama
                if (randomNumber[i] > randomNumber[i - 1] && randomNumber[i] > randomNumber[i + 1])
                {
                    Console.WriteLine($"{randomNumber[i]} kendinden önceki ve sonraki sayıdan büyüktür.");
                }   
                else
                {
                    Console.WriteLine($"{randomNumber[i]} kendinden önceki ve sonraki sayıdan küçüktür.");
                }
            }
        }
    }
}
