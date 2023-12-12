namespace Proiect_Mercedes.Models
{
    public class State
    {
        public int ID { get; set; }
        public string StateType { get; set; }

        public ICollection<Car>? Cars { get; set; } //leg pentru cheie straina
    }
}
