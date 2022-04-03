namespace MangoAPI.DiffieHellmanLibrary.Extensions;

public static class StringByteExtensions
{
    public static byte[] Base64StringAsBytes(this string str)
    {
        return Convert.FromBase64String(str);
    }

    public static string AsBase64String(this byte[] byteArray)
    {
        return Convert.ToBase64String(byteArray);
    }
}