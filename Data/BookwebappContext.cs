using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Bookwebapp.Model;

namespace Bookwebapp.Data
{
    public class BookwebappContext : DbContext
    {
        public BookwebappContext (DbContextOptions<BookwebappContext> options)
            : base(options)
        {
        }

        public DbSet<Bookwebapp.Model.Book> Book { get; set; } = default!;
    }
}
