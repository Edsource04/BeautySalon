using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Data;

namespace Repository.Repositories
{
    public class WorkerRepository : Repository<Worker>, IWorkerRepository
    {
        public WorkerRepository(SalonContext context) : base(context) { }

        /// <summary>
        /// Method That Takes All Employees from the Database and Return an Anonimous Array objects[]
        /// needs to be retreived with dynamic data type.
        /// </summary>
        /// <returns>Array of object[] that needs to be mapped with dynamic[] </returns>
        public object[] ViewGetEmployees()
        {
            IEnumerable<Worker> workers = SalonContext.Workers.Where(w => w.Status == true).ToList();
            object[] objs = new object[workers.Count()];

            Int32 i = 0;

            foreach(Worker w in workers)
            {
                objs[i] = new
                {
                    w.WorkerId,
                    FullName = (w.FirstName + " " + w.LastName).ToUpper(),
                    w.Gender,
                    w.DocumentNumber,
                    w.Birthday,
                    w.Address,
                    w.Telephone,
                    Status = (w.Status == true)? "Activo" : "Inactivo",
                    w.InsertedDate,
                    w.ModifiedDate,
                    w.InsertedBy,
                    w.ModifiedBy
                };

                i++;
            }

            return objs;
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
