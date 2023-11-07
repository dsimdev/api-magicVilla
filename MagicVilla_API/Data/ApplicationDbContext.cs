using MagicVilla_API.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_API.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Villa> Villas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Villa>().HasData(
                new Villa()
                {
                    Id = 1,
                    Nombre = "Villa 1",
                    Detalles = "Detalles de la villa 1",
                    Ocupantes = 5,
                    MetrosCuadrados = 150.5,
                    Tarifa = 1500.50,
                    Amenidad = "",
                    ImagenUrl = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                },
                new Villa()
                {
                    Id = 2,
                    Nombre = "Villa 2",
                    Detalles = "Detalles de la villa 2",
                    Ocupantes = 15,
                    MetrosCuadrados = 1540.5,
                    Tarifa = 10500.50,
                    Amenidad = "",
                    ImagenUrl = "",
                    FechaCreacion = DateTime.Now,
                    FechaActualizacion = DateTime.Now
                }
            );
        }

    }
}
