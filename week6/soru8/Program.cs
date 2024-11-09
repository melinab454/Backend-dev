namespace soru8;


class Program
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    class Teacher : Person
    {
        public string SubjectTaught { get; set; }

        public Teacher(string name, int age, string subjectTaught)
            : base(name, age) => SubjectTaught = subjectTaught;

        public void AttendClass() => Console.WriteLine($"{Name} dersi {SubjectTaught} veriyor.");
    }

    class Student : Person
    {
        public int GradeLevel { get; set; }

        public Student(string name, int age, int gradeLevel)
            : base(name, age) => GradeLevel = gradeLevel;

        public void AttendClass() => Console.WriteLine($"{Name} {GradeLevel}. sınıfta derse katılıyor.");
    }

    static void Main(string[] args)
    {
        var teacher = new Teacher("Ali", 35, "Matematik");
        var student = new Student("Ahmet", 16, 10);

        teacher.AttendClass();  // Ali dersi Matematik veriyor.
        student.AttendClass();  // Ahmet 10. sınıfta derse katılıyor.
    }
}
