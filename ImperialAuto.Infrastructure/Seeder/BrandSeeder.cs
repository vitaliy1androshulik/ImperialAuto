using ImperialAuto.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialAuto.Infrastructure.Seeder
{
    public class BrandSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Brand>().HasData(
                new Brand { Id = 1, Name = "Toyota" ,LogoUrl="Images/toyota.png"}
            );
        }
    }
}
