import { ModalWindowStateService } from '../../services/states/modalWindowState.service';
import { Component, OnInit } from '@angular/core';
import { TokensService } from '../../services/messenger/tokens.service';
import { Chat } from '../../types/models/Chat';
import { CommunitiesService } from '../../services/api/communities.service';
import { Router } from '@angular/router';
import { formatDate } from '@angular/common';
import { MessagesService } from '../../services/api/messages.service';
import { Message } from '../../types/models/Message';
import { CommunityType } from '../../types/enums/CommunityType';
import { RoutingConstants } from '../../types/constants/RoutingConstants';
import { UserChatsService } from '../../services/api/user-chats.service';
import { ValidationService } from '../../services/messenger/validation.service';
import * as signalR from '@microsoft/signalr';
import { DeleteMessageNotification } from '../../types/notifications/DeleteMessageNotification';
import { BehaviorSubject, firstValueFrom, distinctUntilKeyChanged } from 'rxjs';
import { DisplayNameColours } from 'src/app/types/enums/DisplayNameColours';
import { DeleteMessageCommand } from 'src/app/types/requests/DeleteMessageCommand';
import ApiBaseService from 'src/app/services/api/api-base.service';
import { SendMessageResponse } from '../../types/responses/SendMessageResponse';
import { ReplyStateService } from 'src/app/services/states/replyState.service';
import { Reply } from 'src/app/types/models/Reply';
import { GetChatMessagesResponse } from '../../types/responses/GetChatMessagesResponse';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { GetUserChatsResponse } from '../../types/responses/GetUserChatsResponse';
import { DeleteMessageResponse } from '../../types/responses/DeleteMessageResponse';
import { DefaultChatHelper } from './defaultChatHelper';
import { SignalrConstants } from './signalr.constants';
import { SendMessageNotification } from '../../types/notifications/SendMessageNotification';
import { PrivateChatDeletedNotification } from '../../types/notifications/PrivateChatDeletedNotification';
import { PrivateChatCreatedNotification } from '../../types/notifications/PrivateChatCreatedNotification';
import { Tokens } from '../../types/models/Tokens';
import { TypingEventNotification } from 'src/app/types/notifications/TypingEventNotification';

@Component({
  selector: 'app-chats',
  templateUrl: './chats.component.html',
  styleUrls: ['./chats.component.scss']
})
export class ChatsComponent implements OnInit {
  constructor(
    private _tokensService: TokensService,
    private _communitiesService: CommunitiesService,
    private _userChatsService: UserChatsService,
    private _messagesService: MessagesService,
    private _router: Router,
    private _validationService: ValidationService,
    private _apiBaseService: ApiBaseService,
    public _modalWindowStateService: ModalWindowStateService,
    public _replyStateService: ReplyStateService,
    private _defaultChatHelper: DefaultChatHelper
  ) {}

  private connectionBuilder: signalR.HubConnectionBuilder = new signalR.HubConnectionBuilder();
  private connection: signalR.HubConnection = this.connectionBuilder
    .configureLogging(signalR.LogLevel.Information)
    .withUrl(this._apiBaseService.getUrl() + 'notify')
    .build();
  private signalRConnected = false;
  public realTimeConnections: string[] = [];
  public userId: string | undefined = '';
  public chats: Chat[] = [];

  public typingEventArray: TypingEventNotification[] = [];

  public activeChat: Chat = this._defaultChatHelper.getEmptyChat();

  public activeChatId = '';
  public messages: Message[] = [];
  public messageAttachment: File | null = null;
  public messageAttachmentBlobUrl: string | ArrayBuffer | null = '';
  public messageText = '';
  public searchChatQuery = '';
  public searchMessagesQuery = '';
  public chatFilter = '';
  public activeChatBehaviorSubject = new BehaviorSubject<Chat>(this.activeChat);

  async ngOnInit() {
    this.activeChatBehaviorSubject.pipe(distinctUntilKeyChanged('chatId')).subscribe(() => {
      this._replyStateService.setReplyNull();
      this.messageAttachment = null;
      this.messageAttachmentBlobUrl = null;
    });

    await this.initializeView();
  }

  async initializeView() {
    const tokens = this._tokensService.getTokens();

    if (!tokens) {
      this._router.navigateByUrl(this.routingConstants.Login).then((r) => r);
      return;
    }

    this.userId = tokens.userId;
    this.chatFilter = 'All chats';

    const chatsSub$ = this._communitiesService.getUserChats();
    const chatsResult = await firstValueFrom<GetUserChatsResponse>(chatsSub$);

    this.chats = chatsResult.chats.filter((x) => !x.isArchived);

    if (this.connection.state !== signalR.HubConnectionState.Connected) {
      await this.connectToSignalRHubs();
    }

    if (!this.signalRConnected) {
      this.setSignalRMethods();
      this.signalRConnected = true;
    }
  }

