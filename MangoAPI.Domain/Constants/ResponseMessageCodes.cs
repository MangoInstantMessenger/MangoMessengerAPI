namespace MangoAPI.Domain.Constants
{
    public static class ResponseMessageCodes
    {
        public const string Success = "SUCCESS";
        public const string InvalidOrExpiredRefreshToken = "INVALID_OR_EXPIRED_REFRESH_TOKEN";
        public const string EmailOccupied = "EMAIL_OCCUPIED";
        public const string InvalidCredentials = "INVALID_CREDENTIALS";
        public const string InvalidEmail = "INVALID_EMAIL";
        public const string UserNotVerified = "USER_NOT_VERIFIED";
        public const string WeakPassword = "WEAK_PASSWORD";
        public const string UserNotFound = "USER_NOT_FOUND";
        public const string EmailAlreadyVerified = "EMAIL_ALREADY_VERIFIED";
        public const string PhoneAlreadyVerified = "PHONE_ALREADY_VERIFIED";
        public const string PhoneOccupied = "PHONE_NUMBER_OCCUPIED";
        public const string PermissionDenied = "PERMISSION_DENIED";
        public const string ChatNotFound = "CHAT_NOT_FOUND";
        public const string MessageNotFound = "MESSAGE_NOT_FOUND";
        public const string UserAlreadyJoinedGroup = "USER_ALREADY_JOINED_GROUP";
        public const string DirectChatAlreadyExists = "DIRECT_CHAT_ALREADY_EXISTS";
        public const string InvalidPhoneCode = "INVALID_PHONE_CODE";
        public const string ContactAlreadyExist = "CONTACT_ALREADY_EXISTS";
        public const string DatabaseError = "DATABASE_ERROR";
    }
}