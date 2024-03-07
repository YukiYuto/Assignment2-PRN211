using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CartRepository : ICartRepository
    {
        private readonly List<FlowerBouquet> _cartItems;

        public CartRepository()
        {
            _cartItems = new List<FlowerBouquet>();
        }

        public IEnumerable<FlowerBouquet> GetCartItems()
        {
            return _cartItems;
        }

        public void AddItemToCart(FlowerBouquet flowerBouquet, int quantity)
        {
            // Kiểm tra xem sản phẩm đã tồn tại trong giỏ hàng hay chưa
            var existingItem = _cartItems.FirstOrDefault(item => item.FlowerBouquetId == flowerBouquet.FlowerBouquetId);
            if (existingItem != null)
            {
                // Nếu sản phẩm đã tồn tại, tăng số lượng lên
                existingItem.UnitsInStock += quantity;
            }
            else
            {
                // Nếu sản phẩm chưa tồn tại, thêm vào giỏ hàng với số lượng mới
                var newItem = new FlowerBouquet
                {
                    FlowerBouquetId = flowerBouquet.FlowerBouquetId,
                    FlowerBouquetName = flowerBouquet.FlowerBouquetName,
                    Description = flowerBouquet.Description,
                    UnitPrice = flowerBouquet.UnitPrice,
                    UnitsInStock = quantity
                };
                _cartItems.Add(newItem);
            }
        }

        public void RemoveItemFromCart(int flowerBouquetId)
        {
            // Tìm và xóa sản phẩm khỏi giỏ hàng
            var itemToRemove = _cartItems.FirstOrDefault(item => item.FlowerBouquetId == flowerBouquetId);
            if (itemToRemove != null)
            {
                _cartItems.Remove(itemToRemove);
            }
        }

        public void ClearCart()
        {
            // Xóa toàn bộ giỏ hàng
            _cartItems.Clear();
        }
    }
}
