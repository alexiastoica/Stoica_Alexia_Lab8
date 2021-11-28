﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Stoica_Alexia_Lab8.Data;
using Stoica_Alexia_Lab8.Models;

namespace Stoica_Alexia_Lab8.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly Stoica_Alexia_Lab8.Data.Stoica_Alexia_Lab8Context _context;

        public IndexModel(Stoica_Alexia_Lab8.Data.Stoica_Alexia_Lab8Context context)
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
