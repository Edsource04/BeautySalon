using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Enums;

namespace Domain.Models
{
    public class Session
    {
        public String LoggedInUser { get; set; }
        public Role Role { get; set; }
        public String FullName { get; set; }
        public Int32 WorkerId { get; set; }

        private static Session _user = null;

        private Session() { }

        public static Session Instance
        {
            get
            {
                if (_user == null)
                    _user = new Session();

                return _user;
            }
        }


    }
}
