namespace StephJob.Persistance.Repositories
{
    using StephJob.Core.Domain;
    using StephJob.Core.Repositories;

    public class Naics2DigitRepository : Repository<Naics2Digit, StephContext>, INaics2DigitRepository
    {
        public Naics2DigitRepository(StephContext context) : base(context)
        {
        }
    }
}
