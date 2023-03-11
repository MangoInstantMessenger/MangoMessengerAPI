export class RegisterCommand {
  email: string;
  displayName: string;
  password: string;

  constructor(email: string, displayName: string, password: string) {
    this.email = email;
    this.displayName = displayName;
    this.password = password;
  }
}
