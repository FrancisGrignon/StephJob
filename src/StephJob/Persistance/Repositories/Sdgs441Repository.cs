namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Sdgs441Repository : Repository<Sdgs441, StephContext>, ISdgs441Repository
    {
        public Sdgs441Repository(StephContext context) : base(context)
        {
        }
    }
}
