using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Proiect_Mercedes.Data;
using Proiect_Mercedes.Models;

namespace Proiect_Mercedes.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly Proiect_Mercedes.Data.Proiect_MercedesContext _context;

        public IndexModel(Proiect_Mercedes.Data.Proiect_MercedesContext context)
        {
            _context = context;
        }

        [BindProperty]
        public IList<Car> Car { get; set; }

        [BindProperty]
        public string SearchString { get; set; }

        [BindProperty]
        public string SelectedState { get; set; }
        [BindProperty]
        public string SelectedCategory { get; set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car
                .Include(c => c.Category)
                .Include(c => c.Model)
                .Include(c => c.Motor)
                .Include(c => c.Transmission)
                .Include(c => c.State)
                .ToListAsync();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            IQueryable<Car> carIQ = from c in _context.Car
                                    select c;

            if (!String.IsNullOrEmpty(SearchString))
            {
                carIQ = carIQ.Where(c => c.Model.ModelName.Contains(SearchString));
            }
            if (!String.IsNullOrEmpty(SelectedState))
            {
                carIQ = carIQ.Where(c => c.State.StateType == SelectedState);
            }
            if (!String.IsNullOrEmpty(SelectedCategory))
            {
                carIQ = carIQ.Where(c => c.Category.CategoryType == SelectedCategory);
            }

            Car = await carIQ
                .Include(c => c.Category)
                .Include(c => c.Model)
                .Include(c => c.Motor)
                .Include(c => c.Transmission)
                .Include(c => c.State)
                .ToListAsync();

            return Page();
        }
    }
}