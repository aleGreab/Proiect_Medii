namespace Proiect_Mercedes.Models
{
    public class Motorization
    {
        public int ID { get; set; }
        public string MotorType { get; set; }

        public ICollection<Car>? Cars { get; set; } //leg pentru cheie straina
    }
}
