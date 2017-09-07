namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class PhysicalFlowAcccountRepository : Repository<PhysicalFlowAcccount, StephContext>, IPhysicalFlowAcccountRepository
    {
        public PhysicalFlowAcccountRepository(StephContext context) : base(context)
        {
        }
    }
}
