namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Noc2011Repository : Repository<Noc2011, StephContext>, INoc2011Repository
    {
        public Noc2011Repository(StephContext context) : base(context)
        {
        }
    }
}
