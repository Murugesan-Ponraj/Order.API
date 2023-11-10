using Order.API.Data;
using Order.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.DataService.UserService
{
    public class UserDataService : IUserDataService
    {
        public OrderData orderData { get; set; }

        public UserDataService(OrderData _orderData)
        {
            orderData = _orderData;
        }
        public List<UserMaster> GetAllUsers()
        {
            return orderData._users;
        }

        public UserMaster GetUserById(int id)
        {
            return orderData._users.FirstOrDefault(a => a.Id == id);
        }
    }
}
