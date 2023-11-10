using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.Data.Models
{
    public class UserOrder
    { 
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public Guid OrderId { get; private set; } = Guid.NewGuid(); 
        public DateTime CreatedOn { get; set; }
        public bool IsActive { get; set; }
        public string OrderStatus { get; set;}
         

    }
}
