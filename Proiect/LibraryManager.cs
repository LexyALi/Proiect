using System;

public class LibraryManager  : AddBook
{


    public LibraryManager(string connectionString) : base(connectionString)
    {

    }

    public void AddNewBook(string title, string author, string returnDate, bool status)
    {
        InsertNewBook(title, author, returnDate, status);
    }
}
