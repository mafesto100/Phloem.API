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
            var query = $"SELECT * FROM Product";

            using (var connection = _dapperContext.CreateConnection())
            {
                var products = await connection.QueryAsync<Product>(query);
                
                var productsDTO = _mapper.Map<IEnumerable<ProductDTO>>(products);

                return productsDTO.ToList();
            }
        }

        public async Task<ProductDTO> GetProduct(int id)
        {
            var query = $"SELECT * FROM Product WHERE ProductID={id}";

            using (var connection = _dapperContext.CreateConnection())
            {
                var product = await connection.QuerySingleAsync<Product>(query);

                var productDTO = _mapper.Map<ProductDTO>(product);

                return productDTO;
            }
        }
    }
}
