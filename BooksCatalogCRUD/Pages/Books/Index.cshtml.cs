using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BooksCatalogCRUD.Models;

namespace BooksCatalogCRUD.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BooksCatalogCRUD.Models.BooksCatalogCRUDContext _context;

        public IndexModel(BooksCatalogCRUD.Models.BooksCatalogCRUDContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
