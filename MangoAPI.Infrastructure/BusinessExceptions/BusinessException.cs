namespace MangoAPI.Infrastructure.BusinessExceptions
{
    public class BusinessException : System.Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}