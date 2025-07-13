using HireLog.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace HireLog.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        
        public DbSet<Job> Jobs { get; set; }
    }
}