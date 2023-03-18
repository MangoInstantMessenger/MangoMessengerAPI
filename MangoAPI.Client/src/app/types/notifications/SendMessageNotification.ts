import { DisplayNameColours } from '../enums/DisplayNameColours';

export interface SendMessageNotification {
  messageId: string;
  userId: string;
  chatId: string;
  displayName: string;
  displayNameColour: DisplayNameColours;
  text: string;
  createdAt: string;
  updatedAt: string;
  inReplyToUser: string;
  inReplyToText: string;
  authorImageUrl: string;
  attachmentUrl: string;
}
