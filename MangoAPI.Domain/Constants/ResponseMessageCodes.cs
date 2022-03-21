using System.Collections.Generic;

namespace MangoAPI.Domain.Constants;

public static class ResponseMessageCodes
{
    public static readonly Dictionary<string, string> ErrorDictionary = new()
    {
        {InvalidOrExpiredRefreshToken, "Your refresh token is invalid or expired."},
        {UserAlreadyExists, "User already exists in the system."},
        {InvalidCredentials, "Invalid credentials. Please, enter valid email and password."},
        {
            WeakPassword,
            "Password is weak. It must be at least 8 characters include lower case, " +
            "upper case letters, one digit, one special symbol."
        },
        {UserNotFound, "User not found in the system."},
        {EmailAlreadyVerified, "Email address of your account is already confirmed."},
        {PermissionDenied, "You are not authorized to perform this action."},
        {ChatNotFound, "Cannot found this chat it the system."},
        {UserAlreadyJoinedGroup, "You are already a member of the community."},
        {ContactAlreadyExist, "User is your contact already."},
        {ContactNotFound, "User is not found in your contact list."},
        {CannotAddSelfToContacts, "You cannot add yourself to the contacts."},
        {CannotCreateSelfChat, "You cannot create a direct chat with yourself."},
        {InvalidOrExpiredRestorePasswordRequest, "Invalid or expired restore password request. Try again."},
        {MaximumOwnerChatsExceeded100, "One user cannot create more than 100 channels."},
        {InvalidEmailConfirmationCode, "Email confirmation code is invalid. Try again."},
        {InvalidRequestModel, "Invalid request format. Correct input data and try again."},
        {
            MaximumMessageCountInLast5MinutesExceeded100,
            "One user cannot send message more then 100 to particular chat in last 5 minutes"
        },
        {
            KeyExchangeRequestAlreadyExists,
            "You have already requested current user for key exchange. Wait for response."
        },
        {
            KeyExchangeRequestNotFound,
            "Key exchange request not found. Either request is not submitted yet or declined."
        },
        {ChangePasswordRequestExists, "Change password request already sent. Verify your email."},
        {
            UploadedDocumentsLimitReached10,
            "You have reached maximum amount of documents upload 10. Try again in 1 hour."
        },
        {EmailIsNotVerified, "Your email is not verified. Check your inbox for confirmation link."},
        {SessionNotFound, "Session not found."},
        {MessageNotFound, "Message doesn't found in the system"},
        {DhParameterNotFound, "Diffie-Hellman parameter is not initialized. Please initialize first."},
        {TokensNotFound, "Tokens not found. Please login to the system first."},
        {KeyExchangeIsNotConfirmed, "Key exchange is not confirmed yet, please wait for response."},
        {KeyExchangeDoesNotBelongToUser, "Key exchange does not belong to you."}
    };

    public const string Success = "SUCCESS";
    public const string InvalidOrExpiredRefreshToken = "INVALID_OR_EXPIRED_REFRESH_TOKEN";
    public const string UserAlreadyExists = "USER_ALREADY_EXISTS";
    public const string InvalidCredentials = "INVALID_CREDENTIALS";
    public const string WeakPassword = "WEAK_PASSWORD";
    public const string UserNotFound = "USER_NOT_FOUND";
    public const string EmailAlreadyVerified = "EMAIL_ALREADY_VERIFIED";
    public const string PermissionDenied = "PERMISSION_DENIED";
    public const string ChatNotFound = "CHAT_NOT_FOUND";
    public const string UserAlreadyJoinedGroup = "USER_ALREADY_JOINED_GROUP";
    public const string ContactAlreadyExist = "CONTACT_ALREADY_EXISTS";
    public const string ContactNotFound = "CONTACT_NOT_FOUND";
    public const string CannotAddSelfToContacts = "CANNOT_ADD_SELF_TO_CONTACTS";
    public const string CannotCreateSelfChat = "CANNOT_CREATE_SELF_CHAT";
    public const string InvalidOrExpiredRestorePasswordRequest = "INVALID_OR_EXPIRED_RESTORE_PASSWORD_REQUEST";
    public const string MaximumOwnerChatsExceeded100 = "MAXIMUM_OWNER_CHATS_EXCEEDED_100";
    public const string InvalidEmailConfirmationCode = "INVALID_EMAIL_CONFIRMATION_CODE";
    public const string InvalidRequestModel = "INVALID_REQUEST_FORMAT";
    public const string ChangePasswordRequestExists = "CHANGE_PASSWORD_REQUEST_EXISTS_ALREADY";

    public const string MaximumMessageCountInLast5MinutesExceeded100 =
        "MAXIMUM_MESSAGE_COUNT_IN_LAST_5_MINUTES_EXCEEDED_100";

    public const string KeyExchangeRequestAlreadyExists = "KEY_EXCHANGE_REQUEST_ALREADY_EXISTS";
    public const string KeyExchangeRequestNotFound = "KEY_EXCHANGE_REQUEST_NOT_FOUND";
    public const string UploadedDocumentsLimitReached10 = "UPLOADED_DOCUMENTS_LIMIT_REACHED";
    public const string EmailIsNotVerified = "EMAIL_IS_NOT_VERIFIED";
    public const string SessionNotFound = "SESSION_NOT_FOUND";
    public const string MessageNotFound = "MESSAGE_NOT_FOUND";
    public const string DhParameterNotFound = "DH_PARAMETER_NOT_FOUND";
    public const string TokensNotFound = "TOKENS_NOT_FOUND";
    public const string KeyExchangeIsNotConfirmed = "KEY_EXCHANGE_IS_NOT_CONFIRMED";
    public const string KeyExchangeDoesNotBelongToUser = "KEY_EXCHANGE_DOES_NOT_BELONG_TO_USER";
}