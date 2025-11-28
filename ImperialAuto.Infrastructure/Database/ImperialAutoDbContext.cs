using ImperialAuto.Domain.Entities;
using ImperialAuto.Infrastructure.Seeder;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImperialAuto.Infrastructure.Database
{
    public class ImperialAutoDbContext:DbContext
    {
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<CarColor> CarColors { get; set; }
        public DbSet<CarImage> CarImages { get; set; }
        public DbSet<EngineType> EngineTypes { get; set; }
        public DbSet<User> Users { get; set; }

        public ImperialAutoDbContext(DbContextOptions<ImperialAutoDbContext> options)
        : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Brand)
                .WithMany(b => b.Cars)
                .HasForeignKey(c => c.BrandId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Car>()
                .HasOne(c => c.EngineType)
                .WithMany(e => e.Cars)
                .HasForeignKey(c => c.EngineTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Color)
                .WithMany(cl => cl.Cars)
                .HasForeignKey(c => c.ColorId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<CarImage>()
                .HasOne(ci => ci.Car)
                .WithMany(c => c.ImageUrls)
                .HasForeignKey(ci => ci.CarId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<User>()
                .Property(u => u.Role)
                .HasDefaultValue(UserRole.User);

            ColorSeeder.Seed(modelBuilder);
            BrandSeeder.Seed(modelBuilder);
            EngineTypeSeeder.Seed(modelBuilder);
        }
    }
}
