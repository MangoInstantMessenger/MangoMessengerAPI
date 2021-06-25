using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MangoAPI.Domain.Auth
{
    public class RegisterRequestEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}