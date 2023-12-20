using System.ComponentModel;

namespace Proiect_Mercedes.Models
{
    public class State
    {
        public int ID { get; set; }
        [DisplayName("State")]
        public string StateType { get; set; }

        public ICollection<Car>? Cars { get; set; } //leg pentru cheie straina
    }
}
