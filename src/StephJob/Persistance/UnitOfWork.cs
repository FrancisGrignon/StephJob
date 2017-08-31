namespace PlutoWeb.Persistence
{
    using StephJob.Core.Repositories;
    using StephJob.Persistance;
    using StephJob.Persistance.Repositories;
    using System;

    public class UnitOfWork : IUnitOfWork
    {
        private readonly StephContext context;

        private readonly Lazy<ISdgs372Repository> sdgs372s;

        private readonly Lazy<ISdgs411Repository> sdgs411s;

        private readonly Lazy<ISdgs431Repository> sdgs431s;

        private readonly Lazy<ISdgs441Repository> sdgs441s;

        private readonly Lazy<ISdgs531Repository> sdgs531s;

        private readonly Lazy<ISdgs861Repository> sdgs861s;


        public UnitOfWork(StephContext context)
        {
            this.context = context;

            this.sdgs372s = new Lazy<ISdgs372Repository>(() => new Sdgs372Repository(context));
            this.sdgs411s = new Lazy<ISdgs411Repository>(() => new Sdgs411Repository(context));
            this.sdgs431s = new Lazy<ISdgs431Repository>(() => new Sdgs431Repository(context));
            this.sdgs441s = new Lazy<ISdgs441Repository>(() => new Sdgs441Repository(context));
            this.sdgs531s = new Lazy<ISdgs531Repository>(() => new Sdgs531Repository(context));
            this.sdgs861s = new Lazy<ISdgs861Repository>(() => new Sdgs861Repository(context));
        }

        public ISdgs372Repository Sdgs372s => sdgs372s.Value;

        public ISdgs411Repository Sdgs411s => sdgs411s.Value;

        public ISdgs431Repository Sdgs431s => sdgs431s.Value;

        public ISdgs441Repository Sdgs441s => sdgs441s.Value;

        public ISdgs531Repository Sdgs531s => sdgs531s.Value;

        public ISdgs861Repository Sdgs861s => sdgs861s.Value;
        
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