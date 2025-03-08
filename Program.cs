using System;

public class HelloWorld
{

    string book1;
    string book2;
    string book3;
    string book4;
    string book5;
    public static void Main(string[] args)
    {
        bool con = true;
        while (bool) {
            Console.WriteLine("1.) Add a Book");
            Console.WriteLine("2.) Remove a Book");
            Console.WriteLine("3.) Display Books");
            Console.WriteLine("4.) Exit");
            Console.WriteLine("Enter your choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice) {
                case 1:
                    addBook();
                    break;
                case 2:
                    deleteBook();
                    break;
                case 3:
                    displayBooks();
                    break;
                case 4:
                    con = false;
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }
    }

    public void addBook() {
        if (book1.Text == "") {
            Console.WriteLine("Please enter a book title: ");
            book1 = Console.ReadLine();
        } else if (book2.Text == "") {
            Console.WriteLine("Please enter a book title: ");
            book2 = Console.ReadLine();
        } else if (book3.Text == "") {
            Console.WriteLine("Please enter a book title: ");
            book3 = Console.ReadLine();
        } else if (book4.Text == "") {
            Console.WriteLine("Please enter a book title: ");
            book4 = Console.ReadLine();
        } else if (book5.Text == "") {
            Console.WriteLine("Please enter a book title: ");
            book5 = Console.ReadLine();
        } else {
            Console.WriteLine("Books are full");
        }
    }

    public void deleteBook() {
        Console.WriteLine("Enter Book Title You Want to Delete: ")
        string book = Console.ReadLine();

        if (book1.ToLower() == book.ToLower) {
            book1 = "";
        } else if (book2.ToLower() == book.ToLower) {
            book2 = "";
        } else if (book3.ToLower() == book.ToLower) {
            book3 = "";
        } else if (book4.ToLower() == book.ToLower) {
            book4 = "";
        } else if (book5.ToLower() == book.ToLower) {
            book5 = "";
        } else {
            Console.WriteLine("Book was not found!!");
        }
    }

    public void displayBooks() {
        Console.WriteLine(book1);
        Console.WriteLine(book2);
        Console.WriteLine(book3);
        Console.WriteLine(book4);
        Console.WriteLine(book5);
    }
}
