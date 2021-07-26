using System;

namespace MangoAPI.Infrastructure.BusinessExceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string message) : base(message)
        {
        }
    }
}