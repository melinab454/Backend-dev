namespace Soru5
{
    class Program
    {
        class Event
        {
            public string Name { get; set; }
            public DateTime Date { get; set; }
            public string Location { get; set; }

            public Event(string name, DateTime date, string location)
            {
                Name = name;
                Date = date;
                Location = location;
            }

            public virtual void DisplayInfo() =>
                Console.WriteLine($"Event: {Name}, Date: {Date.ToShortDateString()}, Location: {Location}");
        }

        class Meeting : Event
        {
            public string Agenda { get; set; }
            public Meeting(string name, DateTime date, string location, string agenda)
                : base(name, date, location) => Agenda = agenda;

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Agenda: {Agenda}");
            }
        }

        class Birthday : Event
        {
            public string BirthdayPerson { get; set; }
            public Birthday(string name, DateTime date, string location, string birthdayPerson)
                : base(name, date, location) => BirthdayPerson = birthdayPerson;

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Birthday Person: {BirthdayPerson}");
            }
        }

        class Task : Event
        {
            public bool IsCompleted { get; private set; }
            public Task(string name, DateTime date, string location)
                : base(name, date, location) { }

            public void MarkAsComplete() => IsCompleted = true;

            public override void DisplayInfo()
            {
                base.DisplayInfo();
                Console.WriteLine($"Completed: {IsCompleted}");
            }
        }

        static void Main(string[] args)
        {
            var event1 = new Event("Annual Conference", new DateTime(2024, 12, 15), "Convention Center");
            var meeting1 = new Meeting("Team Meeting", new DateTime(2024, 11, 10), "Office", "Project Updates");
            var birthday1 = new Birthday("Birthday Party", new DateTime(2024, 10, 5), "Home", "John Doe");
            var task1 = new Task("Complete Report", new DateTime(2024, 11, 1), "Office");

            event1.DisplayInfo();
            meeting1.DisplayInfo();
            birthday1.DisplayInfo();
            task1.DisplayInfo();

            task1.MarkAsComplete();
            task1.DisplayInfo();
        }
    }
}
