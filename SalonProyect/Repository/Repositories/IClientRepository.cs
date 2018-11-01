using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Repository.Repositories
{
    public interface IClientRepository : IRepository<Client>
    {
        IEnumerable<Client> GetClientWithDebts();
    }
}
