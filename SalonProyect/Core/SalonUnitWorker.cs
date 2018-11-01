using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repository.Repositories;
using Repository.Data;

namespace Core
{
    /// <summary>
    /// public class Context That will work with all Repositories withing a using block.
    /// example using(var unitOfWork = new SalonUnitWorker(new SalonWorker())) { Work in HERE }
    /// </summary>
    public class SalonUnitWorker : IUnitOfWork
    {
        private readonly SalonContext _context;

        public IClientRepository Clients { get; private set; }
        public IWorkerRepository Workers { get; private set; }

        public SalonUnitWorker(SalonContext context)
        {
            _context = context;
            Clients = new ClientRepository(_context);
            Workers = new WorkerRepository(_context);
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public int JobDone()
        {
            return _context.SaveChanges();
        }
    }
}
