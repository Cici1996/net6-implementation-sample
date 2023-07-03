using EventAgenda.DataAccess.Configurations;
using EventAgenda.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace EventAgenda.DataAccess
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new EventConfiguration());
        }

        public DbSet<Event> Events { get; set; }
    }
}