namespace StephJob.Core.Repositories
{
    using System;

    public interface IUnitOfWork : IDisposable
    {
        IEmploymentAveWeekEarningRepository EmploymentAveWeekEarnings { get; }

        IEmploymentProjectionRepository EmploymentProjections { get; }

        IFutureEmploymentRepository FutureEmployments { get; }

        IGreenGoodServiceRepository GreenGoodServices { get; }

        IGrossDomesticProductRepository GrossDomesticProducts { get; }

        INaicsRepository Naics { get; }

        INaics2DigitRepository Naics2Digits { get; }

        INoc2011Repository Noc2011s { get; }

        IPhysicalFlowAcccountRepository PhysicalFlowAcccounts { get; }

        IRetirementProjectionRepository RetirementProjections { get; }

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