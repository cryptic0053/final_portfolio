using final_portfolio.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace final_portfolio.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Skill>().HasData(
                new Skill { Id = 1, Name = "Action", Level = 50 },
                new Skill { Id = 2, Name = "SciFi", Level = 2 }
                );

            modelBuilder.Entity<Contact>().HasData(
                new Contact { Id = 1, Name = "Iqbal Mahamud", Email = "moon2007093@stud.kuet.ac.bd", Message = "Hello How is it going" }
                );
        }
    }
}
