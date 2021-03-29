using Microsoft.EntityFrameworkCore;

namespace DigimonCollection.Model
{
    public class DigimonContext : DbContext
    {
        public DigimonContext(DbContextOptions<DigimonContext> options)
            : base(options)
        {
        }
    }
}
