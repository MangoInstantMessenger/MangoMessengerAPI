import { DisplayNameColours } from '../enums/DisplayNameColours';

export class Message {
  messageId = '';
  chatId: string;
  userId: string;
  displayName: string;
  displayNameColour: DisplayNameColours;
  text: string;
  createdAt = '';
  updatedAt: string | null | undefined;
  self: boolean;
  authorImageUrl: string;
  attachmentUrl: string | null | undefined;
  inReplyToUser: string | null | undefined;
  inReplyToText: string | null | undefined;

  constructor(
    messageId: string,
    userId: string,
    chatId: string,
    userDisplayName: string,
    userDisplayNameColour: DisplayNameColours,
    text: string,
    createdAt: string,
    self: boolean,
    messageAuthorPictureUrl: string,
    inReplyToUser: string | null,
    inReplyToText: string | null
  ) {
    this.messageId = messageId;
    this.userId = userId;
    this.chatId = chatId;
    this.displayName = userDisplayName;
    this.displayNameColour = userDisplayNameColour;
    this.text = text;
    this.createdAt = createdAt;
    this.self = self;
    this.authorImageUrl = messageAuthorPictureUrl;
    this.inReplyToUser = inReplyToUser ?? null;
    this.inReplyToText = inReplyToText ?? null;
  }
}
