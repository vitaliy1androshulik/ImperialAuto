using ImperialAuto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialAuto.Infrastructure.Seeder
{
    public class ColorSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CarColor>().HasData(
                new CarColor { Id = 1, Color = "Чорний" },
                new CarColor { Id = 2, Color = "Білий" },
                new CarColor { Id = 3, Color = "Сірий" },
                new CarColor { Id = 4, Color = "Жовтий" },
                new CarColor { Id = 5, Color = "Червоний" },
                new CarColor { Id = 6, Color = "Синій" },
                new CarColor { Id = 7, Color = "Темно-синій" },
                new CarColor { Id = 8, Color = "Зелений" },
                new CarColor { Id = 9, Color = "Фіолетовий" },
                new CarColor { Id = 10, Color = "Помаранчевий" }     
            );
        }
    }
}
