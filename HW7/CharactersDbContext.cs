using HW7.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HW7
{
    class CharactersDbContext : DbContext
    {
        public DbSet<Character> Characters { get; set; }
        public DbSet<Story> Stories { get; set; }
        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("CharactersConnectionString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { Id = 1, FirstName = "Isaak", LastName = "Azimov", Birthday = new System.DateTime(1920,2,1), Description = "" },
                new Author { Id = 2, FirstName = "John R. R.", LastName = "Tolkien", Birthday = new System.DateTime(1892,01,03), Description = "" },
                new Author { Id = 3, FirstName = "George", LastName = "Lucas", Birthday = new System.DateTime(1944,05,14), Description = "Американский кинопродюсер" });

            modelBuilder.Entity<Character>().Property(c => c.FirstName).IsRequired();
            modelBuilder.Entity<Character>().Property(c => c.LastName).IsRequired();

            modelBuilder.Entity<Character>().Property(c => c.FirstName).HasMaxLength(255);
            modelBuilder.Entity<Character>().Property(c => c.LastName).HasMaxLength(255);
        }
    }
}
