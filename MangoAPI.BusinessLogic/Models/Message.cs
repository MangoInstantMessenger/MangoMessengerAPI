using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using System;

namespace MangoAPI.BusinessLogic.Models
{
    public record Message
    {
        public Guid MessageId { get; init; }

        public Guid ChatId { get; init; }

        public Guid UserId { get; init; }

        public string UserDisplayName { get; init; }

        public string MessageText { get; init; }

        public string CreatedAt { get; init; }

        public string UpdatedAt { get; init; }

        public bool Self { get; init; }

        public bool IsEncrypted { get; init; }

        public int AuthorPublicKey { get; init; }

        public string MessageAuthorPictureUrl { get; set; }
    }

    public static class MesasgeMapper
    {
        public static Message ToMessage(this MessageEntity message, UserEntity user)
        {
            return new()
            {
                MessageId = message.Id,
                UserId = message.UserId,
                ChatId = message.ChatId,
                UserDisplayName = user.DisplayName,
                MessageText = message.Content,
                CreatedAt = message.CreatedAt.ToShortTimeString(),
                UpdatedAt = message.UpdatedAt?.ToShortTimeString(),
                Self = true,
                IsEncrypted = message.IsEncrypted,
                AuthorPublicKey = message.AuthorPublicKey,
                MessageAuthorPictureUrl = user.Image != null
                    ? $"{EnvironmentConstants.BackendAddress}Uploads/{user.Image}"
                    : null,
            };
        }
    }
}