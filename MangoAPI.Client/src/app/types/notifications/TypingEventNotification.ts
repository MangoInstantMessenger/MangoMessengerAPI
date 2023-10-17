export interface TypingEventNotification {
  userId: string;
  chatId: string;
  displayName: string;

  timeout: NodeJS.Timeout;
}
