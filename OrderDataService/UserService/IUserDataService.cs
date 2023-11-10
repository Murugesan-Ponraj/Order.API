using Order.API.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.DataService.UserService
{
    public interface IUserDataService
    {
        List<UserMaster> GetAllUsers();

        UserMaster GetUserById(int id);
    }
}
