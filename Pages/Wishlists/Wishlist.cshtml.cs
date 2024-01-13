using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity; // Add this namespace
using Proiect_Mercedes.Data;
using Proiect_Mercedes.Models;

namespace Proiect_Mercedes.Pages.Wishlists
{
    public class WishlistModel : PageModel
    {
        private readonly Proiect_MercedesContext _context;
        private readonly UserManager<IdentityUser> _userManager;

        public WishlistModel(Proiect_MercedesContext context, UserManager<IdentityUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public IList<Wishlist> Wishlist { get; set; } = default!;

        public async Task OnGetAsync()
        {
            var currentUser = await _userManager.GetUserAsync(User);

            if (currentUser != null)
            {
                Wishlist = await _context.Wishlist
                    .Where(w => w.UserID == currentUser.Id)
                    .Include(w => w.User)
                    .ToListAsync();
            }
            else
            {
                Wishlist = new List<Wishlist>();
            }
        }
    }
}
