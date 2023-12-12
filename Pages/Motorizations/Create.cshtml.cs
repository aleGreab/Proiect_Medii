﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Mercedes.Data;
using Proiect_Mercedes.Models;

namespace Proiect_Mercedes.Pages.Motorizations
{
    public class CreateModel : PageModel
    {
        private readonly Proiect_Mercedes.Data.Proiect_MercedesContext _context;

        public CreateModel(Proiect_Mercedes.Data.Proiect_MercedesContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Motorization Motorization { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Motorization.Add(Motorization);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
