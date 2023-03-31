using System.ComponentModel.DataAnnotations;

namespace PracticaMVC.Models
{
    public class usuarios
    {
        [Key]
        public int usuario_id { get; set; }
        public string? nombre { get; set; }
        public int? documento { get; set; }
        public int? tipo { get; set; }
        public int? carnet { get; set; }
        public int carrera_id { get; set; }
    }
}
