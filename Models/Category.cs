using System.ComponentModel;

namespace Proiect_Mercedes.Models
{
    public class Category
    {
        public int ID { get; set; }
        [DisplayName("Category")]
        public string CategoryType { get; set; }

        public ICollection<Car>? Cars { get; set; } //leg pentru cheie straina
    }
}
