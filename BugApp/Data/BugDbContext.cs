
using Microsoft.EntityFrameworkCore;

namespace BugApp.Data
{
    public class BugDbContext : DbContext
    {
        public BugDbContext(DbContextOptions<BugDbContext> options): base(options) {}
    }
}
