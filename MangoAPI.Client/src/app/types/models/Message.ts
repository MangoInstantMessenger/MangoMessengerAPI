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
  inReplayToAuthor: string | null | undefined;
  inReplayToText: string | null | undefined;

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
    inReplayToAuthor: string | null,
    inReplayToText: string | null
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
    this.inReplayToAuthor = inReplayToAuthor ?? null;
    this.inReplayToText = inReplayToText ?? null;
  }
}
