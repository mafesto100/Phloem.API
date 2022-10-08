using Phloem.Core.Domain;
using Phloem.Core.Model.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phloem.Core.Interfaces.Repository
{
    public interface ICartRepository
    {
        Task<CartItem> AddItem(CartItemDTO cartItemDTO);
        Task<CartItem> RemoveItem(CartItemDTO cartItemDTO);
        Task<CartItem> UpdateQuantity(int ProductID, CartItemDTO cartItemDTO);
        Task<CartItem> GetCartItem(int ProductID);
        Task<IEnumerable<CartItem>> GetCartItems();
    }
}
