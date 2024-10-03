using OnlineMarketPlace.Models;
using OnlineMarketPlace.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineMarketPlace.Logic
{
    public class OrderItemLogic : IOrderItemLogic
    {
        private readonly IRepository<OrderItem> _orderItemRepository;
        private readonly IRepository<Order> _orderRepository;

        public OrderItemLogic(IRepository<OrderItem> orderItemRepository, IRepository<Order> orderRepository)
        {
            _orderItemRepository = orderItemRepository;
            _orderRepository = orderRepository;
        }

        public async Task AddProductToOrderAsync(Order order, Product product, int quantity)
        {
            var orderItem = new OrderItem
            {
                Product = product,
                Quantity = quantity
            };
            order.OrderItems.Add(orderItem);
            await _orderRepository.UpdateAsync(order);
        }

        public async Task CreateOrderItemAsync(OrderItem orderItem)
        {
            if (orderItem == null)
            {
                throw new ArgumentNullException(nameof(orderItem), "A rendelt termék nem lehet null");
            }
            await _orderItemRepository.CreateAsync(orderItem);
        }

        public async Task DeleteOrderItemAsync(int id)
        {
            var orderItem = await _orderItemRepository.ReadAsync(id);
            if (orderItem == null)
            {
                throw new Exception("A rendelt termék nem létezik");
            }
            await _orderItemRepository.DeleteAsync(id);
        }

        public async Task<IEnumerable<OrderItem>> GetAllOrderItemAsync()
        {
            return await _orderItemRepository.ReadAllAsync();
        }

        public async Task<OrderItem> GetOrderItemByIdAsync(int id)
        {
            var orderItem = await _orderItemRepository.ReadAsync(id);
            if (orderItem == null)
            {
                throw new Exception("A rendelt termék nem létezik");
            }
            return orderItem;
        }

        public async Task UpdateOrderItemAsync(OrderItem orderItem)
        {
            if (orderItem == null)
            {
                throw new ArgumentNullException(nameof(orderItem), "A rendelt termék nem található");
            }
            await _orderItemRepository.UpdateAsync(orderItem);
        }
    }
}
