using MangoAPI.BusinessLogic.ApiCommands.Users;

namespace MangoAPI.IntegrationTests.Helpers;

public class CommandHelper
{
    public static RegisterCommand RegisterKhachaturCommand()
    {
        var command = new RegisterCommand(
            email: "xachulxx@gmail.com",
            displayName: "Khachatur Khachatryan",
            password: "Bm3-`dPRv-/w#3)cw^97",
            termsAccepted: true);

        return command;
    }

    public static RegisterCommand RegisterPetroCommand()
    {
        var command = new RegisterCommand(
            email: "kolosovp95@gmail.com",
            displayName: "Petro Kolosov",
            password: "Bm3-`dPRv-/w#3)cw^97",
            termsAccepted: true);

        return command;
    }
}