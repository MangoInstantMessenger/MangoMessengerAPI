export class CreateChatCommand {
  partnerId: string;

  constructor(partnerId: string) {
    this.partnerId = partnerId;
  }
}
