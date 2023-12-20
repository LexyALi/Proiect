using Microsoft.Data.Sqlite;
using Proiect;
using System;

public class AddBook : Book
{
    private string connectionString;

    public AddBook(string connectionString)
    {
        this.connectionString = connectionString;
    }

    public void InitializeDatabase()
    {
        using (SqliteConnection conn = new SqliteConnection(connectionString))
        {
            conn.Open();
            using (SqliteCommand cmd = new SqliteCommand("CREATE TABLE IF NOT EXISTS books (id INTEGER PRIMARY KEY AUTOINCREMENT, Title TEXT, Author TEXT, ReturnDate TEXT, Status BIT)", conn))
            {
                cmd.ExecuteNonQuery();
            }
        }
    }
    
    protected void InsertNewBook(string title, string author, string returnDate, bool status)
    {
        using (SqliteConnection conn = new SqliteConnection(connectionString))
        {
            conn.Open();

            using (SqliteCommand cmd = new SqliteCommand("INSERT INTO books (Title, Author, ReturnDate, Status) VALUES (@title, @author, @returnDate, @status)", conn))
            {
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@returnDate", returnDate);
                cmd.Parameters.AddWithValue("@status", status ? 1 : 0);
                cmd.ExecuteNonQuery();
            }
        }
    }

    public Book GetBookById(int bookId)
    {
        using (SqliteConnection conn = new SqliteConnection(connectionString))
        {
            conn.Open();

            using (SqliteCommand cmd = new SqliteCommand("SELECT * FROM books WHERE id=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", bookId);

                using (SqliteDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Book
                        {
                            Id = Convert.ToInt32(reader["id"]),
                            Title = Convert.ToString(reader["Title"]),
                            Author = Convert.ToString(reader["Author"]),
                            ReturnDate = Convert.ToString(reader["ReturnDate"]),
                            Status = Convert.ToBoolean(reader["Status"])
                        };
                    }
                    else
                    {
                        return null;
                    }
                }
            }
        }
    }

    public void DeleteBook(int bookId)
    {
        using (SqliteConnection conn = new SqliteConnection(connectionString))
        {
            conn.Open();
            
            using (SqliteCommand cmd = new SqliteCommand("DELETE FROM books WHERE id=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", bookId);
                cmd.ExecuteNonQuery();
            }
        }
    }


}