  async connectToSignalRHubs() {
    await this.connection
      .start()
      .then(() => {
        this.chats.forEach((x) => {
          if (this.realTimeConnections.includes(x.chatId)) {
            return;
          }

          this.connection.invoke(this.signalRConstants.SubscribeToGroup, x.chatId).then(() => {
            this.realTimeConnections.push(x.chatId);
          });
        });

        if (this.userId != null && this.realTimeConnections.includes(this.userId)) {
          return;
        }

        this.connection.invoke(this.signalRConstants.SubscribeToGroup, this.userId).then((r) => r);
      })
      .catch((err) => console.error(err.toString()));
  }

  setSignalRMethods(): void {
    this.connection.on(
      this.signalRConstants.MessageSentAsync,
      (notification: SendMessageNotification) => {
        this.onMessageSendHandler(notification);
      }
    );

    this.connection.on(
      this.signalRConstants.PrivateChatCreatedAsync,
      (notification: PrivateChatCreatedNotification) => {
        this.onPrivateChatCreatedHandler(notification);
      }
    );

    this.connection.on(
      this.signalRConstants.PrivateChatDeletedAsync,
      (notification: PrivateChatDeletedNotification) => {
        this.onPrivateChatDeletedHandler(notification);
      }
    );

    this.connection.on(
      this.signalRConstants.MessageDeletedAsync,
      (notification: DeleteMessageNotification) => {
        this.onMessageDeleteHandler(notification);
      }
    );

    this.connection.on(
      this.signalRConstants.PrivateChatSentTypingEventAsync,
      (notification: TypingEventNotification) => {
        this.onTypingEventHandler(notification);
      }
    );
  }

  private onPrivateChatCreatedHandler(notification: PrivateChatCreatedNotification) {
    const chat = this.convertPrivateChatCreatedNotification(notification);
    this.chats.push(chat);

    if (this.realTimeConnections.includes(notification.chatId)) {
      return;
    }

    this.connection.invoke(this.signalRConstants.SubscribeToGroup, notification.chatId).then(() => {
      this.realTimeConnections.push(notification.chatId);
    });
  }

  private convertPrivateChatCreatedNotification(
    notification: PrivateChatCreatedNotification
  ): Chat {
    const chat: Chat = {
      chatId: notification.chatId,
      title: notification.title,
      communityType: notification.communityType,
      chatLogoImageUrl: notification.chatLogoImageUrl,
      description: notification.description,
      membersCount: notification.membersCount,
      isArchived: notification.isArchived,
      isMember: notification.isMember,
      roleId: 1,
      lastMessageAuthor: '',
      lastMessageText: '',
      lastMessageTime: '',
      lastMessageId: ''
    };

    return chat;
  }

  private onPrivateChatDeletedHandler(notification: PrivateChatDeletedNotification) {
    const chatIndex = this.chats.findIndex((x) => x.chatId === notification.chatId);

    if (chatIndex === -1) return;

    this.chats.splice(chatIndex, 1);

    if (this.activeChatId === notification.chatId) {
      this.activeChat = this._defaultChatHelper.getEmptyChat();
      this.activeChatId = '';
      this.messages = [];
    }
  }

  async loadChat(chatId: string) {
    if (this.activeChatId === chatId) {
      return;
    }

    this.activeChatId = chatId;
    const newActiveChat = this.chats.filter((x) => x.chatId === this.activeChatId)[0];
    this.activeChat = newActiveChat;

    this.activeChatBehaviorSubject.next(newActiveChat);

    await this.loadMessages(this.activeChatId);

    if (this.realTimeConnections.includes(this.activeChat.chatId)) {
      return;
    }

    this.connection
      .invoke(this.signalRConstants.SubscribeToGroup, this.activeChat.chatId)
      .then(() => {
        this.realTimeConnections.push(this.activeChat.chatId);
      });
  }

  async loadMessages(chatId: string | null) {
    if (!chatId) {
      return;
    }

    const getMessagesSub$ = this._messagesService.getChatMessages(chatId);
    const messagesResult = await firstValueFrom<GetChatMessagesResponse>(getMessagesSub$);

    this.messages = messagesResult.messages;
    this.scrollToEnd();
  }

