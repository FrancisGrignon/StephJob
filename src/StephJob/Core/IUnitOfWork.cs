namespace StephJob.Core.Repositories
{
    using System;

    public interface IUnitOfWork : IDisposable
    {
        IEmploymentAveWeekEarningRepository EmploymentAveWeekEarnings { get; }

        IFutureEmploymentRepository FutureEmployments { get; }

        INaicsRepository Naics { get; }

        INoc2011Repository Noc2011s { get; }

        ISdgs372Repository Sdgs372s { get; }

        ISdgs411Repository Sdgs411s { get; }

        ISdgs431Repository Sdgs431s { get; }

        ISdgs441Repository Sdgs441s { get; }

        ISdgs531Repository Sdgs531s { get; }

        ISdgs861Repository Sdgs861s { get; }

        ISoc2010Repository Soc2010s { get; }

        IWorldBankGdpRepository WorldBankGdps { get; }

        int Complete();
    }
}