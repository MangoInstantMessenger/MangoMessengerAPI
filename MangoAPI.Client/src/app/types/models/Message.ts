import { DisplayNameColours } from '../enums/DisplayNameColours';

export class Message {
  messageId = '';
  userId: string;
  chatId: string;
  userDisplayName: string;
  userDisplayNameColour: DisplayNameColours;
  messageText: string;
  createdAt: string;
  updatedAt: string | null | undefined;
  self: boolean;
  messageAuthorPictureUrl: string;
  messageAttachmentUrl: string | null | undefined;
  inReplyToUser: string | null | undefined;
  inReplyToText: string | null | undefined;

  constructor(
    messageId: string,
    userId: string,
    chatId: string,
    userDisplayName: string,
    userDisplayNameColour: DisplayNameColours,
    messageText: string,
    createdAt: string,
    self: boolean,
    messageAuthorPictureUrl: string,
    inReplyToUser: string | null,
    inReplyToText: string | null
  ) {
    this.messageId = messageId;
    this.userId = userId;
    this.chatId = chatId;
    this.userDisplayName = userDisplayName;
    this.userDisplayNameColour = userDisplayNameColour;
    this.messageText = messageText;
    this.createdAt = createdAt;
    this.self = self;
    this.messageAuthorPictureUrl = messageAuthorPictureUrl;
    this.inReplyToUser = inReplyToUser ?? null;
    this.inReplyToText = inReplyToText ?? null;
  }
}
