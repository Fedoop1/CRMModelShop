using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }

        public ICollection<Sell> Sells { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}.\nPrice: {Price}.";
        }

        public override int GetHashCode()
        {
            return this.ProductId;
        }

        public override bool Equals(object obj)
        {
            if(obj is Product product)
            {
                return this.ProductId == product.ProductId;
            }

            return false;
        }
    }
}
