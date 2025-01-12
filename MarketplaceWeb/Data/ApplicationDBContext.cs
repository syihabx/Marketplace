using MarketplaceWeb.Models;
using MarketplaceWeb.Models.Base;
using Microsoft.EntityFrameworkCore;

namespace BulkyWeb.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        // DbSet untuk model CreateTableTest
        public DbSet<CreateTableTest> CreateTableTest { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<CreateTableTest>().HasData(
                new CreateTableTest { Id = -1, Name = "Test 1", Description = "Description 1", Type = "Type 1", CreatedBy = "Admin" },
                new CreateTableTest { Id = -2, Name = "Test 2", Description = "Description 2", Type = "Type 2", CreatedBy = "Admin" },
                new CreateTableTest { Id = -3, Name = "Test 3", Description = "Description 3", Type = "Type 3", CreatedBy = "Admin" }
               );

        }
    }
}