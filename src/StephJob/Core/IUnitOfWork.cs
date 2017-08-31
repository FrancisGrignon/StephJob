namespace StephJob.Core.Repositories
{
    using System;

    public interface IUnitOfWork : IDisposable
    {
        ISdgs372Repository Sdgs372s { get; }

        ISdgs411Repository Sdgs411s { get; }

        ISdgs431Repository Sdgs431s { get; }

        ISdgs441Repository Sdgs441s { get; }

        ISdgs531Repository Sdgs531s { get; }

        ISdgs861Repository Sdgs861s { get; }

        int Complete();
    }
}