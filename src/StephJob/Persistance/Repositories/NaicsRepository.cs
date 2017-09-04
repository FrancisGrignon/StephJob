namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class NaicsRepository : Repository<Naics, StephContext>, INaicsRepository
    {
        public NaicsRepository(StephContext context) : base(context)
        {
        }
    }
}
