using Order.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.DataService.ProductService
{
    public interface IProductDataService
    {
        IEnumerable<ProductMaster> GetAllProductMasters();

        ProductMaster GetProductMasterById(int id);
    }
}
