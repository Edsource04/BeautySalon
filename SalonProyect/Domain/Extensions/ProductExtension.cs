using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Extensions
{
    public static class ProductExtension
    {
        /// <summary>
        /// Generate a Barcode From the Name of the Product and the Id
        /// </summary>
        /// <param name="product"></param>
        public static void SetBarcode(this Product product)
        {
            product.Barcode = (product.Name.Substring(1, 4) + "00000" + product.Id.ToString()).ToUpper();
        }
    }
}
