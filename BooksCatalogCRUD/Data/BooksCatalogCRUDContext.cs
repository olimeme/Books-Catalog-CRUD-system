using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BooksCatalogCRUD.Models
{
    public class BooksCatalogCRUDContext : DbContext
    {
        public BooksCatalogCRUDContext (DbContextOptions<BooksCatalogCRUDContext> options)
            : base(options)
        {
        }

        public DbSet<BooksCatalogCRUD.Models.Book> Book { get; set; }
    }
}
