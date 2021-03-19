using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace crmBI
{
    public class Bill
    {
        public int BillId { get; set; }
        public int SellerId { get; set; }
        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Seller Seller { get; set; }

        public ICollection<Sell> Sells { get; set; }
        public DateTime Date { get; set; }

        public override string ToString()
        {
            return $"Чек от {Date.ToString("dd.MM.yy hh:mm:ss")}";
        }
    }
}
