using HireLog.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace HireLog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Application> Applications { get; set; }
    }
}