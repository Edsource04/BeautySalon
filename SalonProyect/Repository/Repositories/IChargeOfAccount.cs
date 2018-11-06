using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Repository.Repositories
{
    public interface IChargeOfAccount : IRepository<ChargeOfAccount>
    {
        /// <summary>
        /// Function That Return All Account that has debts With its Client information
        /// </summary>
        /// <returns>An Anonimous Array of object with the client Information and pending Amount</returns>
        object[] GetChargeOfAccountUnpaid();
    }
}
