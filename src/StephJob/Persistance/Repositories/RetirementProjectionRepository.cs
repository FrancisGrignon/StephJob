namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class RetirementProjectionRepository : Repository<RetirementProjection, StephContext>, IRetirementProjectionRepository
    {
        public RetirementProjectionRepository(StephContext context) : base(context)
        {
        }
    }
}
