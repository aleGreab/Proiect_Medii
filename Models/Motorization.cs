using System.ComponentModel;

namespace Proiect_Mercedes.Models
{
    public class Motorization
    {
        public int ID { get; set; }
        [DisplayName("Motorization")]
        public string MotorType { get; set; }

        public ICollection<Car>? Cars { get; set; } //leg pentru cheie straina
    }
}
