using Microsoft.EntityFrameworkCore;

namespace OrderApi.Models
{
    public class OrderContext : DbContext
    {
        public OrderContext(DbContextOptions<OrderContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Order> Orders {get; set;}
        public DbSet<Item> Items{get; set;}
    }
}