export class ResetPasswordRequest {
  requestId: string | null;
  newPassword: string;
  repeatPassword: string;

  constructor(
    requestId: string | null,
    newPassword: string,
    repeatPassword: string
  ) {
    this.requestId = requestId;
    this.newPassword = newPassword;
    this.repeatPassword = repeatPassword;
  }
}
