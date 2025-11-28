using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialAuto.Domain.Entities
{
    public class Car
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Model { get; set; }

        [Required]
        public int Year { get; set; }

        [Required]
        public double Volume { get; set; }

        [Required]
        public int Price { get; set; }

        [Required]
        public int BrandId { get; set; }

        public Brand Brand { get; set; }

        [Required]
        public int EngineTypeId { get; set; }

        public EngineType EngineType { get; set; }

        [Required]
        public int ColorId { get; set; }

        public CarColor Color { get; set; }

        public ICollection<CarImage> ImageUrls { get; set; } = new List<CarImage>();
    }
}
