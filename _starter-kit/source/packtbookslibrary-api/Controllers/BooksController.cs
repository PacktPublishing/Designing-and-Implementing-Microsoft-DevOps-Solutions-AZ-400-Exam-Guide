using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using packtbookslibrary.Shared.Models;
using packtbookslibrary_api.Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace packtbookslibrary_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {

        private readonly IBookService bookService;

        List<Book> books = new List<Book>();

        public BooksController(IBookService bookService)
        {
            this.bookService = bookService;
            books = bookService.GetBooksList();
            //string jsonString = System.IO.File.ReadAllText("books-data.json");
            //books = JsonSerializer.Deserialize<List<Book>>(jsonString); 
        }

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<Book> Get()
        {
            return books;
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            try
            {
                List<Book> booksList = books;
                Book? book = booksList.FirstOrDefault(c => c.Id == id);
                if (book == null)
                    return Ok(new Book());
                return Ok(book);
            }
            catch (Exception ex)
            {
                return new JsonResult("No Records found. Internal Server Error");
            }
        }

        //// POST api/<BooksController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<BooksController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<BooksController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
