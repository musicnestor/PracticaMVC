using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class carreras
    {
        [Key]

        public int carreras_id { get; set; }
        public string? nombre_carrera { get; set; }
        public int? facultad_id { get; set; }
    }
}
