using Microsoft.EntityFrameworkCore;
using Molnar_Lorand_Lab2.Models;
using System.Security.Policy;
using Publisher = Molnar_Lorand_Lab2.Models.Publisher;
using System.Collections.Generic;

namespace Molnar_Lorand_Lab2.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options) :
       base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<PublishedBook> PublishedBooks { get; set; }
        public DbSet<City> City { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>().ToTable("Customer");
            modelBuilder.Entity<Order>().ToTable("Order");
            modelBuilder.Entity<Book>().ToTable("Book");
            modelBuilder.Entity<Publisher>().ToTable("Publisher");
            modelBuilder.Entity<PublishedBook>().ToTable("PublishedBook");
            modelBuilder.Entity<City>().ToTable("City");
            modelBuilder.Entity<PublishedBook>().HasKey(c => new { c.BookID, c.PublisherID });//configureaza cheia primara compusa

        }
    }

}
