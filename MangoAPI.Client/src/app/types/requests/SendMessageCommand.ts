export class SendMessageCommand {
  messageText: string;
  chatId: string;
  isEncrypted = false;
  attachmentUrl: string | null = null;
  inReplayToAuthor: string | null = null;
  inReplayToText: string | null = null;
  createdAt: string | null = null;
  messageId: string | null = null;

  constructor(content: string, chatId: string) {
    this.messageText = content;
    this.chatId = chatId;
  }

  setAttachmentUrl(url: string | null): void {
    this.attachmentUrl = url;
  }

  setReplayToAuthor(author: string | null): void {
    this.inReplayToAuthor = author;
  }

  setReplayToText(text: string | null): void {
    this.inReplayToText = text;
  }

  setCreatedAt(text: string | null): void {
    this.createdAt = text;
  }

  setMessageId(text: string | null): void {
    this.messageId = text;
  }
}
