
using Microsoft.Extensions.Logging;
using Order.API.BusinessService.OrderService.OrderServices;
using Order.API.BusinessService.ProductService;
using Order.API.Data.Models;
using Order.API.DataService;
using Order.API.DataService.OrderService;
using Order.API.DataService.ProductService;
using Order.API.DataService.UserService;
using Order.API.Models;
using Order.API.Utility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.BusinessService.OrderService.OrderServices
{
    public class OrderService : IOrderService
    {
        public IOrderDataService _orderDataService { get; set; }
        public IProductDataService _productDataService { get; set; }
        public IUserDataService _userDataService { get; set; }

        public readonly ILogger<OrderService> _logger;
        public OrderService(IOrderDataService orderDataService, IProductDataService productDataService, IUserDataService userDataService, ILogger<OrderService> logger)
        {
            _orderDataService = orderDataService;
            _productDataService = productDataService;
            _userDataService = userDataService;
            _logger = logger;


        }

        /// <summary>
        /// Get Product Master
        /// </summary>
        /// <param name="productId"></param>
        /// <returns></returns>
        public ProductMaster GetProductMaster(int productId)
        {
            return _productDataService.GetProductMasterById(productId);

        }

        /// <summary>
        /// GetAllUserOrders
        /// </summary>
        /// <returns></returns>
        public ApiResponse  GetAllUserOrders(int skip = 0, int take = 10)
        {
            try
            {
                List<UserMaster> userMasters = _userDataService.GetAllUsers().ToList();

                IEnumerable<UserOrderDetail> userOrderDetails = _orderDataService.GetAllUserOrders(skip,take).Select(a =>
                    new UserOrderDetail
                    {
                        UserId = a.UserId,
                        ProductName = GetProductMaster(a.ProductId).ProductName,
                        Description = GetProductMaster(a.ProductId).Description,
                        ProductType = GetProductMaster(a.ProductId).ProductType,
                        UserName = _userDataService.GetUserById(a.UserId).UserName,
                        OrderStatus = a.OrderStatus,
                        OrderPlacedOn = a.CreatedOn,
                    });

                if (userOrderDetails.Count() == 0)
                    return new ApiResponse().Failed(HelperConst.NoDataMessage);
                return new ApiResponse(userOrderDetails);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new ApiResponse(ex);
            }
        }

        /// <summary>
        /// GetOrderDetail
        /// </summary>
        /// <param name="guid"></param>
        /// <returns></returns>
        public ApiResponse GetOrderDetail(Guid guid)
        {
            try
            {
                List<UserMaster> userMasters = _userDataService.GetAllUsers().ToList();
                UserOrder? userOrder = _orderDataService.GetAllUserOrders().FirstOrDefault();

                if (userOrder == null)
                    return new ApiResponse().Failed(HelperConst.NoDataMessage);

                UserOrderDetail userOrderDetail = new UserOrderDetail
                {
                    UserId = userOrder.UserId,
                    ProductName = GetProductMaster(userOrder.ProductId).ProductName,
                    Description = GetProductMaster(userOrder.ProductId).Description,
                    ProductType = GetProductMaster(userOrder.ProductId).ProductType,
                    UserName = _userDataService.GetUserById(userOrder.UserId).UserName,
                    OrderStatus = userOrder.OrderStatus,
                    OrderPlacedOn = userOrder.CreatedOn,
                };
                return new ApiResponse(userOrderDetail);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new ApiResponse(ex);
            }
        }

        /// <summary>
        /// PlaceOrder
        /// </summary>
        /// <param name="orderRequest"></param>
        /// <returns></returns>
        public async Task<ApiResponse> PlaceOrder(OrderRequest orderRequest)
        {
            try
            {
                UserOrder userOrder = new UserOrder()
                {
                    UserId = orderRequest.UserId,
                    ProductId = orderRequest.ProductId,
                    IsActive = true,
                    CreatedOn = DateTime.Now,
                    OrderStatus = HelperConst.Dispatch,

                };
                _orderDataService.PlaceOrder(userOrder);
               return new ApiResponse();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, ex.Message);
                return new ApiResponse(ex);
            }
        }
    }
}
