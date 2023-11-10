using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Order.API.BusinessService.ProductService;
using Order.API.Models;

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        public IProductService _productService { get; set; }

        private readonly ILogger<ProductController> _logger;
        public ProductController(IProductService productService, ILogger<ProductController> logger)
        {
            _productService = productService;
            _logger = logger;
        }

        /// <summary>
        /// Get User OrderDetails
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ApiResponse GetAllProducts(int skip = 0, int take = 10)
        {
            try
            {
                return _productService.GetProductMasters();


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new ApiResponse(ex);
            }


        }
    }
}
