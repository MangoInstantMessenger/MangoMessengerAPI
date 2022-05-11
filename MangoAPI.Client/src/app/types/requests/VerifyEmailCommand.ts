export class VerifyEmailCommand {
  email: string | null;
  emailCode: string | null;

  constructor(email: string | null, userId: string | null) {
    this.email = email;
    this.emailCode = userId;
  }
}
