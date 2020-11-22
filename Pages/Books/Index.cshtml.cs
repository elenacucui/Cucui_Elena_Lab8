using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cucui_Elena_Lab8.Data;
using Cucui_Elena_Lab8.Models;

namespace Cucui_Elena_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Cucui_Elena_Lab8.Data.Cucui_Elena_Lab8Context _context;

        public IndexModel(Cucui_Elena_Lab8.Data.Cucui_Elena_Lab8Context context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; }

        public async Task OnGetAsync()
        {
            Book = await _context.Book
                .Include(p=>p.Publisher)
                .ToListAsync();
        }
    }
}
