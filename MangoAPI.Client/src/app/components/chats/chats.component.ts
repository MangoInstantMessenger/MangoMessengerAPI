import { ModalWindowStateService } from '../../services/states/modalWindowState.service';
import { Component, OnInit } from '@angular/core';
import { TokensService } from '../../services/messenger/tokens.service';
import { Chat } from '../../types/models/Chat';
import { CommunitiesService } from '../../services/api/communities.service';
import { ErrorNotificationService } from '../../services/messenger/error-notification.service';
import { Router } from '@angular/router';
import { formatDate } from '@angular/common';
import { MessagesService } from '../../services/api/messages.service';
import { Message } from '../../types/models/Message';
import { CommunityType } from '../../types/enums/CommunityType';
import { RoutingConstants } from '../../types/constants/RoutingConstants';
import { UserChatsService } from '../../services/api/user-chats.service';
import { ValidationService } from '../../services/messenger/validation.service';
import * as signalR from '@microsoft/signalr';
import { EditMessageNotification } from '../../types/models/EditMessageNotification';
import { DeleteMessageNotification } from '../../types/models/DeleteMessageNotification';
import { BehaviorSubject, firstValueFrom, distinctUntilKeyChanged } from 'rxjs';
import { DisplayNameColours } from 'src/app/types/enums/DisplayNameColours';
import { DeleteMessageCommand } from 'src/app/types/requests/DeleteMessageCommand';
import ApiBaseService from 'src/app/services/api/api-base.service';
import { SendMessageResponse } from '../../types/responses/SendMessageResponse';
import { ReplyStateService } from 'src/app/services/states/replyState.service';
import { Reply } from 'src/app/types/models/Reply';
import { GetChatMessagesResponse } from '../../types/responses/GetChatMessagesResponse';
import { RealtimeService } from '../../services/api/realtime.service';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { GetUserChatsResponse } from '../../types/responses/GetUserChatsResponse';
import { DeleteMessageResponse } from '../../types/responses/DeleteMessageResponse';

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
    private _errorNotificationService: ErrorNotificationService,
    private _router: Router,
    private _validationService: ValidationService,
    private _apiBaseService: ApiBaseService,
    public _modalWindowStateService: ModalWindowStateService,
    public _replyStateService: ReplyStateService,
    private _realtimeService: RealtimeService
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

  public activeChat: Chat = {
    lastMessageId: '',
    lastMessageAuthor: '',
    lastMessageText: '',
    lastMessageTime: '',
    roleId: 1,
    communityType: CommunityType.PublicChannel,
    description: '',
    chatId: '',
    chatLogoImageUrl: '',
    isArchived: false,
    isMember: false,
    membersCount: 0,
    title: ''
  };

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

    console.log(chatsResult.chats);

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

          this.connection.invoke('JoinGroup', x.chatId).then(() => {
            this.realTimeConnections.push(x.chatId);
            console.log(`SignalR JoinGroup: ${x.chatId}`);
          });
        });

        if (this.userId != null && this.realTimeConnections.includes(this.userId)) {
          return;
        }

        this.connection.invoke('JoinGroup', this.userId).then((r) => r);
      })
      .catch((err) => console.error(err.toString()));
  }

  setSignalRMethods(): void {
    this.connection.on('BroadcastMessageAsync', (message: Message) => {
      this.onMessageSendHandler(message);
    });

    this.connection.on('PrivateChatCreatedAsync', (chat: Chat) => {
      this.chats.push(chat);

      if (this.realTimeConnections.includes(chat.chatId)) {
        return;
      }

      this.connection.invoke('JoinGroup', chat.chatId).then(() => {
        this.realTimeConnections.push(chat.chatId);
        console.log(`SignalR JoinGroup: ${chat.chatId}`);
      });
    });

    this.connection.on('PrivateChatDeletedAsync', (chatId: string) => {
      console.log(`Private chat deleted: ${chatId}`);
      this.chats = this.chats.filter((x) => x.chatId !== chatId);
    });

    this.connection.on('NotifyOnMessageDeleteAsync', (notification: DeleteMessageNotification) => {
      this.onMessageDeleteHandler(notification);
    });

    this.connection.on('NotifyOnMessageEditAsync', (notification: EditMessageNotification) => {
      this.onMessageEditHandler(notification);
    });
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

    this.connection.invoke('JoinGroup', this.activeChat.chatId).then(() => {
      this.realTimeConnections.push(this.activeChat.chatId);
      console.log(`SignalR JoinGroup: ${this.activeChat.chatId}`);
    });
  }

  async loadMessages(chatId: string | null) {
    if (!chatId) {
      return;
    }

    const getMessagesSub$ = this._messagesService.getChatMessages(chatId);
    const messagesResult = await firstValueFrom<GetChatMessagesResponse>(getMessagesSub$);

    console.log(messagesResult.messages);
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

    this._replyStateService.setReplyNull();

    const sendMessage$ = this._messagesService.sendMessage(sendMessageFormData);

    const response = await firstValueFrom<SendMessageResponse>(sendMessage$);

    newMessage.messageId = response.messageModel.messageId;
    newMessage.attachmentUrl = response.messageModel.attachmentUrl;
    newMessage.createdAt = response.messageModel.createdAt;

    const sendNotification$ = this._realtimeService.sendRealtimeNewMessageNotification(
      response.messageModel
    );

    await firstValueFrom<BaseResponse>(sendNotification$);

    this.clearAttachmentInput();
    this.scrollToEnd();
  }

  onReplyClick(
    messageId: string,
    displayName: string,
    text: string,
    displayNameColour: DisplayNameColours
  ) {
    const replyEntity = new Reply(messageId, displayName, text, displayNameColour);

    this._replyStateService.setReply(replyEntity);
    this.scrollToEnd();
  }

  async onEnterClick(event: any) {
    event.preventDefault();
    await this.onSendMessageClick().then((r) => r);
  }

  async deleteMessage(message: Message) {
    const deleteMessageCommand: DeleteMessageCommand = {
      chatId: message.chatId,
      messageId: message.messageId
    };

    const deleteMessageSub$ = this._messagesService.deleteMessage(deleteMessageCommand);
    const deleteMessageResult = await firstValueFrom<DeleteMessageResponse>(deleteMessageSub$);

    console.log(deleteMessageResult.message);
  }

  async onJoinChatClick() {
    const joinChatSub$ = this._userChatsService.joinCommunity(this.activeChatId);
    const joinResult = await firstValueFrom<BaseResponse>(joinChatSub$);

    console.log(joinResult.message);
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

    console.log(searchChatResult.chats);

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

    console.log(searchMessageResult.messages);
    this.messages = searchMessageResult.messages;
  }

  async onChatFilterClick(event: Event) {
    const div = event.currentTarget as HTMLDivElement;
    this.chatFilter = div.innerText;

    console.log(this.chatFilter);

    const getChatsSub$ = this._communitiesService.getUserChats();
    const getChatsResult = await firstValueFrom<GetUserChatsResponse>(getChatsSub$);

    console.log(getChatsResult.chats);

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
    const leaveChatResult = await firstValueFrom<BaseResponse>(leaveChatSub$);

    console.log(leaveChatResult.message);

    this.activeChatId = '';

    await this.initializeView();
  }

  async onArchiveChatClick() {
    const archiveChatSub$ = this._userChatsService.archiveCommunity(this.activeChatId);
    const archiveResult = await firstValueFrom<BaseResponse>(archiveChatSub$);

    console.log(archiveResult.message);

    this.activeChatId = '';

    await this.initializeView();
  }

  private onMessageSendHandler(message: Message) {
    message.self = message.userId == this.userId;
    const chat = this.chats.filter((x) => x.chatId === message.chatId)[0];
    chat.lastMessageAuthor = message.userDisplayName;
    chat.lastMessageText = message.text;
    chat.lastMessageTime = message.createdAt;
    chat.lastMessageId = message.messageId;
    this.chats = this.chats.filter((x) => x.chatId !== message.chatId);
    this.chats = [chat, ...this.chats];

    const includesMessage = this.messages.some((x) => x.messageId === message.messageId);

    if (message.chatId === this.activeChatId && !includesMessage) {
      this.messages.push(message);
    }

    this.scrollToEnd();
  }

  private onMessageEditHandler(notification: EditMessageNotification) {
    const message = this.messages.filter((x) => x.messageId === notification.messageId)[0];

    if (message) {
      message.text = notification.modifiedText;
      message.updatedAt = notification.updatedAt;
    }

    if (notification.isLastMessage) {
      this.activeChat.lastMessageText = notification.modifiedText;
      this.activeChat.lastMessageTime = notification.updatedAt;
    }
  }

  private onMessageDeleteHandler(notification: DeleteMessageNotification) {
    console.log(notification);

    // const message = this.messages.filter((x) => x.messageId === notification.deletedMessageId)[0];

    console.log(`deleted message id: ${notification.deletedMessageId}`);
    console.log(`last message id: ${this.activeChat.lastMessageId}`);

    if (notification.isLastMessage) {
      const updatedChat = this.chats.filter((x) => x.chatId == notification.chatId)[0];
      updatedChat.lastMessageAuthor = notification.newLastMessageAuthor;
      updatedChat.lastMessageText = notification.newLastMessageText;
      updatedChat.lastMessageTime = notification.newLastMessageTime;
      updatedChat.lastMessageId = notification.newLastMessageId;

      console.log(`updated chat: ${JSON.stringify(updatedChat)}`);
    }

    if (this.activeChatId === notification.chatId) {
      this.messages = this.messages.filter((x) => x.messageId !== notification.deletedMessageId);
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
    return formatDate(date, 'hh:mm a', 'en-US');
  }

  onEmojiClick(event: Event): void {
    const button = event.currentTarget as HTMLButtonElement;
    const emoji = button.innerText;
    this.messageText += emoji;
  }

  chatContainsMessages(chat: Chat): boolean {
    return chat.lastMessageAuthor != null && chat.lastMessageText != null;
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
}
