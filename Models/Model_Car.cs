using System.ComponentModel;

namespace Proiect_Mercedes.Models
{
    public class Model_Car
    {
        public int ID { get; set; }
        [DisplayName("Model")]
        public string ModelName { get; set; }

        public ICollection<Car>? Cars { get; set; } //leg pentru cheie straina
    }
}
