namespace HesapIslemleri
{
    class Program
    {
        class Account
        {
            public string AccountNumber { get; set; }
            public double Balance { get; set; }

            public Account(string accountNumber, double balance)
            {
                AccountNumber = accountNumber;
                Balance = balance;
            }

            public void Deposit(double amount) =>
                Balance += amount;

            public void Withdraw(double amount)
            {
                if (Balance >= amount)
                    Balance -= amount;
                else
                    Console.WriteLine("Yetersiz bakiye.");
            }

            public void ShowBalance() =>
                Console.WriteLine($"Hesap Numarası: {AccountNumber}, Bakiye: {Balance}");
        }

        class SavingsAccount : Account
        {
            public double InterestRate { get; set; }

            public SavingsAccount(string accountNumber, double balance, double interestRate)
                : base(accountNumber, balance)
            {
                InterestRate = interestRate;
            }

            public void ApplyInterest() =>
                Balance += Balance * InterestRate;

            public void ShowInterestRate() =>
                Console.WriteLine($"Faiz Oranı: {InterestRate * 100}%");
        }

        class CheckingAccount : Account
        {
            public CheckingAccount(string accountNumber, double balance)
                : base(accountNumber, balance) { }

            public void WriteCheck(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                    Console.WriteLine($"Çek yazıldı: {amount} TL");
                }
                else
                {
                    Console.WriteLine("Yetersiz bakiye, çek yazılamaz.");
                }
            }
        }

        static void Main(string[] args)
        {
            var tasarrufHesabi = new SavingsAccount("12345", 1000, 0.05);
            tasarrufHesabi.ShowBalance();
            tasarrufHesabi.ApplyInterest();
            tasarrufHesabi.ShowBalance();
            tasarrufHesabi.ShowInterestRate();

            var vadesizHesap = new CheckingAccount("67890", 500);
            vadesizHesap.ShowBalance();
            vadesizHesap.WriteCheck(100);
            vadesizHesap.ShowBalance();
        }
    }
}
