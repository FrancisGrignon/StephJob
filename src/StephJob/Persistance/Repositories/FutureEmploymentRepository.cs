namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class FutureEmploymentRepository : Repository<FutureEmployment, StephContext>, IFutureEmploymentRepository
    {
        public FutureEmploymentRepository(StephContext context) : base(context)
        {
        }
    }
}
