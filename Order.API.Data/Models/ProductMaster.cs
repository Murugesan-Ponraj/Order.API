using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.Data.Models
{
    public class ProductMaster
    {
        public int Id { get; set; } 
        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string Description { get; set; } 
        public string PublishedBy { get; set; } 
        public bool IsActive { get; set; }  
    }
}
