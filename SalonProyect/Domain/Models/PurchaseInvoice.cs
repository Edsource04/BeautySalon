using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class PurchaseInvoice
    {
        public Int32 InvoiceId { get; set; }
        public Int32 ClientId { get; set; }
        public String Employee { get; set; }
        public PaymentType PaymentType { get; set; } = PaymentType.None;
        public PaymentMethod PaymentMethod { get; set; } = PaymentMethod.Cash;
        public DateTime PurchaseDate { get; set; } = DateTime.Now;
        public Int32 SalesInvoiceId { get; set; }
        public Int32 EmployeeId { get; set; }
        public Int32 ProductCount { get; set; }
        public Decimal SubTotal { get; set; }
        public Decimal Taxes { get; set; }
        public Decimal Total { get; set; }
        public String DocumentNo { get; set; }

        public virtual Client Client { get; set; }
        public virtual Worker WorkerEmployee { get; set; }
        public virtual SaleInvoice Sale { get; set; }

        //ignore mapping properties
        public String PaymentMethodToString
        {
            get
            {
                return Enum.GetName(typeof(PaymentMethod), PaymentMethod);
            }
        }

        public String PaymentTypeToString
        {
            get
            {
                return Enum.GetName(typeof(PaymentType), PaymentType);
            }
        }
        
    }

    public enum PaymentType
    {
        NCF,
        TaxExcempt,
        None
    }

    public enum PaymentMethod
    {
        Cash,
        DebitCard,
        CreditCard,
        Check,
        BankTransfer
    }
}
