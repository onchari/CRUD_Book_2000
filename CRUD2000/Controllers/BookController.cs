using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CRUD2000.DbEntities;
using CRUD2000.Models;
using Microsoft.AspNetCore.Mvc;

namespace CRUD2000.Controllers
{
    public class BookController : Controller
    {
        private CRUDContext _context;

        public BookController(CRUDContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            IEnumerable<BookViewModel> model = _context.Set<Book>().ToList().Select(b => new BookViewModel {
                Id = b.Id,
                Name = b.Name,
                ISBN = b.ISBN,
                Author = b.Author,
                Publisher = b.Publisher
            });
            return View("Index", model);
        }
    }
}