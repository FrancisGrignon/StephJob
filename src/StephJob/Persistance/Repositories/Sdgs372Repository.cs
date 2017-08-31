namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Sdgs372Repository : Repository<Sdgs372, StephContext>, ISdgs372Repository
    {
        public Sdgs372Repository(StephContext context) : base(context)
        {
        }
    }
}
