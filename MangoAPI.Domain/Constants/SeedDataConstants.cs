using System;

namespace MangoAPI.Domain.Constants
{
    public static class SeedDataConstants
    {
        // User Id
        public static Guid KhachaturId = "e77cf2cb-3f3a-4f0b-ac5a-90a3263d075a".AsGuid();
        public static Guid RazumovskyId = "fd3c67c5-c6ff-4a5d-a166-98ece1b7752b".AsGuid();
        public static Guid KolbasatorId = "5b515247-f6f5-47e1-ad06-95f317a0599b".AsGuid();
        public static Guid AmelitId = "d942706b-e4e2-48f9-bbdc-b022816471f0".AsGuid();
        public static Guid PetroId = "2cd4b9a0-f70d-476d-a3cc-908da43f93c4".AsGuid();
        public static Guid SzymonId = "5e7274ad-3132-4ad7-be36-38778a8f7b1c".AsGuid();
        public static Guid IlliaId = "72a7a013-8bc4-4ae6-89cb-d9f19e0c9cf9".AsGuid();
        public static Guid ArslanbekId = "56d6294f-7b80-4a78-856a-92b141de2d1c".AsGuid();
        public static Guid SerhiiId = "d1ae1de1-1aa8-4650-937c-4ed882038ad7".AsGuid();

        // Public Chats
        public static Guid ExtremeCodeMainId = "0dae5a74-3528-4e85-95bb-2036bd80432c".AsGuid();
        public static Guid ExtremeCodeFloodId = "5e656ec2-205f-471c-b095-1c80b93b7655".AsGuid();
        public static Guid ExtremeCodeCppId = "cd358b94-c3b9-4022-923a-13f787f70055".AsGuid();
        public static Guid ExtremeCodeDotnetId = "6f66e318-1e94-44ae-9b33-fe001e070842".AsGuid();
        public static Guid WsbId = "b6ca4533-fc21-4f44-9747-687361e3031c".AsGuid();

        // Direct Chats
        public static Guid DirectKhachaturKolbasator = "9f205dde-0ddc-401f-8fe9-6c794b661f5d".AsGuid();
        public static Guid DirectKhachaturRazumovsky = "f5b7824f-e52b-4246-9984-06fc8e964f0c".AsGuid();
        public static Guid DirectKolbasatorRazumovsky = "f8729a12-5746-443f-ad31-378d846fce30".AsGuid();
        public static Guid DirectAmelitRazumovsky = "b119914a-6d95-4047-bf8a-db27deeb7dc9".AsGuid();
        public static Guid DirectPetroSzymon = "3fce8b2c-252d-4514-a1bb-fbdf73c47b78".AsGuid();

        // Role ID
        public static Guid UserRoleId = "32904a05-6d7c-43cf-b915-223324ff480e".AsGuid();
        public static Guid UnverifiedRoleId = "1c48f8d5-01ed-4e47-8377-a22ffa58c150".AsGuid();

        // Roles
        public const string UserRole = "User";
        public const string UnverifiedRole = "Unverified";
    }

    public static class StringExtensions
    {
        public static Guid AsGuid(this string str)
        {
            return Guid.Parse(str);
        }
    }
}