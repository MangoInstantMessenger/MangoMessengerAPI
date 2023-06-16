namespace MangoAPI.Domain;

public sealed class ChatGPTOptions
{
    public string APIKey { get; init; } = default!;
    public string OrganizationId { get; init; } = default!;
    public string Model { get; init; } = default!;
    public string DefaultResponse { get; init; } = default!;
    public int PeriodInDays { get; init; }
    public int MaxRequestsPerPeriod { get; init; }
    public string LimitViolationMessage { get; init; } = default!;
}