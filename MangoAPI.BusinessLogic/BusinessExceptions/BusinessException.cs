using System;

namespace MangoAPI.BusinessLogic.BusinessExceptions
{
    public class BusinessException : Exception
    {
        public BusinessException(string message)
            : base(message)
        {
        }
    }
}
