using BusinessObjects.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public interface ICartRepository
    {
        IEnumerable<FlowerBouquet> GetCartItems(); // Lấy danh sách các sản phẩm trong giỏ hàng
        void AddItemToCart(FlowerBouquet flowerBouquet, int quantity); // Thêm một sản phẩm vào giỏ hàng
        void RemoveItemFromCart(int flowerBouquetId); // Xóa một sản phẩm khỏi giỏ hàng
        void ClearCart(); // Xóa toàn bộ giỏ hàng
    }
}
