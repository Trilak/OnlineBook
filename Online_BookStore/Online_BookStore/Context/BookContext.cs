using Online_BookStore.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Online_BookStore.Context
{
    public class BookContext : DbContext
    {
        public DbSet<Book> Book { get; set; }
    }
}