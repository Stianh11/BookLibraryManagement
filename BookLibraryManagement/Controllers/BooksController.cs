using Microsoft.AspNetCore.Mvc;
using BookLibraryManagement.Data;
using BookLibraryManagement.Models;
using Microsoft.EntityFrameworkCore;

namespace BookLibraryManagement.Controllers
{
    public class BooksController : Controller
    {
        private readonly ApplicationDbContext _context;

        public BooksController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var books = await _context.FreeEBooks.ToListAsync();
            return View(books);
        }

        // Viser skjemaet for å legge til en bok
        public IActionResult Add()
        {
            return View();
        }

        // Lagrer boken i databasen
        [HttpPost]
        public async Task<IActionResult> Add(Book book)
        {
            if (ModelState.IsValid) // Sjekker om dataene er gyldige
            {
                _context.FreeEBooks.Add(book); // Legger til boken i databasen
                await _context.SaveChangesAsync(); // Lagrer endringene

                return RedirectToAction("Index"); // Går tilbake til boklisten
            }

            return View(book);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(Guid id)
        {
            var book = await _context.FreeEBooks.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(Book book)
        {
            if (!ModelState.IsValid)
            {
                return View(book);
            }

            _context.FreeEBooks.Update(book);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> Delete(Guid id)
        {
            var book = await _context.FreeEBooks.FindAsync(id);

            if (book == null)
            {
                return NotFound();
            }

            _context.FreeEBooks.Remove(book);
            await _context.SaveChangesAsync();

            return RedirectToAction("Index");
        }
        [HttpGet]
        public async Task<IActionResult> DownloadTxt(Guid id)
        {
            var book = await _context.FreeEBooks.FindAsync(id);

            if (book == null || string.IsNullOrEmpty(book.PdfUrl))
            {
                return NotFound();
            }

            using (var httpClient = new HttpClient())
            {
                try
                {
                    // Henter innholdet fra Project Gutenberg som ren tekst
                    var txtContent = await httpClient.GetStringAsync(book.PdfUrl);
                    var bytes = System.Text.Encoding.UTF8.GetBytes(txtContent);

                    return File(bytes, "text/plain", $"{book.BookTitle}.txt");
                }
                catch (HttpRequestException)
                {
                    return NotFound();
                }
            }
        }

    }


}
