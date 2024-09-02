using DotNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace DotNetCore.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
            
        }
        //How to create a table by using Entity framework?:
            //From here we are creating table that's the beauty of the entity framework by migration
            // here is the first step to create a table summarizing the model:
            // First we need to create a model for now it's Category.cs file and then we have to set the validations and the primary key identity property on that model.
            // After the model creation we have to set the DBSet for that public DbSet<Category> Categories { get; set; }
            // After this we have to open the tools-->Nuget Package Manager--> Click on the Package Manager Console--> Write a command that Add-Migration
        public DbSet<Category> Categories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category { Id=1,Name="Action",DisplayOrder=1},
            new Category { Id = 2, Name = "SciFi", DisplayOrder = 2 },
            new Category { Id = 3, Name = "History", DisplayOrder = 3 } );
        }
    }
}
