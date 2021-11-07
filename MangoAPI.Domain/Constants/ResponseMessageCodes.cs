using System.Collections.Generic;

namespace MangoAPI.Domain.Constants
{
    public static class ResponseMessageCodes
    {
        public static readonly Dictionary<string, string> ErrorDictionary = new()
        {
            {InvalidOrExpiredRefreshToken, "Your refresh token is invalid or expired."},
            {UserAlreadyExists, "User already exists in the system."},
            {InvalidCredentials, "Invalid credentials. Please, enter valid email/phone and password."},
            {InvalidEmail, "Email address is invalid."},
            {
                WeakPassword,
                "Password is weak. It must be at least 8 characters include lower case, " +
                "upper case letters, one digit, one special symbol."
            },
            {UserNotFound, "User not found in the system."},
            {EmailAlreadyVerified, "Email address of your account is already confirmed."},
            {PhoneAlreadyVerified, "Phone number of your account is already confirmed."},
            {PermissionDenied, "You are not authorized to perform this action."},
            {ChatNotFound, "Cannot found this chat it the system."},
            {MessageNotFound, "Message does not exists."},
            {UserAlreadyJoinedGroup, "You are already a member of the community."},
            {InvalidPhoneCode, "The phone code is incorrect. Try again."},
            {ContactAlreadyExist, "User is your contact already."},
            {ContactNotFound, "User is not found in your contact list."},
            {RefreshTokenLifeTimeError, "Refresh token lifetime can not be parsed."},
            {InvalidGroupType, "Group type can not be parsed."},
            {CannotAddSelfToContacts, "You cannot add yourself to the contacts."},
            {CannotCreateSelfChat, "You cannot create a direct chat with yourself."},
            {PasswordsAreNotSame, "New password and repeat password are not the same."},
            {PasswordsAreSame, "New password and current password are the same."},
            {InvalidOrExpiredRestorePasswordRequest, "Invalid or expired restore password request. Try again."},
            {MaximumOwnerChatsExceeded100, "One user cannot create more than 100 channels."},
            {InvalidEmailConfirmationCode, "Email confirmation code is invalid. Try again."},
            {InvalidRequestModel, "Invalid request format. Correct input data and try again."},
            {
                MaximumMessageCountInLast5MinutesExceeded100,
                "One user cannot send message more then 100 to particular chat in last 5 minutes"
            },
            {TooFrequentRequest, "Your request is too frequent. Try again in 30 seconds."}
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
        public const string MaximumOwnerChatsExceeded100 = "MAXIMUM_OWNER_CHATS_EXCEEDED_100";
        public const string InvalidEmailConfirmationCode = "INVALID_EMAIL_CONFIRMATION_CODE";
        public const string InvalidRequestModel = "INVALID_REQUEST_FORMAT";

        public const string MaximumMessageCountInLast5MinutesExceeded100 =
            "MAXIMUM_MESSAGE_COUNT_IN_LAST_5_MINUTES_EXCEEDED_100";

        public const string TooFrequentRequest = "TOO_FREQUENT_REQUEST";
    }
}