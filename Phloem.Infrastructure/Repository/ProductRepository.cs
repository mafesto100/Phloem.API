using Phloem.Core.Domain;
using Phloem.Core.Interfaces.Repository;
using Phloem.Core.Model.DTOs;
using Phloem.Infrastructure.Context;
using Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace Phloem.Infrastructure.Repository
{
    public class ProductRepository: IProductRepository
    {
        private readonly DapperContext _dapperContext;
        private readonly IMapper _mapper;

        public ProductRepository(DapperContext dapperContext, IMapper mapper)
        {
            _dapperContext = dapperContext;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ProductDTO>> GetProducts()
        {
            string query = $"SELECT * FROM Product";

            IEnumerable<Product> product = await _dapperContext.GetItems<Product>(query);

            IEnumerable<ProductDTO> productsDTO = _mapper.Map<IEnumerable<ProductDTO>>(product);

            return productsDTO;
        }

        public async Task<ProductDTO> GetProduct(int id)
        {
            string query = $"SELECT * FROM Product WHERE ProductID={id}";

            Product product = await _dapperContext.GetItem<Product>(query, new { id });

            ProductDTO productDTO = _mapper.Map<ProductDTO>(product);

            return productDTO;

        }
    }
}
