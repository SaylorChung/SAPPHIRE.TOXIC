using Microsoft.Data.Entity;

namespace SAPPHIRE.TOXIC.Services.Models
{
    public class SAPPHIREDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(c => c.ID)
                .IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(c => c.Name)
                .HasMaxLength(100);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Telephone)
                .HasMaxLength(20);

            modelBuilder.Entity<Customer>()
                .Property(c => c.Address)
                .HasMaxLength(2000);

            modelBuilder.Entity<Customer>()
                .ToTable("bi_Customer");

            base.OnModelCreating(modelBuilder);
        }
    }
}
