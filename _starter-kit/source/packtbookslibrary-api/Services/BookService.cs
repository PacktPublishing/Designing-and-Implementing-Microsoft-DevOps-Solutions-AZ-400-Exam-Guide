using packtbookslibrary.Shared.Models;
using System.Text.Json;

namespace packtbookslibrary_api.Services
{
    public class BookService : IBookService
    {
        List<Book> IBookService.GetBooksList()
        {
            List<Book> books = new List<Book>();
            string jsonString = System.IO.File.ReadAllText("books-data.json");
            books = JsonSerializer.Deserialize<List<Book>>(jsonString);
            return books;
        }
    }
}
