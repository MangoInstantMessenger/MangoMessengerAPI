using System;
using System.Collections.Generic;

namespace MangoAPI.Environment
{
    public static class Program
    {
        private static void Main()
        {
            SetEnvironmentVariables();

            Console.WriteLine("Environmental variables initialized successfully.");
        }

        private static void SetEnvironmentVariables()
        {
            var dictionary = new Dictionary<string, string>
            {
                {"MANGO_ISSUER", "https://localhost:5001"},
                {"MANGO_AUDIENCE", "https://localhost:5000"},
                {"MANGO_TOKEN_KEY", Guid.NewGuid().ToString()},
                {"JWT_LIFETIME", "5"},
                {"REFRESH_TOKEN_LIFETIME", "7"},
                {"FRONTEND_ADDRESS", "http://localhost:4200"}
            };

            foreach (var item in dictionary)
            {
                if (System.Environment.GetEnvironmentVariable(item.Key) != null) continue;

                System.Environment.SetEnvironmentVariable(item.Key, item.Value, EnvironmentVariableTarget.User);
            }
        }
    }
}