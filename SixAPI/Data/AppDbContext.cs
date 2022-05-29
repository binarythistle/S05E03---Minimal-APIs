using Microsoft.EntityFrameworkCore;
using SixAPI.Models;

namespace SixAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
            
        }

        public DbSet<Command> Commands => Set<Command>();
        public DbSet<Platform> Platforms => Set<Platform>();
    }
}