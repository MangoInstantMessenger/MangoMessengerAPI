using MangoAPI.Domain.Constants;
using MangoAPI.Domain.Entities;
using System;
using System.ComponentModel;

namespace MangoAPI.BusinessLogic.Models
{
    public record Message
    {
        [DefaultValue("5547b250-4d14-4a4a-88fd-66a779d4f1d2")]
        public Guid MessageId { get; init; }

        [DefaultValue("00aed827-db8c-47de-bc81-78647030918f")]
        public Guid ChatId { get; init; }

        [DefaultValue("Amelit")]
        public string UserDisplayName { get; init; }

        [DefaultValue("Hello World")]
        public string MessageText { get; init; }

        [DefaultValue("12:56")]
        public string CreatedAt { get; init; }

        [DefaultValue("12:57")]
        public string UpdatedAt { get; init; }

        [DefaultValue(false)]
        public bool Self { get; init; }

        [DefaultValue(false)]
        public bool IsEncrypted { get; init; }

        [DefaultValue(569712)]
        public int AuthorPublicKey { get; init; }

        [DefaultValue("Uploads/amelit_picture_png")]
        public string MessageAuthorPictureUrl { get; set; }
    }

    public static class MessageMapper
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