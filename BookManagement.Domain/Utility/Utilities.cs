using BookManagement.Domain.API;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookManagement.Domain.Utility
{
    public class Utilities
    {
        public static Response InitializeResponse()
        {
            var response = new Response();
            response.RequestId = Guid.NewGuid().ToString();
            response.RequestCode = "00";
            response.RequestMessage = "Successful";
            return response;
        }
    }
}
