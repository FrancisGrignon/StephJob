namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Sdgs531Repository : Repository<Sdgs531, StephContext>, ISdgs531Repository
    {
        public Sdgs531Repository(StephContext context) : base(context)
        {
        }
    }
}
