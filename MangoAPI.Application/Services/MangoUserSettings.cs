using MangoAPI.Application.Interfaces;

namespace MangoAPI.Application.Services;

public record MangoUserSettings(string Password) : IMangoUserSettings;