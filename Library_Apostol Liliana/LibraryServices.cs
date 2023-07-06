using System;
using System.Collections.Generic;
using System.Linq;

namespace Library_Apostol_Liliana
{
    public class LibraryServices
    {
        static List<Book> BookList = new List<Book>();

        static string BookName;
        static string ISBN;
        static bool IsBorrowed;
        static string ClientName;
        static int ActualBorrowDays = 0;

        // default values for price and maximum borrow days
        const float Price = 5.0F;
        const int MaximumBorrowDays = 14;

        // adds a book to the library
        public static void AddBookToLibrary()
        {
            Console.WriteLine("Book Name: ");
            BookName = Console.ReadLine();

            Console.WriteLine("Book ISBN: ");
            ISBN = Console.ReadLine();

            Console.WriteLine("Book Price: " + Price);
            Console.WriteLine("Is Borrowed: " + IsBorrowed);

            var BookWithISBNEntered = BookList.Where(x => x.ISBN == ISBN).Count();

            if (BookWithISBNEntered > 0)
            {
                Console.WriteLine("The ISBN you entered already exists. Please enter another ISBN." + "\n");
            }
            else
            {
                BookList.Add(new Book(
                Name: BookName,
                ISBN: ISBN,
                Price: Price));
            }

            Console.WriteLine("\n");
        }

        // gets the list of all available books in the library
        public static void GetListOfAllBooks()
        {
            foreach (var item in BookList)
            {
                Console.WriteLine("\n");
                Console.WriteLine("Book Name: " + item.Name + "\n" + "Book ISBN: " + item.ISBN + "\n" + "Book Price: " + item.Price + "\n" + "Is Borrowed: " + item.IsBorrowed + "\n");
            }
        }

        // gets the number of copies for a certain book
        public static void GetNumberOfCopies()
        {
            int NumberOfCopies = 0;

            Console.WriteLine("Book Name: ");
            BookName = Console.ReadLine();

            foreach (var item in BookList)
            {
                if (item.Name == BookName)
                {
                    NumberOfCopies++;
                }
            }

            Console.WriteLine("Number of Copies: " + NumberOfCopies + "\n");
        }

        // lets a user borrow a book
        public static void BorrowBook()

        {
            Console.WriteLine("Name of the client that is borrowing the book: ");
            ClientName = Console.ReadLine();

            Console.WriteLine("Book ISBN: ");
            ISBN = Console.ReadLine();

            var BookToBorrow = BookList.Where(x => x.ISBN == ISBN);

            if (BookToBorrow.Any())
            {
                if (BookToBorrow.First().IsBorrowed == false)
                {
                    BookToBorrow.First().IsBorrowed = true;
                    BookToBorrow.First().ClientName = ClientName;
                    Console.WriteLine($"The book was borrowed. {ClientName} has 14 days to return the book." + "\n");
                }
                else
                {
                    Console.WriteLine("The book is already borrowed. Please enter another book ISBN." + "\n");
                }
            }
            else
            {
                Console.WriteLine($"There is no book stored with ISBN: {ISBN}." + "\n");
            }

        }

        // lets a user return a book
        public static void ReturnBook()
        {
            int NumberOfDaysPassed = 0;
            float AmmountToPay = 0F;

            Console.WriteLine("Name of the client that is returning the book: ");
            ClientName = Console.ReadLine();

            Console.WriteLine("Book ISBN: ");
            ISBN = Console.ReadLine();

            var BookToReturn = BookList.Where(x => x.ISBN == ISBN && x.IsBorrowed == true);

            if (BookToReturn.Any())
            {

                Console.WriteLine("Number of days having the book: ");
                ActualBorrowDays = Convert.ToInt32(Console.ReadLine());

                if (ActualBorrowDays > MaximumBorrowDays)
                {
                    NumberOfDaysPassed = ActualBorrowDays - MaximumBorrowDays;
                    AmmountToPay = (1F / 100F) * Price / NumberOfDaysPassed;

                    Console.WriteLine($"{ClientName} has passed the maximum borrow days by {NumberOfDaysPassed}. The client has to pay extra {AmmountToPay} lei." + "\n");
                }

                BookToReturn.First().IsBorrowed = false;
                Console.WriteLine("The book has been returned." + "\n");

            }
            else
            {
                Console.WriteLine("The book you are trying to return doesn't exist or hasn't been borrowed yet. Please make sure you are entering the right information." + "\n");

            }
        }
    }
}
