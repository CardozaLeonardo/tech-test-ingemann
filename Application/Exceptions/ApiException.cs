using System;

namespace Application.Exceptions
{
    public class ApiException: Exception
    {
        public int HttpStatusCode { get; set; }

        public ApiException(string message): base(message)
        {
            
        }
    }
}
