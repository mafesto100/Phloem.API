using AutoMapper;
using Dapper;
using Phloem.Core.Domain;
using Phloem.Core.Interfaces.Repository;
using Phloem.Core.Model.DTOs;
using Phloem.Infrastructure.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Infrastructure.Repository
{
    public class CartRepository : ICartRepository
    {
        private readonly DapperContext _dapperContext;
        private readonly IMapper _mapper;
        public CartRepository(DapperContext dapperContext, IMapper mapper)
        {
            _dapperContext = dapperContext;
            _mapper = mapper;
        }
        public async Task<CartItemDTO> AddItem(ProductDTO productDTO)
        {
            var product = _mapper.Map<Product>(productDTO);
            var query = $"SELECT * FROM Products WHERE ProductID={product.ProductID}";

            var item = await _dapperContext.GetItem<Product>(query);

            if (item != null)
            {
                CartItemDTO cartItem = new()
                {
                    ProductID = item.ProductID,
                    Price = item.Price,
                };
            }

          
            throw new NotImplementedException();

        }

        public Task<CartItem> AddItem(CartItemDTO cartItemDTO)
        {
            throw new NotImplementedException();
        }

        public Task<CartItem> GetCartItem(int ProductID)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CartItem>> GetCartItems()
        {
            throw new NotImplementedException();
        }

        public Task<CartItem> RemoveItem(CartItemDTO cartItemDTO)
        {
            throw new NotImplementedException();
        }

        public Task<CartItem> UpdateQuantity(int ProductID, CartItemDTO cartItemDTO)
        {
            throw new NotImplementedException();
        }
    }
}
