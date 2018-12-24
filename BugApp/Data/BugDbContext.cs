
using BugPages.Models;
using Microsoft.EntityFrameworkCore;

namespace BugApp.Data
{
    public class BugDbContext : DbContext
    {
        public BugDbContext(DbContextOptions<BugDbContext> options): base(options) {}
        public DbSet<Bug> Bugs { get; set; }
    }
}
