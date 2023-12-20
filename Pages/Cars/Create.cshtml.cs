using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Proiect_Mercedes.Data;
using Proiect_Mercedes.Models;

namespace Proiect_Mercedes.Pages.Cars
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
            ViewData["CarModelID"] = new SelectList(_context.Set<Model_Car>(), "ID", "ModelName");
            ViewData["CarMotorID"] = new SelectList(_context.Set<Motorization>(), "ID", "MotorType");
            ViewData["CarTransID"] = new SelectList(_context.Set<Transmission>(), "ID", "TransmissionType");
            ViewData["CarStateID"] = new SelectList(_context.Set<State>(), "ID", "StateType");
            return Page();
        }

        [BindProperty]
        public Car Car { get; set; } = default!;

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Car.Add(Car);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}