using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.Models
{
    public class UserOrderDetail
    {
        public Guid Id { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string OrderStatus { get; set; }
        public DateTime OrderPlacedOn { get; set; }
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; }
        public string PublishedBy { get; set; } 
  


    }
}
