using Order.API.Data;
using Order.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.DataService.ProductService
{
    public class ProductDataService : IProductDataService
    {
        public OrderData orderData { get; set; }

        public ProductDataService(OrderData _orderData)
        {
            orderData = _orderData;
        }
        public ProductMaster GetProductMasterById(int id)
        {
            return orderData._products.FirstOrDefault(a => a.Id == id);
        }

        public IEnumerable<ProductMaster> GetAllProductMasters()
        {
            return orderData._products;
        }
    }
}
