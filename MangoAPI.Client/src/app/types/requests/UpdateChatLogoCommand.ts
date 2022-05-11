export class UpdateChatLogoCommand {
  chatId: string | null;
  image: string | null;

  constructor(chatId: string | null, image: string | null) {
    this.chatId = chatId;
    this.image = image;
  }
}
