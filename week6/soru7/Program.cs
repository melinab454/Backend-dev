namespace soru7
{
    class Program
    {
        class Product
        {
            public string Name { get; set; }
            public double Price { get; set; }
            public int StockQuantity { get; set; }

            public Product(string name, double price, int stockQuantity)
            {
                Name = name;
                Price = price;
                StockQuantity = stockQuantity;
            }

            public void CheckStock() =>
                Console.WriteLine(StockQuantity > 0 ? "Stokta var" : "Stokta yok");

            public void UpdateStock(int quantity) => StockQuantity += quantity;
        }

        class FoodProduct : Product
        {
            public DateTime ExpirationDate { get; set; }

            public FoodProduct(string name, double price, int stockQuantity, DateTime expirationDate)
                : base(name, price, stockQuantity) => ExpirationDate = expirationDate;

            public void CheckExpiration() =>
                Console.WriteLine(ExpirationDate < DateTime.Now ? "Son kullanma tarihi geçti" : "Son kullanma tarihi geçmedi");
        }

        class ElectronicProduct : Product
        {
            public int WarrantyPeriod { get; set; }

            public ElectronicProduct(string name, double price, int stockQuantity, int warrantyPeriod)
                : base(name, price, stockQuantity) => WarrantyPeriod = warrantyPeriod;

            public void CheckWarranty() =>
                Console.WriteLine($"Garanti süresi: {WarrantyPeriod} ay");
        }

        static void Main(string[] args)
        {
            var elma = new FoodProduct("Elma", 5.0, 100, DateTime.Now.AddMonths(2));
            elma.CheckStock();
            elma.CheckExpiration();

            var bilgisayar = new ElectronicProduct("Bilgisayar", 4500.0, 20, 36);
            bilgisayar.CheckStock();
            bilgisayar.CheckWarranty();
        }
    }
}
