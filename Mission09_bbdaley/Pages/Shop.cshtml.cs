using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Mission09_bbdaley.Models;

namespace Mission09_bbdaley.Pages
{
    public class ShopModel : PageModel
    {
        private IBookstoreRepository repo { get; set; }

        public ShopModel (IBookstoreRepository temp)
        {
            repo = temp;
        }
        public Basket basket { get; set; }
        
        public void OnGet()
        {
        }

        public IActionResult OnPost(int bookid)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookid);

            basket = new Basket();
            basket.AddItem(b, 1);

            return RedirectToPage();
        }
    }
}
