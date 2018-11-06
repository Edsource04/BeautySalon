using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User
    {
        public Int32 Id { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public Role Role { get; set; }
        public bool Status { get; set; } = true;

        //Ignored
        public String RollName
        {
            get
            {
                return Enum.GetName(typeof(Role), Role);
            }
        }

        public virtual EmployeeUser EmployeeUser { get; set; }
    }


    public enum Role
    {
        Administrator,
        SingleUser,
        Owner
    }
}
