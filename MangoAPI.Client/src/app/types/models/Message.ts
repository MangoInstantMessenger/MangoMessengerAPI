export interface Message {
  messageId: string;
  userId: string;
  chatId: string;
  userDisplayName: string;
  messageText: string;
  createdAt: string;
  updatedAt: string;
  self: boolean;
  messageAuthorPictureUrl: string;
  messageAttachmentUrl: string;
  inReplayToAuthor: string,
  inReplayToText: string,
}
