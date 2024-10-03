using OnlineMarketPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPlace.Logic
{
    public interface IOrderItemLogic
    {
        Task<IEnumerable<OrderItem>> GetAllOrderItemAsync();
        Task<OrderItem> GetOrderItemByIdAsync(int id);
        Task CreateOrderItemAsync(OrderItem orderItem);
        Task UpdateOrderItemAsync(OrderItem orderItem);
        Task DeleteOrderItemAsync(int id);

        //other method
        Task AddProductToOrderAsync(Order order, Product product, int quantity);
    }
}
