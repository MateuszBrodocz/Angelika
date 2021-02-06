using Codecool.OnlineStore.Models;
using Microsoft.EntityFrameworkCore;

namespace Codecool.OnlineStore.DAL
{
    public class AllegrettoContext : DbContext
    {
        public DbSet<BasketItem> BasketItems { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Customer> Customers { get; set; }

        public DbSet<Discount> Discounts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Statistic> Statistics { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Allegretto");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .Property(customer => customer.IndividualDiscount)
                .HasDefaultValueSql("0");

            modelBuilder.Entity<Order>()
                .Property(order => order.CreateDate)
                .HasDefaultValueSql("getdate()");

            modelBuilder.Entity<Statistic>()
                .Property(statistic => statistic.StatisticDate)
                .HasDefaultValueSql("getdate()");
            Seed(modelBuilder);
        }

        private static void Seed(ModelBuilder modelBuilder)
        {
            var countries = System.IO.File.ReadAllLines(@"Models\Data\countries_europe.txt");

            int counter = 1;
            foreach (var country in countries)
            {
                modelBuilder.Entity<Country>().HasData(new Country { CountryId = counter, CountryName = country });
                counter++;
            }
        }
    }
}
