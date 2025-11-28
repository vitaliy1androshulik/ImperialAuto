using ImperialAuto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialAuto.Infrastructure.Seeder
{
    public class EngineTypeSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EngineType>().HasData(
                new EngineType { Id = 1, FuelType = "Бензин" },
                new EngineType { Id = 2, FuelType = "Дизель" },
                new EngineType { Id = 3, FuelType = "Бензин/Газ" },
                new EngineType { Id = 4, FuelType = "Гібрид (Бензин/Електро)" },
                new EngineType { Id = 5, FuelType = "Електро" }
            );
        }
    }
}
