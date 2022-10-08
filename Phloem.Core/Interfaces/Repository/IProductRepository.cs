using Phloem.Core.Model.DTOs;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Core.Interfaces.Repository
{
    public interface IProductRepository
    {
        public Task<IEnumerable<ProductDTO>> GetProducts();
        public Task<ProductDTO> GetProduct(int ProductID);
    }
}
