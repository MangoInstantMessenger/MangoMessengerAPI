using System;
using System.Runtime.Serialization;

namespace MangoAPI.BusinessLogic.BusinessExceptions
{
    [Serializable]
    public class BusinessException : Exception
    {
        protected BusinessException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }

        public BusinessException(string message) : base(message)
        {
        }
    }
}