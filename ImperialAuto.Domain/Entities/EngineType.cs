using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialAuto.Domain.Entities
{
    public class EngineType
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FuelType { get; set; }

        
        public ICollection<Car> Cars { get; set; } = new List<Car>();

    }
}
