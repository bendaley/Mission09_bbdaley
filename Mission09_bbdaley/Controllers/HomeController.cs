﻿using Microsoft.AspNetCore.Mvc;
using Mission09_bbdaley.Models;
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

        /*
        public IActionResult Index()
        {
            var home = context.Books.ToList();

            return View(home);
        }
        */

        public IActionResult Index(int pageNum = 1)
        {
            int pageSize = 5;

            var home = repo.Books
                .OrderBy(b => b.Title)
                .Skip((pageNum -1) * pageSize)
                .Take(pageSize);

            return View(home);
        }
    }
}
