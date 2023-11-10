using Microsoft.Extensions.Logging;
using Order.API.Data.Models;
using Order.API.DataService.ProductService;
using Order.API.Models;
using Order.API.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.BusinessService.ProductService
{
    public class ProductService : IProductService
    {
        public IProductDataService productDataService { get; set; }
        public readonly ILogger<ProductService> _logger;
        public ProductService(IProductDataService _productDataService, ILogger<ProductService> logger)
        {
            productDataService = _productDataService;
            _logger = logger;
        }

        /// <summary>
        /// Get Product Masters
        /// </summary>
        /// <returns></returns>
        public ApiResponse GetProductMasters()
        {
            try
            {
                IEnumerable<ProductMaster> productMasters = productDataService.GetAllProductMasters();
                if (productMasters.Count() == 0)
                    return new ApiResponse().Failed(HelperConst.NoDataMessage);
                return new ApiResponse(productMasters);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new ApiResponse(ex);
            }
        }
    }
}
