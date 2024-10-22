using Microsoft.EntityFrameworkCore;
using Web.Entities;

namespace Web.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public ApplicationContext(DbContextOptions <ApplicationContext> options) : base(options) { }
    }
}
