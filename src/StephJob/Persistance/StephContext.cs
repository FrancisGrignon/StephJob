namespace StephJob.Persistance
{
    using Microsoft.EntityFrameworkCore;
    using StephJob.Core.Domain;

    public class StephContext : DbContext
    {
        public StephContext() : base()
        {
            // Empty
        }

        public StephContext(DbContextOptions<StephContext> options)
            : base(options)
        {
        }

        public DbSet<Sdgs372> Sdgs372s { get; set; }

        public DbSet<Sdgs411> Sdgs411s { get; set; }

        public DbSet<Sdgs431> Sdgs431s { get; set; }

        public DbSet<Sdgs441> Sdgs441s { get; set; }

        public DbSet<Sdgs531> Sdgs531s { get; set; }

        public DbSet<Sdgs861> Sdgs861s { get; set; }
    }
}
