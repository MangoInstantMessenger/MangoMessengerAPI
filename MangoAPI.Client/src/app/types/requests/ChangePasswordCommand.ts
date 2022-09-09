export class ChangePasswordCommand {
  currentPassword: string;
  newPassword: string;
  repeatNewPassword: string;

  constructor(currentPassword: string, newPassword: string, repeatNewPassword: string) {
    this.currentPassword = currentPassword;
    this.newPassword = newPassword;
    this.repeatNewPassword = repeatNewPassword;
  }
}
