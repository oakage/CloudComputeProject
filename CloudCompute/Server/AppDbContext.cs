using Microsoft.EntityFrameworkCore;
using CloudCompute.Shared;

namespace CloudCompute.Server
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<CDs> cds { get; set; }
    }
}
