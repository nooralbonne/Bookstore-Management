using Bookstore_Management.Data;
using Bookstore_Management.Models;
using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore_Management.Controllers
{
    public class BooksController : Controller
    {
        // Dependency injection for the database context
        private readonly BookstoreDbContext _context;

        public BooksController(BookstoreDbContext context)
        {
            _context = context;
        }

        //===========Index - List Books===============
        public IActionResult Index()
        {
            // Retrieve all books from the database
            var books = _context.books.ToList();
            return View(books);
        }

        //===========CreateBook===============
        public IActionResult CreateBook()
        {
            Book book = new Book();
            return View(book);
        }

        [HttpPost]
        public IActionResult CreateBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            // Add the new book to the database and save changes
            _context.books.Add(book);
            _context.SaveChanges();

            return RedirectToAction("Index");// Redirect to the list of books after successful creation
        }

        //===========EditBook===============
        public IActionResult EditBook(int Id)
        {
            var book = _context.books.Find(Id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

        [HttpPost]
        public IActionResult EditBook(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }
            // Update the book in the database and save changes
            _context.books.Update(book);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        //===========DeleteBook===============
        // GET: Books/DeleteBook/{id}
        public IActionResult DeleteBook(int id)
        {
            var book = _context.books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/DeleteBook
        [HttpPost, ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var book = _context.books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            _context.books.Remove(book);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }


        //===========DetailsBook===============
        public IActionResult DetailsBook(int id)
        {

            // Find the book by id
            var book = _context.books.Find(id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }
    }
}
