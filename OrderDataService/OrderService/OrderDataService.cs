using Order.API.Data;
using Order.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.API.DataService.OrderService;
using Microsoft.Extensions.Logging;

namespace Order.API.DataService.OrderService
{
    public class OrderDataService : IOrderDataService
    {
        public OrderData orderData { get; set; }
        public readonly ILogger<OrderDataService> _logger;
        public OrderDataService(OrderData _orderData, ILogger<OrderDataService> logger)
        {
            orderData = _orderData;
            _logger = logger;
        }

        /// <summary>
        /// Get All user orders
        /// </summary>
        /// <returns></returns>
        public IEnumerable<UserOrder> GetAllUserOrders(int skip = 0, int take = 10)
        {
            try
            {
                return orderData._userOrders.Skip(skip).Take(take);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return default;
            }
        }

        /// <summary>
        /// Get Order Detail
        /// </summary>
        /// <param name="orderId"></param>
        /// <returns></returns>
        public UserOrder GetOrderDetail(Guid orderId)
        {
            try
            { 
            return orderData._userOrders.FirstOrDefault(a => a.OrderId == orderId);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return default;
            }
        }

        /// <summary>
        /// Place the users order
        /// </summary>
        /// <param name="userOrder"></param>
        public void PlaceOrder(UserOrder userOrder)
        {
            try
            {
                if (userOrder is not null)
                    orderData._userOrders.Add(userOrder);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
            }

        }
    }
}
