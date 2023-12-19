using SQLite;
namespace Proiect_Mercedes.Models
{
    public class Car
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Photo { get; set; }
        public int? CarModelID { get; set; }
        public Model_Car? Model { get; set; } //leg pentru cheie straina
        public int? CarMotorID { get; set; }
        public Motorization? Motor { get; set; }
        public int? CarTransID { get; set; }
        public Transmission? Transmission { get; set; }
        public int? CarStateID { get; set; }
        public State? State { get; set; }
        
        public string ManufacturingYear { get; set; } //punem string ca sa introducem noi anul 
        public string Feature { get; set; }

    }
}
