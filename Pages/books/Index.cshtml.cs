﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Ardelean_Sebastian_Laborator2.Data;
using Ardelean_Sebastian_Laborator2.Models;

namespace Ardelean_Sebastian_Laborator2.Pages.books
{
    public class IndexModel : PageModel
    {
        private readonly Ardelean_Sebastian_Laborator2.Data.Ardelean_Sebastian_Laborator2Context _context;

        public IndexModel(Ardelean_Sebastian_Laborator2.Data.Ardelean_Sebastian_Laborator2Context context)
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