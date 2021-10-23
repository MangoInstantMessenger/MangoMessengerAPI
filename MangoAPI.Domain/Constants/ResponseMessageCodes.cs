using System.Collections.Generic;

namespace MangoAPI.Domain.Constants
{
    public static class ResponseMessageCodes
    {
        public static readonly Dictionary<string, string> ErrorDictionary = new()
        {
            { "INVALID_OR_EXPIRED_REFRESH_TOKEN", "Refresh token is invalid or expired" },
            { "INVALID_CREDENTIALS", "Email or phone or password is not valid" },
            { "USER_ALREADY_EXISTS", "User already exists" },
            { "INVALID_EMAIL", "Email is invalid" },
            { "WEAK_PASSWORD", "Password is weak" },
            { "USER_NOT_FOUND", "User does not exist" },
            { "EMAIL_ALREADY_VERIFIED", "Email already confirmed" },
            { "PHONE_ALREADY_VERIFIED", "Phone already confirmed" },
            { "PERMISSION_DENIED", "Permission denied" },
            { "CHAT_NOT_FOUND", "Chat does not exists" },
            { "MESSAGE_NOT_FOUND", "Message does not exists" },
            { "USER_ALREADY_JOINED_GROUP", "User already exists" },
            { "INVALID_PHONE_CODE", "The phone code is incorrect" },
            { "CONTACT_ALREADY_EXISTS", "Email already confirmed" },
            { "CONTACT_NOT_FOUND", "Contact does not exists" },
            { "REFRESH_TOKEN_LIFETIME_ERROR", "Refresh token lifetime can not be parsed" },
            { "INVALID_GROUP_TYPE", "Group type can not be parsed" },
            { "CANNOT_ADD_SELF_TO_CONTACTS", "Can not add self to contacts" },
            { "CANNOT_CREATE_SELF_CHAT", "Can not create self chat" },
            { "PASSWORDS_ARE_NOT_SAME", "New password and repeat password are not same" },
            { "PASSWORDS_ARE_SAME", "New password and current password are same" },
            { "USER_PUBLIC_KEY_IS_NOT_GENERATED", "User has not public key" },
            { "INVALID_OR_EXPIRED_RESTORE_PASSWORD_REQUEST", "Invalid or expired restore password request" },
            { "MAXIMUM_OWNER_CHATS_EXCEEDED_100", "The count of admins in the chat should not exceed 100 people" },
        };

        public const string Success = "SUCCESS";
        public const string InvalidOrExpiredRefreshToken = "INVALID_OR_EXPIRED_REFRESH_TOKEN";
        public const string UserAlreadyExists = "USER_ALREADY_EXISTS";
        public const string InvalidCredentials = "INVALID_CREDENTIALS";
        public const string InvalidEmail = "INVALID_EMAIL";
        public const string WeakPassword = "WEAK_PASSWORD";
        public const string UserNotFound = "USER_NOT_FOUND";
        public const string EmailAlreadyVerified = "EMAIL_ALREADY_VERIFIED";
        public const string PhoneAlreadyVerified = "PHONE_ALREADY_VERIFIED";
        public const string PhoneOccupied = "PHONE_NUMBER_OCCUPIED";
        public const string PermissionDenied = "PERMISSION_DENIED";
        public const string ChatNotFound = "CHAT_NOT_FOUND";
        public const string MessageNotFound = "MESSAGE_NOT_FOUND";
        public const string UserAlreadyJoinedGroup = "USER_ALREADY_JOINED_GROUP";
        public const string InvalidPhoneCode = "INVALID_PHONE_CODE";
        public const string ContactAlreadyExist = "CONTACT_ALREADY_EXISTS";
        public const string ContactNotFound = "CONTACT_NOT_FOUND";
        public const string RefreshTokenLifeTimeError = "REFRESH_TOKEN_LIFETIME_ERROR";
        public const string InvalidGroupType = "INVALID_GROUP_TYPE";
        public const string CannotAddSelfToContacts = "CANNOT_ADD_SELF_TO_CONTACTS";
        public const string CannotCreateSelfChat = "CANNOT_CREATE_SELF_CHAT";
        public const string PasswordsAreNotSame = "PASSWORDS_ARE_NOT_SAME";
        public const string PasswordsAreSame = "PASSWORDS_ARE_SAME";
        public const string InvalidOrExpiredRestorePasswordRequest = "INVALID_OR_EXPIRED_RESTORE_PASSWORD_REQUEST";
        public const string UserPublicKeyIsNotGenerated = "USER_PUBLIC_KEY_IS_NOT_GENERATED";
        public const string MaximumOwnerChatsExceeded100 = "MAXIMUM_OWNER_CHATS_EXCEEDED_100";
    }
}