  async onSendMessageClick() {
    const newMessageText = this.messageText.repeat(1); // deep copy

    const messageTextValidationResult = this._validationService.validateField(
      newMessageText,
      'Message Text'
    );

    if (!messageTextValidationResult) {
      return;
    }

    const tokens = this._tokensService.getTokens();

    if (!tokens) {
      alert('User tokens are empty.');
      return;
    }

    const messageId = crypto.randomUUID();
    const createdAt = new Date().toISOString();
    const sendMessageFormData = new FormData();

    sendMessageFormData.append('text', newMessageText);
    sendMessageFormData.append('chatId', this.activeChatId);
    sendMessageFormData.append('inReplyToUser', this._replyStateService.reply?.displayName ?? '');
    sendMessageFormData.append('inReplyToText', this._replyStateService.reply?.text ?? '');

    if (this.messageAttachment) {
      sendMessageFormData.append('Attachment', this.messageAttachment);
    }

    const newMessage = new Message(
      messageId,
      tokens.userId,
      this.activeChatId,
      tokens.userDisplayName,
      tokens.displayNameColour,
      newMessageText,
      createdAt,
      true,
      tokens.userProfilePictureUrl,
      this._replyStateService.reply?.displayName ?? null,
      this._replyStateService.reply?.text ?? null
    );

    this.clearMessageInput();

    this.messages.push(newMessage);

    this.activeChat.lastMessageAuthor = newMessage.displayName;
    this.activeChat.lastMessageText = newMessage.text;
    this.activeChat.lastMessageTime = newMessage.createdAt;
    this.activeChat.lastMessageId = newMessage.messageId;

    this.pushChatToTop(this.activeChatId);

    this._replyStateService.setReplyNull();

    if (this.messageAttachment) {
      this.clearAttachmentInput();
    }

    this.scrollToEnd();

    const sendMessage$ = this._messagesService.sendMessage(sendMessageFormData);

    const response = await firstValueFrom<SendMessageResponse>(sendMessage$);

    newMessage.messageId = response.newMessageId;
    newMessage.attachmentUrl = response.attachmentUrl;
    newMessage.createdAt = response.createdAt;
  }

  pushChatToTop(chatId: string) {
    const chatIndex = this.chats.findIndex((x) => x.chatId === chatId);

    if (chatIndex === -1) return;

    const chat = this.chats[chatIndex];

    this.chats.splice(chatIndex, 1);

    this.chats.splice(0, 0, chat);
  }

  onReplyClick(message: Message) {
    const replyEntity = new Reply(
      message.messageId,
      message.displayName,
      message.text,
      message.displayNameColour
    );

    this._replyStateService.setReply(replyEntity);
    this.scrollToEnd();
  }

  async onEnterClick(event: any) {
    event.preventDefault();
    await this.onSendMessageClick().then((r) => r);
  }

  async onDeleteMessageClick(message: Message) {
    const deleteMessageCommand = new DeleteMessageCommand(message.messageId, message.chatId);

    const messageIndex = this.messages.findIndex((x) => x.messageId === message.messageId);

    if (messageIndex === -1) return;

    const lastMessage = this.messages[this.messages.length - 1];

    const deletedMessage = this.messages.splice(messageIndex, 1)[0];

    const newLastMessage = this.messages[this.messages.length - 1];

    const lastMessageDeleted = lastMessage.messageId === deletedMessage.messageId;

    const chatIndex = this.chats.findIndex((x) => x.chatId === message.chatId);

    const chat = this.chats[chatIndex];

    if (lastMessageDeleted && newLastMessage) {
      chat.lastMessageId = newLastMessage.messageId;
      chat.lastMessageText = newLastMessage.text;
      chat.lastMessageAuthor = newLastMessage.displayName;
      chat.lastMessageTime = newLastMessage.createdAt;

      const deleteMessageSub$ = this._messagesService.deleteMessage(deleteMessageCommand);
      await firstValueFrom<DeleteMessageResponse>(deleteMessageSub$);
      return;
    }

    if (lastMessageDeleted && !newLastMessage) {
      chat.lastMessageId = '';
      chat.lastMessageText = '';
      chat.lastMessageAuthor = '';
      chat.lastMessageTime = '';

      const deleteMessageSub$ = this._messagesService.deleteMessage(deleteMessageCommand);
      await firstValueFrom<DeleteMessageResponse>(deleteMessageSub$);
      return;
    }

    const deleteMessageSub$ = this._messagesService.deleteMessage(deleteMessageCommand);
    await firstValueFrom<DeleteMessageResponse>(deleteMessageSub$);
  }

