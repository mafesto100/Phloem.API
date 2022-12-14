using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Core.Model.DTOs
{
    public class ProductDTO
    {
        public int ProductID { get; set; }
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }
        public int Quantity { get; set; }
        public int CategoryID { get; set; }
    }
}
