using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Order.API.Models
{
    public class ApiResponse
    {
        public HttpStatusCode Status { get; set; }

        public dynamic Result { get; set; } 

        public string Message { get; set; }

        public ApiResponse()
        {
         

        }
        public ApiResponse(dynamic result)
        {
            Status = HttpStatusCode.OK;
            Message =
            Result = result; 
        }
        public ApiResponse (Exception e)
        {
            Status = HttpStatusCode.InternalServerError;
            Message = e.Message;
            Result = e;
          
        }

        public ApiResponse Succees(dynamic result)
        {
            Status = HttpStatusCode.OK;
            Result = result;
            return this;
        }

        public ApiResponse Failed(string message)
        {
            Status = HttpStatusCode.InternalServerError; 
            Message = message;
            return this;
        }

    }
}
