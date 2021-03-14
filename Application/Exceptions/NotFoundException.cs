namespace Application.Exceptions
{
    public class NotFoundException: ApiException
    {
        public NotFoundException(string message): base(message)
        {
            this.HttpStatusCode = 404;
        }
    }
}