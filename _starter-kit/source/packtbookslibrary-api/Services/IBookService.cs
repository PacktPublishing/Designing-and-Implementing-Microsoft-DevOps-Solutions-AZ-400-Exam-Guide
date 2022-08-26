using packtbookslibrary.Shared.Models;
using System.Text.Json;

namespace packtbookslibrary_api.Services
{
    public interface IBookService
    {
        List<Book> GetBooksList();
    }

}
