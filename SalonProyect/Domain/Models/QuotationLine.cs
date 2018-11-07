using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class QuotationLine
    {
        public Int32 QuotationLineId { get; set; }
        public Int32 QuotationId { get; set; }
        public String ProductName { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public Int32 ProductCount { get; set; }
        public Decimal SalePrice { get; set; }
        public Decimal ITBIS { get; set; }
        public Decimal Subtotal { get; set; }
        public Decimal Total { get; set; }

        public virtual Quotation Quotation { get; set; }
    }
}
