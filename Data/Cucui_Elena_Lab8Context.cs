using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cucui_Elena_Lab8.Models;

namespace Cucui_Elena_Lab8.Data
{
    public class Cucui_Elena_Lab8Context : DbContext
    {
        public Cucui_Elena_Lab8Context (DbContextOptions<Cucui_Elena_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Cucui_Elena_Lab8.Models.Book> Book { get; set; }

        public DbSet<Cucui_Elena_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Cucui_Elena_Lab8.Models.Category> Category { get; set; }
    }
}
