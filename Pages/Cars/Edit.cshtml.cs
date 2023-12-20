using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Proiect_Mercedes.Data;
using Proiect_Mercedes.Models;

namespace Proiect_Mercedes.Pages.Cars
{
    [Authorize(Roles = "Admin")]

    public class EditModel : PageModel
    {
        private readonly Proiect_Mercedes.Data.Proiect_MercedesContext _context;

        public EditModel(Proiect_Mercedes.Data.Proiect_MercedesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Car Car { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null || _context.Car == null)
            {
                return NotFound();
            }

            var car =  await _context.Car
                .Include(c => c.Model)
                .Include(c => c.Motor)
                .Include(c => c.Transmission)
                .Include(c => c.State)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (car == null)
            {
                return NotFound();
            }
            Car = car;

            ViewData["CarModelID"] = new SelectList(_context.Set<Model_Car>(), "ID", "ModelName");
            ViewData["CarMotorID"] = new SelectList(_context.Set<Motorization>(), "ID", "MotorType");
            ViewData["CarTransID"] = new SelectList(_context.Set<Transmission>(), "ID", "TransmissionType");
            ViewData["CarStateID"] = new SelectList(_context.Set<State>(), "ID", "StateType");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }



            _context.Attach(Car).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CarExists(Car.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool CarExists(int id)
        {
            return (_context.Car?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
