import { DisplayNameColours } from '../enums/DisplayNameColours';

export class Message {
  messageId = '';
  chatId: string;
  userId: string;
  userDisplayName: string;
  userDisplayNameColour: DisplayNameColours;
  text: string;
  createdAt = '';
  updatedAt: string | null | undefined;
  self: boolean;
  authorImageUrl: string;
  attachmentUrl: string | null | undefined;
  inReplyToUser: string | null | undefined;
  inReplyToText: string | null | undefined;

  constructor(
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
    this.userId = userId;
    this.chatId = chatId;
    this.userDisplayName = userDisplayName;
    this.userDisplayNameColour = userDisplayNameColour;
    this.text = text;
    this.createdAt = createdAt;
    this.self = self;
    this.authorImageUrl = messageAuthorPictureUrl;
    this.inReplyToUser = inReplyToUser ?? null;
    this.inReplyToText = inReplyToText ?? null;
  }
}
