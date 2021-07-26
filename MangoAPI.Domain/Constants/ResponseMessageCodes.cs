namespace MangoAPI.Domain.Constants
{
    public static class ResponseMessageCodes
    {
        public const string Success = "SUCCESS";
        public const string InvalidOrEmptyRefreshToken = "INVALID_OR_EMPTY_REFRESH_TOKEN";
        public const string EmailOccupied = "EMAIL_OCUUPIED";
        public const string TermsNotAccepted = "TERMS_NOT_ACCEPTED";
        public const string InvalidCredentials = "INVALID_LOGIN_OR_PASSWORD";
        public const string ConfirmRegisterInvalidIdentifier = "INVALID_CONFIRMATION_IDENTIFIER";
        public const string InvalidEmail = "INVALID_EMAIL";
        public const string UserUnverified = "UNVERIFIED_USER";
        public const string WeakPassword = "WEAK_PASSWORD";
        public const string InvalidUserId = "INVALID_USER_ID";
        public const string UserNotFound = "USER_NOT_FOUND";
        public const string EmailAlreadyVerified = "EMAIL_ALREADY_VERIFIED";
        public const string PhoneAlreadyVerified = "PHONE_ALREADY_VERIFIED";
        public const string PhoneOccupied = "PHONE_NUMBER_OCCUPIED";
        public const string InvalidOrEmptyGroupTitle = "INVALID_OR_EMPTY_GROUP_TITLE";
        public const string InvalidGroupType = "INVALID_GROUP_TYPE";
        public const string PermissionDenied = "PERMISSION_DENIED";
        public const string ChatNotFound = "CHAT_NOT_FOUND";
        public const string MessageNotFound = "MESSAGE_NOT_FOUND";
        public const string UserAlreadyJoined = "USER_ALREADY_JOINED_OR_BLOCKED";
        public const string InvalidVerificationMethod = "INVALID_VERIFICATION_METHOD";
        public const string DirectChatAlreadyExists = "DIRECT_CHAT_ALREADY_EXISTS";
        public const string InvalidDisplayName = "INVALID_DISPLAY_NAME";
        public const string EmptyMessage = "CANNOT_SEND_EMPTY_MESSAGE";
        public const string ValidationError = "VALIDATION_ERROR";
        public const string InvalidPhoneCode = "INVALID_PHONE_CODE";
        public const string InternalServerError = "INTERNAL_SERVER_ERROR";
    }
}