  async onJoinChatClick() {
    const joinChatSub$ = this._userChatsService.joinCommunity(this.activeChatId);
    await firstValueFrom<BaseResponse>(joinChatSub$);
    this.searchChatQuery = '';
    this.activeChat.isMember = true;
    await this.initializeView();
  }

  async onSearchChatQueryChange() {
    if (!this.searchChatQuery) {
      await this.initializeView();
      return;
    }

    const searchChatSub$ = this._communitiesService.searchChat(this.searchChatQuery);
    const searchChatResult = await firstValueFrom<GetUserChatsResponse>(searchChatSub$);

    this.chatFilter = 'Search results';
    this.chats = searchChatResult.chats;
  }

  async onSearchMessageQueryChange() {
    if (!this.searchMessagesQuery) {
      await this.loadMessages(this.activeChatId);
      return;
    }

    const searchMessageSub$ = this._messagesService.searchMessages(
      this.activeChatId,
      this.searchMessagesQuery
    );
    const searchMessageResult = await firstValueFrom<GetChatMessagesResponse>(searchMessageSub$);
    this.messages = searchMessageResult.messages;
  }

  async onChatFilterClick(event: Event) {
    const div = event.currentTarget as HTMLDivElement;
    this.chatFilter = div.innerText;

    const getChatsSub$ = this._communitiesService.getUserChats();
    const getChatsResult = await firstValueFrom<GetUserChatsResponse>(getChatsSub$);

    switch (this.chatFilter) {
      case 'All chats':
        this.chats = getChatsResult.chats.filter((x) => !x.isArchived);
        break;
      case 'Groups':
        this.chats = getChatsResult.chats.filter(
          (x) => x.communityType === CommunityType.PublicChannel && !x.isArchived
        );
        break;
      case 'Direct chats':
        this.chats = getChatsResult.chats.filter(
          (x) => x.communityType === CommunityType.DirectChat && !x.isArchived
        );
        break;
      case 'Archived':
        this.chats = getChatsResult.chats.filter((x) => x.isArchived);
        break;
    }
  }

  async onLeaveChatClick() {
    const leaveChatSub$ = this._userChatsService.leaveCommunity(this.activeChatId);
    await firstValueFrom<BaseResponse>(leaveChatSub$);

    this.activeChatId = '';

    await this.initializeView();
  }

  async onArchiveChatClick() {
    const archiveChatSub$ = this._userChatsService.archiveCommunity(this.activeChatId);
    await firstValueFrom<BaseResponse>(archiveChatSub$);

    this.activeChatId = '';

    await this.initializeView();
  }

  private onMessageSendHandler(notification: SendMessageNotification) {
    const self = notification.userId === this.userId;

    if (self) return;

    const chatIndex = this.chats.findIndex((x) => x.chatId === notification.chatId);

    if (chatIndex === -1) return;
    const chat = this.chats[chatIndex];

    chat.lastMessageAuthor = notification.displayName;
    chat.lastMessageText = notification.text;
    chat.lastMessageTime = notification.createdAt;
    chat.lastMessageId = notification.messageId;

    this.chats.splice(chatIndex, 1);
    this.chats.splice(0, 0, chat);

    if (this.activeChatId !== notification.chatId) return;

    const messageIndex = this.messages.findIndex((x) => x.messageId === notification.messageId);

    if (messageIndex === -1) {
      const message = this.convertSendNotificationToMessage(notification);
      this.messages.push(message);
    }
  }

  private convertSendNotificationToMessage(notification: SendMessageNotification): Message {
    const message: Message = {
      messageId: notification.messageId,
      chatId: notification.chatId,
      userId: notification.userId,
      displayName: notification.displayName,
      displayNameColour: notification.displayNameColour,
      text: notification.text,
      createdAt: notification.createdAt,
      updatedAt: notification.updatedAt,
      self: false,
      authorImageUrl: notification.authorImageUrl,
      attachmentUrl: notification.attachmentUrl,
      inReplyToUser: notification.inReplyToUser,
      inReplyToText: notification.inReplyToText
    };

    return message;
  }

  private onTypingEventHandler(notification: TypingEventNotification) {
    if (notification.userId === this.userId || notification.chatId !== this.activeChatId) return;

    const existingNotification = this.typingEventArray.find(
      (x) => x.userId === notification.userId
    );

    if (existingNotification) {
      clearTimeout(existingNotification.timeout);
      existingNotification.timeout = setTimeout(
        () => this.deleteTypingEventFromArray(notification.userId),
        1000
      );
      return;
    }

    notification.timeout = setTimeout(
      () => this.deleteTypingEventFromArray(notification.userId),
      1000
    );

    this.typingEventArray.push(notification);
  }

