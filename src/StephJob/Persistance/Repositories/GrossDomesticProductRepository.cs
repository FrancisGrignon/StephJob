namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class GrossDomesticProductRepository : Repository<GrossDomesticProduct, StephContext>, IGrossDomesticProductRepository
    {
        public GrossDomesticProductRepository(StephContext context) : base(context)
        {
        }
    }
}
