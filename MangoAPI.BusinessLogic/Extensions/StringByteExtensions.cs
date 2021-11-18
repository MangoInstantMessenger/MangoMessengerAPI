using System;

namespace MangoAPI.BusinessLogic.Extensions
{
    public static class StringByteExtensions
    {
        public static byte[] StringAsBytes(this string str)
        {
            return Convert.FromBase64String(str);
        }

        public static string AsBase64String(this byte[] byteArray)
        {
            return Convert.ToBase64String(byteArray);
        }
    }
}