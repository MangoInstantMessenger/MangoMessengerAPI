export interface DeleteMessageNotification {
  chatId: string;
  deletedMessageId: string;
  newLastMessageText: string;
  newLastMessageTime: string;
  newLastMessageId: string;
  newLastMessageDisplayName: string;
  isLastMessage: boolean;
}
