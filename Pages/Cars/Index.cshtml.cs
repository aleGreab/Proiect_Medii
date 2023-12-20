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

        public IList<Car> Car { get; set; } = default!;
        public string SearchString { get; set; }
        public int? SelectedState { get; set; }
        public async Task OnGetAsync()
        {
            IQueryable<Car> carIQ = from c in _context.Car
                                    select c;

            if (!String.IsNullOrEmpty(SearchString))
            {
                carIQ = carIQ.Where(c => c.Model.ModelName.Contains(SearchString));
            }
            if (SelectedState.HasValue && SelectedState != 0)
            {
                carIQ = carIQ.Where(c => c.State.StateType == SelectedState.ToString());
            }

            Car = await carIQ
                .Include(c => c.Model)
                .Include(c => c.Motor)
                .Include(c => c.Transmission)
                .Include(c => c.State)
                .ToListAsync();
        }
    }
}