
using API.Entity;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options)
       : base(options)
    {
    }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<Product>().HasData(
          new List<Product>
          {
            new Product{Id=1, Name="Iphone16", Description="Telefon Acikla", ImageUrl="1.jpg", Price=1600, IsActive=true, Stock=100},
            new Product{Id=2, Name="Iphone17", Description="Telefon Acikla", ImageUrl="2.jpg", Price=1700, IsActive=true, Stock=100},
            new Product{Id=3, Name="Iphone11", Description="Telefon Acikla", ImageUrl="3.jpg", Price=1100, IsActive=false, Stock=100},
            new Product{Id=4, Name="Iphone15", Description="Telefon Acikla", ImageUrl="4.jpg", Price=1500, IsActive=true, Stock=100},
            new Product{Id=5, Name="Iphone13", Description="Telefon Acikla", ImageUrl="5.jpg", Price=1300, IsActive=true, Stock=100}
          }
        );
    }

}