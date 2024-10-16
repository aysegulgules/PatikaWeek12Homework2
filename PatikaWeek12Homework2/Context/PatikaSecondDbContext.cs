using Microsoft.EntityFrameworkCore;
using PatikaWeek12Homework2.Entities;

namespace PatikaWeek12Homework2.Context
{
    public class PatikaSecondDbContext:DbContext
    {
        public DbSet<PostEntity> Posts { get; set; }
        public DbSet<UserEntity> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"server=LAPTOP-748G4HT2;database=PatikaCodeFirstDb2;Trusted_Connection=true;TrustServerCertificate=true");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<PostEntity>()
                .HasOne(b => b.User)      
                .WithMany(a => a.Posts)     
                .HasForeignKey(b => b.UserId); 
        }
    }
}
