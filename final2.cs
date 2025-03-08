using System;
using System.Collections.Generic;

class LibraryManager
{
    static void Main()
    {
        List<string> books = new List<string>(new string[5]);

        while (true)
        {
            Console.WriteLine("Would you like to add or remove a book? (add/remove/exit)");
            string action = Console.ReadLine().ToLower();

            if (action == "add")
            {
                AddBook(books);
            }
            else if (action == "remove")
            {
                RemoveBook(books);
            }
            
            else if (action == "search") 
            {
                SearchBook(books);
            }
            else if (action == "exit")
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid action. Please type 'add', 'remove', or 'exit'.");
            }

            DisplayBooks(books);
        }
    }

    static void AddBook(List<string> books)
    {
        if (books.Contains(null))
        {
            Console.WriteLine("Enter the title of the book to add:");
            string newBook = Console.ReadLine();
            int emptyIndex = books.IndexOf(null);
            books[emptyIndex] = newBook;
        }
        else
        {
            Console.WriteLine("The library is full. No more books can be added.");
        }
    }

    static void RemoveBook(List<string> books)
    {
        if (books.TrueForAll(string.IsNullOrEmpty))
        {
            Console.WriteLine("The library is empty. No books to remove.");
        }
        else
        {
            Console.WriteLine("Enter the title of the book to remove:");
            string removeBook = Console.ReadLine();

            if (books.Contains(removeBook))
            {
                int indexToRemove = books.IndexOf(removeBook);
                books[indexToRemove] = null;
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }
    }
    
    static void SearchBook(List<string> books)
    {
        Console.WriteLine("Enter the title of the book to search for:");
        string searchTitle = Console.ReadLine();

        if (books.Contains(searchTitle))
        {
            Console.WriteLine($"The book '{searchTitle}' is in the library.");
        }
        else
        {
            Console.WriteLine($"The book '{searchTitle}' was not found in the library.");
        }
    }
    
    static void BorrowBook(List<string> books, List<string> borrowedBooks)
    {
        if (borrowedBooks.Count >= 3) // Limit of 3 borrowed books
        {
            Console.WriteLine("You have reached the borrowing limit of 3 books. Please return a book before borrowing more.");
            return;
        }

        Console.WriteLine("Enter the title of the book to borrow:");
        string borrowTitle = Console.ReadLine();

        if (books.Contains(borrowTitle))
        {
            books[books.IndexOf(borrowTitle)] = null; // Remove the book from the library
            borrowedBooks.Add(borrowTitle); // Add the book to the borrowed list
            Console.WriteLine($"You have borrowed '{borrowTitle}'.");
        }
        else
        {
            Console.WriteLine("The book is not available in the library.");
        }
    }
    
    static void CheckBookStatus(Dictionary<string, bool> books)
    {
        Console.WriteLine("Enter the title of the book to check its status:");
        string checkTitle = Console.ReadLine();

        if (books.ContainsKey(checkTitle))
        {
            if (books[checkTitle])
            {
                Console.WriteLine($"The book '{checkTitle}' is currently checked out.");
            }
            else
            {
                Console.WriteLine($"The book '{checkTitle}' is available in the library.");
            }
        }
        else
        {
            Console.WriteLine("The book is not in the library.");
        }
    }

    static void DisplayBooks(List<string> books)
    {
        Console.WriteLine("Available books:");
        foreach (var book in books)
        {
            if (!string.IsNullOrEmpty(book))
            {
                Console.WriteLine(book);
            }
        }
    }
}