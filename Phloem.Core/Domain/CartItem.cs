using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Core.Domain
{
    public class CartItem
    {
        public int ItemID { get; set; }
        public int CartID { get; set; }
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public double TotalPrice { get; set; }
    }
}
