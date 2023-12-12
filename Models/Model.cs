namespace Proiect_Mercedes.Models
{
    public class Model
    {
        public int ID { get; set; }
        public string ModelName { get; set; }

        public ICollection<Car>? Cars { get; set; } //leg pentru cheie straina
    }
}
