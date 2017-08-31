namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Sdgs861Repository : Repository<Sdgs861, StephContext>, ISdgs861Repository
    {
        public Sdgs861Repository(StephContext context) : base(context)
        {
        }
    }
}
