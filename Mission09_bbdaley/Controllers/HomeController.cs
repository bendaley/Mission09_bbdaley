using Microsoft.AspNetCore.Mvc;
using Mission09_bbdaley.Models;
using Mission09_bbdaley.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_bbdaley.Controllers
{
    public class HomeController : Controller
    {
        // private BookstoreContext context { get; set; }

        // public HomeController(BookstoreContext temp) => context = temp;

        private IBookstoreRepository repo;

        public HomeController (IBookstoreRepository temp)
        {
            repo = temp;
        }

        // old - just referencing for notes

        /*
        public IActionResult Index()
        {
            var home = context.Books.ToList();

            return View(home);
        }
        */

        // set-up everything to receive needed variables to determine page number/display
        public IActionResult Index(string category, int pageNum = 1)
        {
            int pageSize = 10;

            var booksbaby = new BooksViewModel
            {
                Books = repo.Books
                .Where(b => b.Category == category || category == null)
                .OrderBy(b => b.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PageInfo = new PageInfo
                {
                    TotalNumBooks = 
                        (category == null 
                            ? repo.Books.Count()
                            : repo.Books.Where(x => x.Category == category).Count()),
                    BooksPerPage = pageSize,
                    CurrentPage = pageNum
                }
            };

            return View(booksbaby);
        }
    }
}
