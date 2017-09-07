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

        public DbSet<EmploymentAveWeekEarning> EmploymentAveWeekEarnings { get; set; }

        public DbSet<EmploymentProjection> EmploymentProjections { get; set; }

        public DbSet<FutureEmployment> FutureEmployments { get; set; }

        public DbSet<Naics> Naics { get; set; }

        public DbSet<Naics2Digit> Naics2Digits { get; set; }

        public DbSet<Noc2011> Noc2011s { get; set; }

        public DbSet<PhysicalFlowAcccount> PhysicalFlowAcccounts { get; set; }

        public DbSet<RetirementProjection> RetirementProjections { get; set; }

        public DbSet<Sdgs372> Sdgs372s { get; set; }

        public DbSet<Sdgs411> Sdgs411s { get; set; }

        public DbSet<Sdgs431> Sdgs431s { get; set; }

        public DbSet<Sdgs441> Sdgs441s { get; set; }

        public DbSet<Sdgs531> Sdgs531s { get; set; }

        public DbSet<Sdgs861> Sdgs861s { get; set; }

        public DbSet<Soc2010> Soc2010s { get; set; }

        public DbSet<WorldBankGdp> WorldBankGdps { get; set; }
    }
}
