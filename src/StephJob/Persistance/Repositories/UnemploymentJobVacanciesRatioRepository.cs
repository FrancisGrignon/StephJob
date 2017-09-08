namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class UnemploymentJobVacanciesRatioRepository : Repository<UnemploymentJobVacanciesRatio, StephContext>, IUnemploymentJobVacanciesRatioRepository
    {
        public UnemploymentJobVacanciesRatioRepository(StephContext context) : base(context)
        {
        }
    }
}
