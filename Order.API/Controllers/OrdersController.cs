using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc; 
using Order.API.BusinessService.OrderService.OrderServices;
using Order.API.Models;

namespace Order.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        public IOrderService orderService { get; set; }

        private readonly ILogger<OrdersController> _logger;
        public OrdersController(IOrderService _orderService, ILogger<OrdersController> logger)
        {
            orderService = _orderService;
            _logger = logger;
        }

        /// <summary>
        /// GetUserOrderDetails
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ApiResponse GetUserOrderDetails(int skip = 0, int take = 10)
        {
            try
            {
                 return orderService.GetAllUserOrders();
             

            }
            catch (Exception ex)
            {
                _logger.LogError(ex,ex.Message);
                return new ApiResponse(ex);
            }

        
        }

        /// <summary>
        /// PlaceUserOrder
        /// </summary>
        /// <param name="orderRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ApiResponse> PlaceUserOrder(OrderRequest orderRequest)
        {
            try
            {
               return orderService.PlaceOrder(orderRequest).Result; 

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new ApiResponse(ex);
            }


        }

    }
}
