using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public int ProductId { get; private set; }
        public string ProductName { get; set; }
        public Decimal? CurrentPrice { get; set; }

        public Product Retrieve(int productId)
        {
            return new Product();
        }

        public List<Product> Retrieve()
        {
            return new List<Product>();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            return isValid;
        }

        public string Log()
        {
            var logString = this.ProductId + ": " +
                            this.ProductName;
            return logString;
        }
    }
}
