namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class EmploymentAveWeekEarningRepository : Repository<EmploymentAveWeekEarning, StephContext>, IEmploymentAveWeekEarningRepository
    {
        public EmploymentAveWeekEarningRepository(StephContext context) : base(context)
        {
        }
    }
}
