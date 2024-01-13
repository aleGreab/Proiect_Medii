using Microsoft.AspNetCore.Identity;

namespace Proiect_Mercedes.Models
{
    public class Wishlist
    {
        public int ID { get; set; }
        public string UserID { get; set; }
        public virtual IdentityUser User { get; set; } = default!;
        public int CarID { get; set; }
        public virtual Car Car { get; set; } = default!; 
    }
}
