using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Proiect_Mercedes.Models
{
    public class Car
    {

        public int ID { get; set; }

        [Required]
        [DataType(DataType.ImageUrl)]
        public string Photo { get; set; }

        [Required]
        public int? CarModelID { get; set; } //leg pentru cheie straina

        [ForeignKey("CarModelID")]
        
        public Model_Car? Model { get; set; }

        [Required]
        public int? CarMotorID { get; set; }

        [ForeignKey("CarMotorID")]
        
        public Motorization? Motor { get; set; }
        [Required]
        public int? CarTransID { get; set; }

        [ForeignKey("CarTransID")]
        
        public Transmission? Transmission { get; set; }
        [Required]
        public int? CarStateID { get; set; }

        [ForeignKey("CarStateID")]
       
        public State? State { get; set; }

        [Required]
        [DisplayName("Manufacturing Year")]
        public string ManufacturingYear { get; set; }

        //[StringLength(100)]
        [DisplayName("Features")]
        public string Feature { get; set; }

       
    }
}
