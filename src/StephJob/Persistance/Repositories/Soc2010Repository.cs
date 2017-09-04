namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Soc2010Repository : Repository<Soc2010, StephContext>, ISoc2010Repository
    {
        public Soc2010Repository(StephContext context) : base(context)
        {
        }
    }
}