  private deleteTypingEventFromArray(userId: string) {
    const index = this.typingEventArray.findIndex((item) => item.userId === userId);

    if (index !== -1) {
      this.typingEventArray.splice(index, 1);
    }
  }

  private onMessageDeleteHandler(notification: DeleteMessageNotification) {
    const selfMessage = notification.userId === this.userId;

    if (selfMessage) return;

    if (this.activeChatId === notification.chatId) {
      const messageIndex = this.messages.findIndex(
        (x) => x.messageId === notification.deletedMessageId
      );
      this.messages.splice(messageIndex, 1);
    }

    const chatIndex = this.chats.findIndex((x) => x.chatId === notification.chatId);
    const chat = this.chats[chatIndex];

    if (notification.isLastMessage) {
      chat.lastMessageId = notification.newLastMessageId;
      chat.lastMessageText = notification.newLastMessageText;
      chat.lastMessageAuthor = notification.newLastMessageDisplayName;
      chat.lastMessageTime = notification.newLastMessageTime;
      return;
    }
  }

  onTypingHandler(event: KeyboardEvent) {
    const userData = this._tokensService.getTokens();
    if (!userData) return;

    if (event.key.match(/^[a-zA-Zа-яА-ЯёЁ0-9+\-[\]{}(),./'"]$/) || event.key === 'Backspace') {
      this.connection
        .invoke(
          this.signalRConstants.ShowTyping,
          userData.userId,
          this.activeChatId,
          userData.userDisplayName
        )
        .then((r) => r);
    }
  }

  private clearMessageInput(): void {
    this.messageText = '';
  }

  scrollToEnd(): void {
    setTimeout(() => {
      const chatMessages = document.getElementById('chatMessages');
      if (!chatMessages) {
        return;
      }
      chatMessages.scrollTop = chatMessages.scrollHeight;
    });
  }

  clearAttachmentInput() {
    const fileInput = document.getElementById('attachment') as HTMLInputElement;

    if (!fileInput) {
      return;
    }

    fileInput.value = '';
    this.messageAttachment = null;
  }

  async imageSelected(event: any) {
    this.messageAttachment = event.target.files[0];

    const reader = new FileReader();
    reader.onload = () => {
      this.messageAttachmentBlobUrl = reader.result;
    };

    reader.readAsDataURL(event.target.files[0]);
  }

  removeImageSelected() {
    this.messageAttachment = null;
    this.messageAttachmentBlobUrl = null;
  }

  onOpenImageClick(imageLink: string): void {
    this._modalWindowStateService.setIsModalWindowShowing(true);
    this._modalWindowStateService.setPicture(imageLink);
  }

  closeModalWindowClick(): void {
    this._modalWindowStateService.setIsModalWindowShowing(false);
    this._modalWindowStateService.setPictureNull();
  }

  toShortTimeString(date: string): string {
    const format = formatDate(date, 'hh:mm a', 'en-US');

    return format;
  }

  onEmojiClick(event: Event): void {
    const button = event.currentTarget as HTMLButtonElement;
    const emoji = button.innerText;
    this.messageText += emoji;
  }

  chatContainsMessages(chat: Chat): boolean {
    const hasLastMessageAuthor = chat.lastMessageAuthor !== null && chat.lastMessageAuthor !== '';
    const hasLastMessageText = chat.lastMessageText !== null && chat.lastMessageText !== '';
    const hasLastMessage = hasLastMessageAuthor && hasLastMessageText;

    return hasLastMessage;
  }

  getDisplayNameColour(colour: number): string {
    switch (colour) {
      case DisplayNameColours.White:
        return 'color-white';
      case DisplayNameColours.Blue:
        return 'color-blue';
      case DisplayNameColours.Red:
        return 'color-red';
      case DisplayNameColours.Yellow:
        return 'color-yellow';
      case DisplayNameColours.Green:
        return 'color-green';
      case DisplayNameColours.BrightYellow:
        return 'color-bright-yellow';
      case DisplayNameColours.Aqua:
        return 'color-aqua';
      case DisplayNameColours.Violet:
        return 'color-violet';
      case DisplayNameColours.Pink:
        return 'color-pink';
      case DisplayNameColours.Orange:
        return 'color-orange';
      default:
        return 'color-pink';
    }
  }

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  public get signalRConstants(): typeof SignalrConstants {
    return SignalrConstants;
  }
}
