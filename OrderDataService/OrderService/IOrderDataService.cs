using Order.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.DataService.OrderService
{
    public interface IOrderDataService
    {
        IEnumerable<UserOrder> GetAllUserOrders(int skip = 0, int take = 10);
        UserOrder GetOrderDetail(Guid guid);
        void PlaceOrder(UserOrder userOrder);
    }
}
