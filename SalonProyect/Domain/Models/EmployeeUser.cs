using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class EmployeeUser
    {
        public Int32 Id { get; set; }
        public Int32 EmployeeId { get; set; }
        public Int32 UserId { get; set; }
        public DateTime? AssigmentDate { get; set; }
        public DateTime? DeAssigmentDate { get; set; }
        public bool AssignationStatus { get; set; } = false;
        public String InsertedBy { get; set; }
        public String ModifiedBy { get; set; }
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }

        public virtual Worker Employee { get; set; }
        public virtual User User { get; set; }

    }
}
