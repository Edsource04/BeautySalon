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

        /// <summary>
        /// Client View to load All Clients with an Anonimous Type
        /// </summary>
        /// <returns>Array of Anonimous Object to be use with a dynamic type</returns>
        public object[] VwLoadClients()
        {
            IEnumerable<Client> clients = SalonContext.Clients.Where(c => c.Status == true).ToList();

            Int32 iteratorCounter = 0;
            object[] aClients = new object[clients.Count()];

            foreach (Client item in clients)
            {
                object obj = new {
                    item.IdClient,
                    FullName = (item.FirstName + " " + item.LastName).ToUpper(),
                    item.Gender,
                    item.Birthday,
                    item.DocumentType,
                    item.DocumentNumber,
                    item.Address,
                    item.Telephone,
                    item.Email
                };

                aClients[iteratorCounter] = obj;
                iteratorCounter++;
            }

            return aClients;
        }

        public object[] VwClientsWithDebts()
        {
            IEnumerable<ChargeOfAccount> cAccounts = SalonContext
                        .ChargeOfAccounts
                        .Include("Client")
                        .Where(c => c.Status == true)
                        .Where(c => c.IsPaid == false)
                        .ToList();

            Int32 iteratorCounter = 0;
            object[] clients = new object[cAccounts.Count()];
            foreach (ChargeOfAccount item in cAccounts)
            {
                clients[iteratorCounter] = new {
                    item.ClientId,
                    item.Client.DocumentNumber,
                    item.Client.ClientCode,
                    Fullname = (item.Client.FirstName + " " + item.Client.LastName),
                    item.EntryDate,
                    item.Value,
                    item.RemainingAmount,

                    item.Sale.SaleInvoiceId
                };

                iteratorCounter++;
            }

            return clients;
        }


        public object[] VwGetUserWorker()
        {
            throw new NotImplementedException();
        }
    }
}
