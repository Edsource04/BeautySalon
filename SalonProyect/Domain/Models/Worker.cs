using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Worker
    {
        public Worker()
        {
            this.PurchaseInvoices = new HashSet<PurchaseInvoice>();
            this.SaleInvoices = new HashSet<SaleInvoice>();
            this.Quotations = new HashSet<Quotation>();
        }

        public Int32 WorkerId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Gender { get; set; }
        public DateTime Birthday { get; set; }
        public String DocumentNumber { get; set; }
        public String Address { get; set; }
        public String Telephone { get; set; }
        public String Email { get; set; }
        public bool Status { get; set; } = true;
        public DateTime InsertedDate { get; set; } = DateTime.Now;
        public DateTime? ModifiedDate { get; set; }
        public String InsertedBy { get; set; }
        public String ModifiedBy { get; set; }

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; private set; }
        public virtual ICollection<SaleInvoice> SaleInvoices { get; private set; }
        public virtual EmployeeUser EmployeeUser { get; set; }
        public virtual ICollection<Quotation> Quotations { get; private set; }
    }
}
