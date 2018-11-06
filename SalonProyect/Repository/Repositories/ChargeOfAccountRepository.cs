using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Data;

namespace Repository.Repositories
{
    public class ChargeOfAccountRepository : Repository<ChargeOfAccount>, IChargeOfAccount
    {

        public ChargeOfAccountRepository(SalonContext context) : base(context) { }

        /// <summary>
        /// Function That Return All Account that has debts With its Client information
        /// </summary>
        /// <returns>An Anonimous Array of object with the client Information and pending Amount</returns>
        public object[] GetChargeOfAccountUnpaid()
        {
            IEnumerable<ChargeOfAccount> chargeOfAccounts = SalonContext.ChargeOfAccounts.Include("Client")
                                              .Where(c => c.IsPaid == false && c.Status == true).ToList();

            Int32 iteratorCounter = 0;
            object[] cAccounts = new object[chargeOfAccounts.Count()];

            foreach(ChargeOfAccount ch in chargeOfAccounts)
            {
                object obj = new {
                    ch.Id,
                    ch.Client.IdClient,
                    ch.Client.ClientCode,
                    ch.Client.DocumentNumber,
                    FullName = (ch.Client.FirstName + " " + ch.Client.LastName),
                    ch.EntryDate,
                    ch.RemainingAmount,
                    ch.IsPaid
                };

                cAccounts[iteratorCounter] = obj;
                iteratorCounter++;
            }

            return cAccounts;
        }

        public SalonContext SalonContext
        {
            get
            {
                return Context as SalonContext;
            }
        }
    }
}
