using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using Repository.Data;

namespace Repository.Repositories
{
    public class EmployeeUserRepository : Repository<EmployeeUser>, IEmployeeUser
    {
        public EmployeeUserRepository(SalonContext context) : base(context) { }

        /// <summary>
        /// Get All Employees With User Security information
        /// </summary>
        /// <returns>Array of Objects with Employee information</returns>
        public object[] WvGetEmployeeUsers()
        {
            IEnumerable<EmployeeUser> employeeUsers = SalonContext
                .EmployeeUsers
                .Include("Employee")
                .Include("User").ToList();

            Int32 iterator = 0;
            object[] objs = new object[employeeUsers.Count()];

            foreach (EmployeeUser item in employeeUsers)
            {
                objs[iterator] = new
                {
                   RollId = (Int32) item.User.Role,
                   FullName = (item.Employee.FirstName + " " + item.Employee.LastName),
                   item.User.Username,
                   item.User.Password,
                   EmployeeId = item.Employee.WorkerId
                };
                iterator++;
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
