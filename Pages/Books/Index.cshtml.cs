using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Bookwebapp.Data;
using Bookwebapp.Model;

namespace Bookwebapp.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Bookwebapp.Data.BookwebappContext _context;

        public IndexModel(Bookwebapp.Data.BookwebappContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Book = await _context.Book.ToListAsync();
        }
    }
}
