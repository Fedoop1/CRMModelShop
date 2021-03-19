using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI
{
    public class Seller
    {
        public int SellerId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Sell> Bills { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
