using Microsoft.EntityFrameworkCore;

namespace DigimonCollection.Model
{
    public class DigimonContext : DbContext
    {
        public DbSet<Set> Sets { get; set; }
        public DbSet<Card> Cards { get; set; }
        public DbSet<Printing> Printings { get; set; }
        public DbSet<User> Users { get; set; }

        public DigimonContext(DbContextOptions<DigimonContext> options)
            : base(options)
        {
        }
    }
}
