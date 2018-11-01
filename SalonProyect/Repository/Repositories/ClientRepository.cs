using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Data;

namespace Repository.Repositories
{
    public class ClientRepository : Repository<Client>, IClientRepository
    {

        public ClientRepository(SalonContext context) : base(context) { }

        public SalonContext SalonContext
        {
            get
            {
                return Context as SalonContext;
            }
        }
        public IEnumerable<Client> GetClientWithDebts()
        {
            return SalonContext.Clients.ToList();
        }
    }
}
