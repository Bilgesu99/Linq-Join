using Linq_Join;
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        // Yazarlar tablosu verileri oluşturuyorum önce 
        List<Author> authors = new List<Author>
        {
            new Author { AuthorId = 1, Name = "J.K. Rowling" },
            new Author { AuthorId = 2, Name = "George R.R. Martin" },
            new Author { AuthorId = 3, Name = "J.R.R. Tolkien" }
             };

        // Kitaplar tablosu verileri oluşturdum.
        List<Book> books = new List<Book>
        {
            new Book { BookId = 1, Title = "Harry Potter and the Sorcerer's Stone", AuthorId = 1 },
            new Book { BookId = 2, Title = "A Game of Thrones", AuthorId = 2 },
            new Book { BookId = 3, Title = "The Hobbit", AuthorId = 3 },
            new Book { BookId = 4, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 1 }
        };

        // Kitapları ve yazarları birleştirme
        var query = from book in books
                    join author in authors on book.AuthorId equals author.AuthorId
                    select new { book.Title, author.Name };


        // Sonuçları ekrana yazdırma
        foreach (var item in query)
        {
            Console.WriteLine($"Kitap: {item.Title}, Yazar: {item.Name}");
        }
    }
}