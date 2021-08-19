namespace MangoAPI.BusinessLogic.BusinessExceptions
{
    using System;

    public class BusinessException : Exception
    {
        public BusinessException(string message)
            : base(message)
        {
        }
    }
}
