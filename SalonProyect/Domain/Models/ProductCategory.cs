using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class ProductCategory
    {
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }

        public Int32 Id { get; set; }
        public String CategoryName { get; set; }
        public String CategoryDescription { get; set; }

        public virtual ICollection<Product> Products { get; private set; }
    }
}
