using Microsoft.EntityFrameworkCore;
using prueba.Models;

namespace prueba.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Teach> Teaches { get; set; }
        public DbSet<Professor> Professors { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // builder.Entity<Teach>()
            //     .HasOne(t => t.ProfessorId)
            //     .WithMany(p => p.Teaches)
            //     .OnDelete(DeleteBehavior.Restrict);
        }
    }
}