namespace Soru4
{
    class Program
    {
        // Kitap sınıfı
        class Book
        {
            public string Title { get; set; }
            public string Author { get; set; }
            public int Pages { get; set; }
            public string ISBN { get; set; }
            public bool IsBorrowed { get; private set; } // Kitap ödünç alındı mı?

            // Constructor
            public Book(string title, string author, int pages, string isbn)
            {
                Title = title;
                Author = author;
                Pages = pages;
                ISBN = isbn;
                IsBorrowed = false; // Başlangıçta kitap ödünç alınmamış
            }

            // Kitap bilgilerini ekrana yazdırma metodu
            public virtual void DisplayInfo()
            {
                Console.WriteLine($"Title: {Title}, Author: {Author}, Pages: {Pages}, ISBN: {ISBN}, Borrowed: {IsBorrowed}");
            }

            // Kitap ödünç alma metodu
            public void Borrow()
            {
                if (IsBorrowed)
                {
                    Console.WriteLine("This book is already borrowed.");
                }
                else
                {
                    IsBorrowed = true;
                    Console.WriteLine($"You have borrowed the book: {Title}");
                }
            }

            // Kitap iade etme metodu
            public void Return()
            {
                if (!IsBorrowed)
                {
                    Console.WriteLine("This book was not borrowed.");
                }
                else
                {
                    IsBorrowed = false;
                    Console.WriteLine($"You have returned the book: {Title}");
                }
            }
        }

        class Library
        {
            public List<Book> Books { get; set; }
            public Library()
            {
                Books = new List<Book>();
            }

            public void AddBook(Book book)
            {
                Books.Add(book);
                Console.WriteLine($"Book '{book.Title}' added to the library.");
            }

            public void ListBooks()
            {
                Console.WriteLine("Books in the library:");
                foreach (var book in Books)
                {
                    book.DisplayInfo();
                }
            }
        }

        static void Main(string[] args)
        {

            Book book1 = new Book("C# Programming", "John Doe", 300, "123-456-789");
            Book book2 = new Book("Learn SQL", "Jane Smith", 250, "987-654-321");


            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);
            library.ListBooks();
            book1.Borrow();
            book1.Return();
        }
    }
}
