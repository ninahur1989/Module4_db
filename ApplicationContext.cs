using Microsoft.EntityFrameworkCore;

namespace Module4_db
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Song> Songs { get; set; }

        public DbSet<Artist> Artists { get; set; }

        public DbSet<Genre> Genres { get; set; }

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }


    }
}
