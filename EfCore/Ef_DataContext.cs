using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace Hplus.EfCore
{
    public class Ef_DataContext : DbContext
    {
        public Ef_DataContext(DbContextOptions<Ef_DataContext> options) : base(options) { }

        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
