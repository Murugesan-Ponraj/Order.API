using Order.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.Data
{
    public class OrderData
    {
        public List<ProductMaster> _products { get; set; }
        public List<UserMaster> _users { get; set; }
        public List<UserOrder> _userOrders { get; set; }

        private readonly SeedDataService _seedDataService;

        public OrderData(SeedDataService seedDataService)
        {
            _seedDataService = seedDataService;
            _users = _seedDataService._users;
            _products = _seedDataService._productMasters;
            _userOrders = new List<UserOrder>();
        }
    }
}
