using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.Models
{
    public class OrderRequest
    {
        public int UserId { get; set; }
        public int ProductId { get; set; } 
        public bool IsActive { get; set; }
    }
}
