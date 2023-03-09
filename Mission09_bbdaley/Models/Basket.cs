﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// basket class to be able to add up prices/quantities of the books

namespace Mission09_bbdaley.Models
{
    public class Basket
    {
        public List<BasketLineItem> Items { get; set; } = new List<BasketLineItem>();

        public void AddItem (Book bookbook, int qty)
        {
            BasketLineItem line = Items
                .Where(b => b.Book.BookId == bookbook.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                Items.Add(new BasketLineItem
                {
                    Book = bookbook,
                    Quantity = qty
                });
            }
            else
            {
                line.Quantity += qty;
            }
        }

        public double CalculateTotal()
        {
            double sum = Items.Sum(x => x.Quantity * x.Book.Price);

            return sum;
        }
    }


    public class BasketLineItem
    {
        public int LineID { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }
}
