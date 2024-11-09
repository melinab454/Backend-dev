namespace soru10;

class Program
{
    class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Character(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void ShowHealth() =>
            Console.WriteLine($"{Name} Sağlık: {Health}");
    }

    class Warrior : Character
    {
        public Warrior(string name, int health)
            : base(name, health) { }

        public void SwordAttack()
        {
            Console.WriteLine($"{Name} kılıçla saldırdı!");
        }
    }

    class Mage : Character
    {
        public Mage(string name, int health)
            : base(name, health) { }

        public void CastSpell()
        {
            Console.WriteLine($"{Name} büyü attı!");
        }
    }

    class Archer : Character
    {
        public Archer(string name, int health)
            : base(name, health) { }

        public void ShootArrow()
        {
            Console.WriteLine($"{Name} ok atışı yaptı!");
        }
    }

    static void Main(string[] args)
    {
        var warrior = new Warrior("Savaşçı", 100);
        warrior.ShowHealth();
        warrior.SwordAttack();

        var mage = new Mage("Büyücü", 80);
        mage.ShowHealth();
        mage.CastSpell();

        var archer = new Archer("Okçu", 90);
        archer.ShowHealth();
        archer.ShootArrow();
    }
}

