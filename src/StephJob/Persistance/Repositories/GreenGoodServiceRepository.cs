namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class GreenGoodServiceRepository : Repository<GreenGoodService, StephContext>, IGreenGoodServiceRepository
    {
        public GreenGoodServiceRepository(StephContext context) : base(context)
        {
        }
    }
}
