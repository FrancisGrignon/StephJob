namespace PlutoWeb.Persistence
{
    using StephJob.Core.Repositories;
    using StephJob.Persistance;
    using StephJob.Persistance.Repositories;
    using System;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly StephContext context;

        private readonly Lazy<IEmploymentAveWeekEarningRepository> employmentAveWeekEarnings;

        private readonly Lazy<IEmploymentProjectionRepository> employmentProjections;

        private readonly Lazy<IFutureEmploymentRepository> futureEmployments;

        private readonly Lazy<IGreenGoodServiceRepository> greenGoodServices;

        private readonly Lazy<IGrossDomesticProductRepository> grossDomesticProducts;

        private readonly Lazy<INaicsRepository> naics;

        private readonly Lazy<INaics2DigitRepository> naics2Digits;

        private readonly Lazy<INoc2011Repository> noc2011s;

        private readonly Lazy<IPhysicalFlowAcccountRepository> physicalFlowAcccounts;

        private readonly Lazy<IRetirementProjectionRepository> retirementProjections;

        private readonly Lazy<ISdgs372Repository> sdgs372s;

        private readonly Lazy<ISdgs411Repository> sdgs411s;

        private readonly Lazy<ISdgs431Repository> sdgs431s;

        private readonly Lazy<ISdgs441Repository> sdgs441s;

        private readonly Lazy<ISdgs531Repository> sdgs531s;

        private readonly Lazy<ISdgs861Repository> sdgs861s;

        private readonly Lazy<ISoc2010Repository> soc2010s;

        private readonly Lazy<IWorldBankGdpRepository> worldBankGdps;
        
        public UnitOfWork(StephContext context)
        {
            this.context = context;

            this.employmentAveWeekEarnings = new Lazy<IEmploymentAveWeekEarningRepository>(() => new EmploymentAveWeekEarningRepository(context));
            this.employmentProjections = new Lazy<IEmploymentProjectionRepository>(() => new EmploymentProjectionRepository(context));
            this.futureEmployments = new Lazy<IFutureEmploymentRepository>(() => new FutureEmploymentRepository(context));
            this.greenGoodServices = new Lazy<IGreenGoodServiceRepository>(() => new GreenGoodServiceRepository(context));
            this.grossDomesticProducts = new Lazy<IGrossDomesticProductRepository>(() => new GrossDomesticProductRepository(context));
            this.naics = new Lazy<INaicsRepository>(() => new NaicsRepository(context));
            this.naics2Digits = new Lazy<INaics2DigitRepository>(() => new Naics2DigitRepository(context));
            this.noc2011s = new Lazy<INoc2011Repository>(() => new Noc2011Repository(context));
            this.physicalFlowAcccounts = new Lazy<IPhysicalFlowAcccountRepository>(() => new PhysicalFlowAcccountRepository(context));
            this.retirementProjections = new Lazy<IRetirementProjectionRepository>(() => new RetirementProjectionRepository(context));
            this.sdgs372s = new Lazy<ISdgs372Repository>(() => new Sdgs372Repository(context));
            this.sdgs411s = new Lazy<ISdgs411Repository>(() => new Sdgs411Repository(context));
            this.sdgs431s = new Lazy<ISdgs431Repository>(() => new Sdgs431Repository(context));
            this.sdgs441s = new Lazy<ISdgs441Repository>(() => new Sdgs441Repository(context));
            this.sdgs531s = new Lazy<ISdgs531Repository>(() => new Sdgs531Repository(context));
            this.sdgs861s = new Lazy<ISdgs861Repository>(() => new Sdgs861Repository(context));
            this.soc2010s = new Lazy<ISoc2010Repository>(() => new Soc2010Repository(context));
            this.worldBankGdps = new Lazy<IWorldBankGdpRepository>(() => new WorldBankGdpRepository(context));
        }

        public IEmploymentAveWeekEarningRepository EmploymentAveWeekEarnings => employmentAveWeekEarnings.Value;

        public IEmploymentProjectionRepository EmploymentProjections => employmentProjections.Value;
        
        public IFutureEmploymentRepository FutureEmployments => futureEmployments.Value;

        public IGreenGoodServiceRepository GreenGoodServices => greenGoodServices.Value;

        public IGrossDomesticProductRepository GrossDomesticProducts => grossDomesticProducts.Value;

        public INaicsRepository Naics => naics.Value;

        public INaics2DigitRepository Naics2Digits => naics2Digits.Value;

        public INoc2011Repository Noc2011s => noc2011s.Value;

        public IPhysicalFlowAcccountRepository PhysicalFlowAcccounts => physicalFlowAcccounts.Value;

        public IRetirementProjectionRepository RetirementProjections => retirementProjections.Value;

        public ISdgs372Repository Sdgs372s => sdgs372s.Value;

        public ISdgs411Repository Sdgs411s => sdgs411s.Value;

        public ISdgs431Repository Sdgs431s => sdgs431s.Value;

        public ISdgs441Repository Sdgs441s => sdgs441s.Value;

        public ISdgs531Repository Sdgs531s => sdgs531s.Value;

        public ISdgs861Repository Sdgs861s => sdgs861s.Value;

        public ISoc2010Repository Soc2010s => soc2010s.Value;

        public IWorldBankGdpRepository WorldBankGdps => worldBankGdps.Value;

        public int Complete()
        {
            return context.SaveChanges();
        }

        public void Dispose()
        {
            context.Dispose();
        }
    }
}