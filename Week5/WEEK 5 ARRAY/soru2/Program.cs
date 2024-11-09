namespace soru2;

class Program
{
    static void intMain(string[] args)
    {
        int[] numbers = new int[10];
        int[] evenNumber = new int[10];
        int account = 0;

        Console.Write("Lütfen 10 tane sayı giriniz...");
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i <= 10; i++)
        {
            if (numbers[i] % 2 == 0)
            {
                evenNumber[account] = numbers[i];
                account++;
                Array.Sort(evenNumber, 0, account);
                Console.WriteLine($"Çift sayılar{evenNumber[i]}");
            }


            else
            {
                Console.WriteLine("tek olanlar");

            }


        }









    }

}
