export interface DeleteMessageNotification {
  userId: string;
  chatId: string;
  deletedMessageId: string;
  newLastMessageText: string;
  newLastMessageTime: string;
  newLastMessageId: string;
  newLastMessageDisplayName: string;
  isLastMessage: boolean;
}
