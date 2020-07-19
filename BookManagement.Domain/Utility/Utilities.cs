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
            var response = new Response
            {
                RequestId = Guid.NewGuid().ToString(),
                RequestCode = "00",
                RequestMessage = "Successful"
            };
            return response;
        }
    }
}
