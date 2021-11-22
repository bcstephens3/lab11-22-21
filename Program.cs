using System;
using System.IO;

namespace lab11_22_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Author myAuthor = new Author("jeff lucas", 'm', "jslucas@cba.ua.edu");
            System.Console.WriteLine(myAuthor.ToString());
            Book myBook = new Book("12243", "My book, Your book", myAuthor);
            System.Console.WriteLine(myBook.ToString());
            System.Console.WriteLine(myBook.GetAuthor().ToString());

            Book yourBook = new Book("4321", "The Phantom Book", new Author("Jamie", 'f', "jamiehillman@mail.com"));
            System.Console.WriteLine(yourBook.ToString());
            yourBook.GetAuthor().SetEmail("jamie@crimson.ua.edu");
            System.Console.WriteLine(yourBook.ToString());
        }
    }
}
