namespace Soru3
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int Salary { get; set; }

        public Employee(string name, int id, int salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Name: {Name}, ID: {Id}, Salary: {Salary}");
        }
    }
    class Manager : Employee
    {
        public int NumberOfTeams { get; set; }
        public Manager(string name, int id, int salary, int numberOfTeams) : base(name, id, salary)
        {
            NumberOfTeams = numberOfTeams;
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine(NumberOfTeams);
        }
    }
    class Developer : Employee
    {
        public string ProgrammingLanguage { get; set; }
        public Developer(string name, int id, int salary, string programmingLanguage)
            : base(name, id, salary)
        {
            ProgrammingLanguage = programmingLanguage;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Programming Language: {ProgrammingLanguage}");
        }
    }
    class Intern : Employee
    {
        public Intern(string name, int id, int salary)
            : base(name, id, salary)
        {
        }
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine("Internship position");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Employee employee = new Employee("Enes", 1, 5000);
            Manager manager = new Manager("Sena", 2, 7000, 3);
            Developer developer = new Developer("Fatma", 3, 6000, "C#");
            Intern intern = new Intern("Bora", 4, 1500);

            Console.WriteLine("Employee: ");
            employee.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Manager: ");
            manager.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Developer: ");
            developer.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Intern Info:");
            intern.DisplayInfo();
        }
    }
}
