namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class WorldBankGdpRepository : Repository<WorldBankGdp, StephContext>, IWorldBankGdpRepository
    {
        public WorldBankGdpRepository(StephContext context) : base(context)
        {
        }
    }
}
