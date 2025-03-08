using System;

class LibraryManager
{
    static void Main()
    {
        string book1 = "";
        string book2 = "";
        string book3 = "";
        string book4 = "";
        string book5 = "";

        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine();

            if (action.ToLower() == "add")
            {
                Console.WriteLine("Enter the title of the book to add:");
                string newBook = Console.ReadLine();

                if (book1 == "")
                {
                    book1 = newBook;
                }
                else if (book2 == "")
                {
                    book2 = newBook;
                }
                else if (book3 == "")
                {
                    book3 = newBook;
                }
                else if (book4 == "")
                {
                    book4 = newBook;
                }
                else if (book5 == "")
                {
                    book5 = newBook;
                }
                else
                {
                    Console.WriteLine("The library is full. No more books can be added.");
                }
            }
            else if (action.ToLower() == "remove")
            {
                Console.WriteLine("Enter the title of the book to remove:");
                string removeBook = Console.ReadLine().ToLower();

                if (removeBook == book1.ToLower())
                {
                    book1 = "";
                }
                else if (removeBook == book2.ToLower())
                {
                    book2 = "";
                }
                else if (removeBook == book3.ToLower())
                {
                    book3 = "";
                }
                else if (removeBook == book4.ToLower())
                {
                    book4 = "";
                }
                else if (removeBook == book5.ToLower())
                {
                    book5 = "";
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
            }
            else if (action.ToLower() == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }

            // Display the list of books
            Console.WriteLine("Available books:");
            if (!string.IsNullOrEmpty(book1)) {
                Console.WriteLine(book1);
            }
            if (!string.IsNullOrEmpty(book2)) {
                Console.WriteLine(book2);
            }
            if (!string.IsNullOrEmpty(book3)) {
                Console.WriteLine(book3);
            }
            if (!string.IsNullOrEmpty(book4)) {
                Console.WriteLine(book4);
            }
            if (!string.IsNullOrEmpty(book5)) {
                Console.WriteLine(book5);
            }
        }
    }
}