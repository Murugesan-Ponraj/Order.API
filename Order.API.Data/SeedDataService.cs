using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Order.API.Data.Models;

namespace Order.API.Data
{
    public  class SeedDataService
    {

        public  List<ProductMaster> _productMasters;
        public  List<UserMaster> _users;

        /// <summary>
        /// Create Seed Datas for tables
        /// </summary>
        public SeedDataService()
        {
            _users = new List<UserMaster>() {
                  new UserMaster(){ Id = 1,  UserName = "Admin", FirstName = "System",LastName = "Admin" },
                   new UserMaster(){ Id = 2,  UserName = "Muru", FirstName = "Muru",LastName = "Pon" },
                    new UserMaster(){ Id = 3,  UserName = "Test", FirstName = "Test",LastName = "Test" }
            };
            _productMasters = new List<ProductMaster>() { 
             new ProductMaster(){
                 Id = 1, 
                 ProductName = "OnePlus 10T" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true, 
             },
                 new ProductMaster(){
                 Id = 2,
                 ProductName = "OnePlus 7T" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             }  ,
                 new ProductMaster(){
                 Id = 3,
                 ProductName = "OnePlus 6T" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             },
                 new ProductMaster(){
                 Id = 4,
                 ProductName = "OnePlus 5T" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             },
                 new ProductMaster(){
                 Id = 5,
                 ProductName = "OnePlus 8T" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             },
                 new ProductMaster(){
                 Id = 6,
                 ProductName = "OnePlus 9" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             },
                 new ProductMaster(){
                 Id = 7,
                 ProductName = "OnePlus 7T Pro" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             },
                 new ProductMaster(){
                 Id = 8,
                 ProductName = "OnePlus 6T prod" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             },
                 new ProductMaster(){
                 Id = 9,
                 ProductName = "OnePlus 6" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             },
                 new ProductMaster(){
                 Id = 10,
                 ProductName = "OnePlus 9T pro" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             },
                 new ProductMaster(){
                 Id = 11,
                 ProductName = "OnePlus 10 pro" ,
                 ProductType = "Mobile",
                 Description = "Mobiles phone" ,
                  PublishedBy = "OnePlus Store",
                  IsActive = true,
             }
            };

        }


    }
}
