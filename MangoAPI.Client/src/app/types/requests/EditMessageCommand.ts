export class EditMessageCommand {
  messageId: string;
  chatId: string;
  modifiedText: string;

  constructor(messageId: string, chatId: string, modifiedText: string) {
    this.messageId = messageId;
    this.chatId = chatId;
    this.modifiedText = modifiedText;
  }
}
