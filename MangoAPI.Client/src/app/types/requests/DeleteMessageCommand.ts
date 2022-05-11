export class DeleteMessageCommand {
  messageId: string;
  chatId: string;
  
  constructor(messageId: string, chatId: string) {
    this.messageId = messageId;
    this.chatId = chatId;
  }
}
