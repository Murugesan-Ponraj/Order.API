using Order.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.BusinessService.OrderService.OrderServices
{
    public interface IOrderService
    {
        ApiResponse GetAllUserOrders(int skip = 0, int take = 10);
        ApiResponse GetOrderDetail(Guid guid);
        Task<ApiResponse> PlaceOrder(OrderRequest orderRequest);
    }
}
