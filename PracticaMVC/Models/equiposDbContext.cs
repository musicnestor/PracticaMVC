using Microsoft.EntityFrameworkCore;
namespace PracticaMVC.Models
{
    public class equiposDbContext:DbContext
    {
        public equiposDbContext(DbContextOptions<equiposDbContext> options) : base(options) 
        {
        }

        public DbSet<marcas> marcas { get; set; }
        public DbSet<carreras> carreras { get; set; }
        public DbSet<estados_equipo> Estados_Equipos { get; set; }
        public DbSet<estados_reserva> Estados_Reservas { get; set; }
        public DbSet<facultades> Facultades { get; set; }
        public DbSet<tipo_equipo> Tipo_Equipos { get; set; }

        public DbSet<usuarios> Usuarios { get; set; }


    }
}
