using Order.API.Data.Models;
using Order.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.BusinessService.ProductService
{
    public interface IProductService
    {
        ApiResponse GetProductMasters();
    }
}
