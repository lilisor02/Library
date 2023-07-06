using System;

namespace Library_Apostol_Liliana
{
    public class Program : LibraryServices
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome!");

            bool continueProgram = true;

            while (continueProgram)
            {
                Console.WriteLine("1. Add Book to Library");
                Console.WriteLine("2. Request List of Available Books");
                Console.WriteLine("3. Check Specific Book Copies");
                Console.WriteLine("4. Borrow Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. Exit");

                Console.WriteLine("\n");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.WriteLine("Please Add the Book Information Below: " + "\n");
                        AddBookToLibrary();
                        break;

                    case "2":
                        Console.WriteLine("List of All Books" + "\n");
                        GetListOfAllBooks();
                        break;

                    case "3":
                        Console.WriteLine("Check Specific Book Copies" + "\n");
                        GetNumberOfCopies();
                        break;

                    case "4":
                        Console.WriteLine("Borrow Book" + "\n");
                        BorrowBook();
                        break;

                    case "5":
                        Console.WriteLine("Return Book" + "\n");
                        ReturnBook();
                        break;

                    case "6":
                        continueProgram = false;
                        break;

                    default:
                        break;
                }
            }

        }

    }
}
