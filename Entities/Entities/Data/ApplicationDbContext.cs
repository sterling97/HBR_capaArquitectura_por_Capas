using Entities.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Entities.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ProductEntity>? Products { get; set; }
        public DbSet<CategoryEntity>? Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                options.UseSqlServer("Server=DESKTOP-07GPHH6; Database=CrudInventory; Trusted_Connection=True; User Id=sa; Password=123456789");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<CategoryEntity>().HasData(
                new CategoryEntity { CategoryId = "ASH", CategoryName = "Aseo Hogar" },
                new CategoryEntity { CategoryId = "IT", CategoryName = "Tecnologia" },
                new CategoryEntity { CategoryId = "PRF", CategoryName = "Perfumeria" },
                new CategoryEntity { CategoryId = "VD", CategoryName = "Video Juegos" }
                );
        }

    }
}

