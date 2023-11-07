using System.ComponentModel.DataAnnotations;

namespace MagicVilla_API.Models.Dto
{
    public class VillaCreateDto
    {

        public string Nombre { get; set; }

        public string Detalles { get; set; }

        public double Tarifa { get; set; }

        public int Ocupantes { get; set; }

        public double MetrosCuadrados { get; set; }

        public string ImagenUrl { get; set; }

        public string Amenidad { get; set; }

    }
}
