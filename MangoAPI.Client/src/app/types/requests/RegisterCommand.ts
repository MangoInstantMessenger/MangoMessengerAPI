export class RegisterCommand {
  email: string;
  displayName: string;
  password: string;
  termsAccepted: boolean;

  constructor(email: string, displayName: string, password: string, termsAccepted: boolean) {
    this.email = email;
    this.displayName = displayName;
    this.password = password;
    this.termsAccepted = termsAccepted;
  }
}
