namespace Application.Wrappers
{
    public class Response<T>
    {
        public Response()
        {
            
        }

        public Response(T data, string message = null)
        {
            Succeeded = true;
            Message = message;
            Data = data;
        }

        public Response(string message)
        {
            Message = message;
            Succeeded = false;
        }
        
        public bool Succeeded { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}