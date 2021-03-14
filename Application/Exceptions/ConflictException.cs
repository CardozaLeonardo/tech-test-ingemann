namespace Application.Exceptions
{
    public class ConflictException: ApiException
    {
        public ConflictException(string message) : base(message)
        {
            this.HttpStatusCode = 409;
        }
    }
}