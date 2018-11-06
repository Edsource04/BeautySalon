using System;
using Repository.Repositories;

namespace Core
{
    public interface IUnitOfWork : IDisposable
    {
        IClientRepository Clients { get;}
        IWorkerRepository Workers { get; }
        IChargeOfAccount ChargeOfAccounts { get; }
        Int32 JobDone();
    }
}
