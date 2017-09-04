namespace PlutoWeb.Persistence
{
    using StephJob.Core.Repositories;
    using StephJob.Persistance;
    using StephJob.Persistance.Repositories;
    using System;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly StephContext context;

        private readonly Lazy<INaicsRepository> naics;

        private readonly Lazy<INoc2011Repository> noc2011s;

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

            this.naics = new Lazy<INaicsRepository>(() => new NaicsRepository(context));
            this.noc2011s = new Lazy<INoc2011Repository>(() => new Noc2011Repository(context));
            this.sdgs372s = new Lazy<ISdgs372Repository>(() => new Sdgs372Repository(context));
            this.sdgs411s = new Lazy<ISdgs411Repository>(() => new Sdgs411Repository(context));
            this.sdgs431s = new Lazy<ISdgs431Repository>(() => new Sdgs431Repository(context));
            this.sdgs441s = new Lazy<ISdgs441Repository>(() => new Sdgs441Repository(context));
            this.sdgs531s = new Lazy<ISdgs531Repository>(() => new Sdgs531Repository(context));
            this.sdgs861s = new Lazy<ISdgs861Repository>(() => new Sdgs861Repository(context));
            this.soc2010s = new Lazy<ISoc2010Repository>(() => new Soc2010Repository(context));
            this.worldBankGdps = new Lazy<IWorldBankGdpRepository>(() => new WorldBankGdpRepository(context));
        }

        public INaicsRepository Naics => naics.Value;

        public INoc2011Repository Noc2011s => noc2011s.Value;

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