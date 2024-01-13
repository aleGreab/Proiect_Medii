using Microsoft.AspNetCore.Mvc.RazorPages;
using Proiect_Mercedes.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Proiect_Mercedes.Data;

namespace Proiect_Mercedes.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly Proiect_MercedesContext _context; 

        public List<Car> Cars { get; set; } 

        public IndexModel(ILogger<IndexModel> logger, Proiect_MercedesContext context)
        {
            _logger = logger;
            _context = context;
        }

        public async Task OnGetAsync()
        {
            Cars = await _context.Car
                .Include(c => c.Category)
                .Include(c => c.Model)
                .Include(c => c.Motor)
                .Include(c => c.Transmission)
                .Include(c => c.State)
                .ToListAsync();
        }
    }
}
