﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Mercedes.Data;
using Proiect_Mercedes.Models;

namespace Proiect_Mercedes.Pages.Motorizations
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Mercedes.Data.Proiect_MercedesContext _context;

        public IndexModel(Proiect_Mercedes.Data.Proiect_MercedesContext context)
        {
            _context = context;
        }

        public IList<Motorization> Motorization { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Motorization = await _context.Motorization.ToListAsync();
        }
    }
}
