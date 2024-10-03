using OnlineMarketPlace.Models;
using OnlineMarketPlace.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPlace.Logic
{
    public class OrderLogic : IOrderLogic
    {
        private readonly IRepository<Order> _orderRepository;

        public OrderLogic(IRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<decimal> CalculateTotalAmountAsync(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "A rendelés nem lehet null");
            }
            if (order.OrderItems == null || !order.OrderItems.Any())
            {
                return 0;
            }

            return order.OrderItems.Sum(item => item.Quantity * item.Product.Price);
        }

        public async Task CreateOrderAsync(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "A rendelés nem lehet null");
            }

            await _orderRepository.CreateAsync(order);
        }

        public async Task DeleteOrderAsync(int id)
        {
            var order = await _orderRepository.ReadAsync(id);
            if (order == null)
            {
                throw new Exception("A megadott rendelés nem található");
            }

            await _orderRepository.DeleteAsync(id);

        }

        public async Task<IEnumerable<Order>> GetAllOrdersAsync()
        {
            return await _orderRepository.ReadAllAsync();
        }

        public async Task<Order> GetOrderByIdAsync(int id)
        {
            var order = await _orderRepository.ReadAsync(id);
            if (order == null)
            {
                throw new Exception("A rendelés nem található.");
            }
            return order;
        }

        public async Task UpdateOrderAsync(Order order)
        {
            if (order == null)
            {
                throw new ArgumentNullException(nameof(order), "A rendelés nem lehet null");
            }
            await _orderRepository.UpdateAsync(order);
        }
    }
}
