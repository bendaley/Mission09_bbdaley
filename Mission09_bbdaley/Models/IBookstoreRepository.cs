using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission09_bbdaley.Models
{
    // set-up i-bookstore repository
    public interface IBookstoreRepository
    {
        IQueryable<Book> Books { get;}
    }
}
