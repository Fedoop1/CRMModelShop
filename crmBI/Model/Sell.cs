using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI
{
    public class Sell
    {
        public int ProductId { get; set; }
        public virtual Bill Bill { get; set; }
        public virtual Product Product { get; set; }
        public int BillId { get; set; }
        public int SellId { get; set; }
    }
}
