import {Injectable} from "@angular/core";
import * as signalR from "@microsoft/signalr";
import {DeleteMessageNotification} from "src/app/types/models/DeleteMessageNotification";
import {Chat} from "../../types/models/Chat";
import {Message} from "../../types/models/Message";

@Injectable({
  providedIn: 'root'
})
export class SignalrService {
  public connectChatsToHub(
    connection: signalR.HubConnection,
    chats: Chat[],
    realTimeConnections: string[],
    userId: string | undefined): void {
    connection.start().then(() => {
      chats.forEach(x => {
        if (realTimeConnections.includes(x.chatId)) {
          return;
        }

        connection.invoke("JoinGroup", x.chatId).then(() => realTimeConnections.push(x.chatId));
      });

      if (userId && realTimeConnections.includes(userId)) {
        return;
      }

      connection.invoke("JoinGroup", userId).then(r => r);

    }).catch(err => console.error(err.toString()));
  }

  public setSignalRMethods(
    connection: signalR.HubConnection,
    userId: string | undefined,
    activeChat: Chat,
    chats: Chat[],
    messages: Message[], bumpChat: any): void {

    connection.on("BroadcastMessageAsync", (message: Message) =>
      this.onBroadcastMessage(message, userId, activeChat.chatId, chats, messages, bumpChat));

    connection.on("UpdateUserChatsAsync",
      (chat: Chat) => chats.push(chat));

    connection.on('NotifyOnMessageDeleteAsync',
      (notification: DeleteMessageNotification) =>
        this.onDeleteMessage(notification, messages, activeChat)
    );
  }

  onBroadcastMessage(
    message: Message,
    userId: string | undefined,
    activeChatId: string,
    chats: Chat[],
    messages: Message[], bumpChat: any): void {

    message.self = message.userId == userId;
    let chat = chats.filter(x => x.chatId === message.chatId)[0];
    chat.lastMessageAuthor = message.userDisplayName;
    chat.lastMessageText = message.messageText;
    chat.lastMessageTime = message.createdAt;
    chat.lastMessageId = message.messageId;

    if (message.chatId === activeChatId && !messages.includes(message)) {
      messages.push(message);
    }

    bumpChat();
  }

  onDeleteMessage(notification: DeleteMessageNotification, messages: Message[], activeChat: Chat): void {
    let message = messages.filter(x => x.messageId === notification.messageId)[0];

    if (message.messageId === activeChat.lastMessageId) {
      activeChat.lastMessageAuthor = notification.newLastMessageAuthor;
      activeChat.lastMessageText = notification.newLastMessageText;
      activeChat.lastMessageTime = notification.newLastMessageTime;
      activeChat.lastMessageId = notification.newLastMessageId;
    }
  }
}
