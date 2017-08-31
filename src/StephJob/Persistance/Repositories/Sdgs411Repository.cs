namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Sdgs411Repository : Repository<Sdgs411, StephContext>, ISdgs411Repository
    {
        public Sdgs411Repository(StephContext context) : base(context)
        {
        }
    }
}
