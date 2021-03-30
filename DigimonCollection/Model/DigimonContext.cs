using Microsoft.EntityFrameworkCore;

namespace DigimonCollection.Model
{
    public class DigimonContext : DbContext
    {
        public DbSet<Set> Sets { get; }
        public DbSet<Card> Cards { get; }
        public DbSet<Printing> Printings { get; set; }

        public DigimonContext(DbContextOptions<DigimonContext> options)
            : base(options)
        {
        }
    }
}
