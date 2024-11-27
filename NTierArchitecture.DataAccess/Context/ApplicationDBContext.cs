using Microsoft.EntityFrameworkCore;
using NTierArchitecture.Entities.Models;

namespace NTierArchitecture.DataAccess.Context
{
    public class ApplicationDBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Category> Categories { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=.;Initial Catalog=NTIREARCHITECTUREDB;Integrated Security=True;Trust Server Certificate=True;User Id=Admin;Password=n^9Fu:,ek?$Wg01sU$I}6N9%)#JIQX8g");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //DB Tablolarımız oluşuturulurken onlara müdahele edebiliriz.
            //OrderDetail tablosunun ID alanını iptal edeceğiz;
            modelBuilder.Entity<OrderDetail>().Ignore(X => X.ID);
            //Bunun yerine ProductID ve OrderID alanlarını Composite Key yapacağız:
            modelBuilder.Entity<OrderDetail>().HasKey(X => new { X.OrderID, X.ProductID });
        }
    }
}
