using Microsoft.EntityFrameworkCore;
using ServerVideoAPI.Entity;

namespace ServerVideoAPI.Infra
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Server> Servers { get; set; }
        public DbSet<Video> Videos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder.Entity<Server>().HasKey(c => c.Id);
            builder.Entity<Video>().HasKey(c => c.Id);
            builder.Entity<Server>().HasMany(s => s.Videos).WithOne(v => v.Server);

            base.OnModelCreating(builder);
        }
    }
}