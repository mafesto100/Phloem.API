using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Core.Model.DTOs
{
    public class CartDTO
    {
        public int CartID { get; set; }
        public string? UserID { get; set; }
        public DateTime? CreatedDate { get; set; }
        public double TotalAmount { get; set; }
        public int Quantity { get; set; }
    }
}
