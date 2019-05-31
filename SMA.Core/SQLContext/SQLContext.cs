using Microsoft.EntityFrameworkCore;
using SMA.Core.Entities;

namespace SMA.Core.SQLContext
{
    public class SQLContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=SchoolDB;Trusted_Connection=True;");
        }

        #region DBset
        DbSet<Customer> Customers { get; set; }
        DbSet<Vendor> Vendors { get; set; }
        DbSet<Manager> Managers { get; set; }
        DbSet<Item> Items { get; set; }
        DbSet<ItemCart> ItemCarts { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<Service> Services { get; set; }
        DbSet<ServiceCart> ServiceCarts { get; set; }
        DbSet<Stock> Stocks { get; set; }
        DbSet<User> Users { get; set; }
        DbSet<UserRole> UserRoles { get; set; }
        DbSet<Role> Roles { get; set; }

        #endregion
    }
}
