using OnlineMarketPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPlace.Logic
{
    public class OrderItemLogic : IOrderItemLogic
    {
        public Task AddProductToOrderAsync(Order order, Product product, int quantity)
        {
            throw new NotImplementedException();
        }

        public Task CreateOrderItemAsync(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }

        public Task DeleteOrderItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<OrderItem>> GetAllOrderItemAsync()
        {
            throw new NotImplementedException();
        }

        public Task<OrderItem> GetOrderItemByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateOrderItemAsync(OrderItem orderItem)
        {
            throw new NotImplementedException();
        }
    }
}
