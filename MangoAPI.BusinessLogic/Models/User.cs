namespace MangoAPI.DTO.Models
{
    public record User
    {
        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Username { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string DisplayName { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Bio { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Global
        public string Image { get; init; }
    }
}