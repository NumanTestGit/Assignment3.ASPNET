using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Assignment3.ASPNET.Models;

namespace Assignment3.ASPNET.Data
{
    public class Assignment3ASPNETContext : DbContext
    {
        public Assignment3ASPNETContext (DbContextOptions<Assignment3ASPNETContext> options)
            : base(options)
        {
        }

        public DbSet<Assignment3.ASPNET.Models.Book> Book { get; set; } = default!;

        public DbSet<Assignment3.ASPNET.Models.Borrowing>? Borrowing { get; set; }

        public DbSet<Assignment3.ASPNET.Models.Reader>? Reader { get; set; }
    }
}
