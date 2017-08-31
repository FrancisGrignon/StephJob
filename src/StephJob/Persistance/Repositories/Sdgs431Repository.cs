namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Sdgs431Repository : Repository<Sdgs431, StephContext>, ISdgs431Repository
    {
        public Sdgs431Repository(StephContext context) : base(context)
        {
        }
    }
}
