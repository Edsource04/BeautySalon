using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Product
    {
     
        public Int32 Id { get; set; }
        public String Name { get; set; }
        public Int32 ProductCategoryId { get; set; }
        public String ProductCode { get; set; }
        public String ImageUrl { get; set; }
        public DateTime EntryDate { get; set; } = DateTime.Now;
        public String Description { get; set; }
        public Decimal SalePrice { get; set; }
        public Decimal PurchasePrice { get; set; }
        public Int32 ProductCount { get; set; }
        public bool Status { get; set; } = true;
        public Int32 ProviderId { get; set; }
        public String Barcode { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }

    }
}
