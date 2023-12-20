using System.ComponentModel;

namespace Proiect_Mercedes.Models
{
    public class Transmission
    {
        public int ID { get; set; }
        [DisplayName("Transmission")]
        public string TransmissionType { get; set; }

        public ICollection<Car>? Cars { get; set; } //leg pentru cheie straina
    }
}
