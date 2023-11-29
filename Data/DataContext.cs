using ConsumerRab.Model;
using MassTransit;
using Microsoft.EntityFrameworkCore;

namespace ConsumerRab.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<ProductList> productList { get; set; }
    }
}
