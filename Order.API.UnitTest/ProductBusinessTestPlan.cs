using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;
using Order.API.BusinessService.OrderService.OrderServices;
using Order.API.BusinessService.ProductService;
using Order.API.Data;
using Order.API.Data.Models;
using Order.API.DataService.OrderService;
using Order.API.DataService.ProductService;
using Order.API.DataService.UserService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.UnitTest
{
    
    public class ProductBusinessTestPlan
    {
        Mock<IOrderDataService> _mockorderDataService;
        IOrderDataService _orderDataService;
        Mock<IProductDataService> _mockproductDataService;
        Mock<IUserDataService> _mockuserDataService;
        Mock<ILogger<OrderService>> _mocklogger;
        OrderData orderData;

        [SetUp]
       public void TestInitialize()
        {
            _mockorderDataService = new Mock<IOrderDataService>(MockBehavior.Default);
            _mockproductDataService = new Mock<IProductDataService>(MockBehavior.Default);
            _mockuserDataService = new Mock<IUserDataService>(MockBehavior.Default);
            _mocklogger = new Mock<ILogger<OrderService>>(MockBehavior.Default);
            SeedDataService seedDataService = new SeedDataService();
            orderData = new OrderData(seedDataService);
        }


      
            [TestCase(1, 5)]
            [TestCase(3, 10)]
           public void Test_GetUser_OrderDetails_Pagination(int skip, int take)
            {
                try
                {
                    //Arrange
                    List<UserOrder> userOrders = orderData._userOrders.Skip(skip).Take(take).ToList();
                    _mockorderDataService.Setup(x => x.GetAllUserOrders(skip, take)).Returns(userOrders);

                    //Act
                    IOrderService orderService = new OrderService(_mockorderDataService.Object, _mockproductDataService.Object, _mockuserDataService.Object, _mocklogger.Object);
                    var expectedOutput = orderService.GetAllUserOrders(skip, take);

                    //Assert
                    Assert.That(true, Is.True);
                }
                catch (Exception ex)
                {
                    Assert.That(false, Is.True);

                }

            }

        [TestCase("8241fe34-2302-t521-4f2d-wqn1a04247cj")]
        [TestCase("9245fe4a-d402-451c-b9ed-9c1a04247482")]
        public void Test_GetUser_GetOrderById(string strorderId)
        {
            try
            {
                Guid orderId = new Guid(strorderId);
                //Arrange
                UserOrder? userOrder = orderData._userOrders.FirstOrDefault(a => a.OrderId == orderId);
                _mockorderDataService.Setup(a => a.GetOrderDetail(orderId)).Returns(userOrder);

                //Act
                IOrderService orderService = new OrderService(_mockorderDataService.Object, _mockproductDataService.Object, _mockuserDataService.Object, _mocklogger.Object);
                var expectedOutput = orderService.GetOrderDetail(orderId);
                //todo need to check expectedOutput

                //Assert
                Assert.That(true, Is.False);
            }
            catch (Exception ex)
            {
                Assert.That(false, Is.True);

            }

        }




    }
}
