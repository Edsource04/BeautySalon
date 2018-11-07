using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Quotation
    {
        public Int32 QuotationId { get; set; }
        public Int32 ClientId { get; set; }
        public Int32 WorkerId { get; set; }
        public Int32 Amount { get; set; }
        public Decimal Subtotal { get; set; }
        public Decimal ITBIS { get; set; }
        public Decimal Total { get; set; }
        public DateTime Date { get; set; }
        public bool Status { get; set; } = true;

        public virtual Client Client { get; set; }
        public virtual Worker Employee { get; set; }
        public virtual ICollection<QuotationLine> QuotationLines { get; set; }
    }
}
