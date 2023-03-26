using System.Collections.Generic;
using System.Collections.Immutable;

namespace MangoAPI.Domain.Constants;

public static class ResponseMessageCodes
{
    public static ImmutableDictionary<string, string> ErrorDictionary => Dictionary.ToImmutableDictionary();

    public const string Unauthorized = "UNAUTHORIZED";
    public const string Success = "SUCCESS";
    public const string InvalidOrExpiredRefreshToken = "INVALID_OR_EXPIRED_REFRESH_TOKEN";
    public const string UserAlreadyExists = "USER_ALREADY_EXISTS";
    public const string InvalidCredentials = "INVALID_CREDENTIALS";
    public const string UserNotFound = "USER_NOT_FOUND";
    public const string PermissionDenied = "PERMISSION_DENIED";
    public const string ChatNotFound = "CHAT_NOT_FOUND";
    public const string UserAlreadyJoinedGroup = "USER_ALREADY_JOINED_GROUP";
    public const string ContactAlreadyExist = "CONTACT_ALREADY_EXISTS";
    public const string ContactNotFound = "CONTACT_NOT_FOUND";
    public const string CannotAddSelfToContacts = "CANNOT_ADD_SELF_TO_CONTACTS";
    public const string CannotCreateSelfChat = "CANNOT_CREATE_SELF_CHAT";
    public const string InvalidRequestModel = "INVALID_REQUEST_FORMAT";
    public const string KeyExchangeRequestNotFound = "KEY_EXCHANGE_REQUEST_NOT_FOUND";
    public const string MessageNotFound = "MESSAGE_NOT_FOUND";
    public const string DhParameterNotFound = "DH_PARAMETER_NOT_FOUND";
    public const string TokensNotFound = "TOKENS_NOT_FOUND";
    public const string KeyExchangeIsNotConfirmed = "KEY_EXCHANGE_IS_NOT_CONFIRMED";
    public const string KeyExchangeDoesNotBelongToUser = "KEY_EXCHANGE_DOES_NOT_BELONG_TO_USER";

    private static readonly Dictionary<string, string> Dictionary = new()
    {
        { InvalidOrExpiredRefreshToken, "Your refresh token is invalid or expired." },
        { UserAlreadyExists, "User already exists in the system." },
        { InvalidCredentials, "Invalid credentials. Please, enter valid username and password." },
        { UserNotFound, "User not found in the system." },
        { PermissionDenied, "You are not authorized to perform this action." },
        { ChatNotFound, "Cannot found this chat it the system." },
        { UserAlreadyJoinedGroup, "You are already a member of the community." },
        { ContactAlreadyExist, "User is your contact already." },
        { ContactNotFound, "User is not found in your contact list." },
        { CannotAddSelfToContacts, "You cannot add yourself to the contacts." },
        { CannotCreateSelfChat, "You cannot create a direct chat with yourself." },
        { InvalidRequestModel, "Invalid request format. Correct input data and try again." },
        {
            KeyExchangeRequestNotFound,
            "Key exchange request not found. Either request is not submitted yet or declined."
        },
        { MessageNotFound, "Message doesn't found in the system" },
        { DhParameterNotFound, "Diffie-Hellman parameter is not initialized. Please initialize first." },
        { TokensNotFound, "Tokens not found. Please login to the system first." },
        { KeyExchangeIsNotConfirmed, "Key exchange is not confirmed yet, please wait for response." },
        { KeyExchangeDoesNotBelongToUser, "Key exchange does not belong to you." },
        { Unauthorized, "User not authorized, please, sign in." }
    };
}