export class Message {
  messageId: string = '';
  userId: string;
  chatId: string;
  userDisplayName: string;
  messageText: string;
  createdAt: string;
  updatedAt: string | null | undefined;
  self: boolean;
  messageAuthorPictureUrl: string;
  messageAttachmentUrl: string | null | undefined;
  inReplayToAuthor: string | null | undefined;
  inReplayToText: string | null | undefined;


  constructor(
    messageId: string,
    userId: string,
    chatId: string,
    userDisplayName: string,
    messageText: string,
    createdAt: string,
    self: boolean,
    messageAuthorPictureUrl: string) {
    this.messageId = messageId;
    this.userId = userId;
    this.chatId = chatId;
    this.userDisplayName = userDisplayName;
    this.messageText = messageText;
    this.createdAt = createdAt;
    this.self = self;
    this.messageAuthorPictureUrl = messageAuthorPictureUrl;
  }
}
