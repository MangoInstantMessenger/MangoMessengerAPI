using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models
{
    public record Tokens
    {
        [DefaultValue("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9." +
                      "eyJzdWIiOiIxMjM0NTY3ODkwIiwibmFtZSI6IkpvaG4gRG9lIiwiaWF0IjoxNTE2MjM5MDIyfQ." +
                      "dx3130em1lsy-kozQxdng2pgIof2lc7e9yy983ZP_xU")]
        public string AccessToken { get; init; }

        [DefaultValue("e790be58-115f-43a2-be30-f6b65e6cf2df")]
        public Guid RefreshToken { get; init; }
        
        [DefaultValue("28aac181-2a67-4d09-a1fc-749fd3705804")]
        public Guid UserId { get; init; }
        
        [DefaultValue(1633084830)]
        public long Expires { get; init; }
    }
}