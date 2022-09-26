using Microsoft.EntityFrameworkCore;
using PYP_CachingApp.Models;

namespace PYP_CachingApp.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options){}
        public DbSet<Product> Products { get; set; }=null!;
    }
}
