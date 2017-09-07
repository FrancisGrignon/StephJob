namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class EmploymentProjectionRepository : Repository<EmploymentProjection, StephContext>, IEmploymentProjectionRepository
    {
        public EmploymentProjectionRepository(StephContext context) : base(context)
        {
        }
    }
}
