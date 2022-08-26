using packtbookslibrary.Shared.Models;
using packtbookslibrary_api.Controllers;
using packtbookslibrary_api.Models;
using System.Net.NetworkInformation;
using System.Text.Json;

namespace packtbookslibrary_api
{
    public class DataHelper
    {
        static IEnumerable<Book> GetBooks()
        {
            List<Book> books = new List<Book>();
            return books;
        }
    }
}
