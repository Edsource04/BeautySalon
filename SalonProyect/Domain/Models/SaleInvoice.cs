using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class SaleInvoice
    {
        public Int32 SaleInvoiceId { get; set; }
        public Int32 ClientId { get; set; }
        public Int32 WorkerId { get; set; }
        public DateTime SalesDate { get; set; }
        public PaymentType PaymentType { get; set; }
        public ClientType ClientType { get; set; }
        public String SaleType { get; set; }
        public Decimal ITBIS { get; set; }
        public Decimal Subtotal { get; set; }
        public Decimal Total { get; set; }

        public virtual Client Client { get; set; }
        public virtual Worker Worker { get; set; } 
        public virtual PurchaseInvoice PurchaseInvoice { get; set; }
    }

    public enum ClientType
    {
        None,
        Ambulatory,
        ExistingCustomer
    }
}
