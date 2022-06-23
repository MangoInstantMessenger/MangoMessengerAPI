import {Component, OnInit} from '@angular/core';
import {TokensService} from "../../services/tokens.service";
import {IChat} from "../../types/models/IChat";
import {CommunitiesService} from "../../services/communities.service";
import {ErrorNotificationService} from "../../services/error-notification.service";
import {Router} from "@angular/router";
import {formatDate} from "@angular/common";
import {MessagesService} from "../../services/messages.service";
import {IMessage} from "../../types/models/IMessage";
import {CommunityType} from "../../types/enums/CommunityType";

@Component({
  selector: 'app-chats',
  templateUrl: './chats.component.html',
  styleUrls: ['./chats.component.scss']
})
export class ChatsComponent implements OnInit {

  constructor(private _tokensService: TokensService,
              private _communitiesService: CommunitiesService,
              private _messagesService: MessagesService,
              private _errorNotificationService: ErrorNotificationService,
              private _router: Router) {
  }

  public userId: string | undefined = '';
  public chats: IChat[] = [];
  public activeChat: IChat = {
    lastMessageId: "",
    lastMessageAuthor: "",
    lastMessageText: "",
    lastMessageTime: "",
    updatedAt: "",
    roleId: 1,
    communityType: CommunityType.PublicChannel,
    description: "",
    chatId: "",
    chatLogoImageUrl: "",
    isArchived: false,
    isMember: false,
    membersCount: 0,
    title: ""
  };
  public activeChatId: string = '';
  public messages: IMessage[] = [];

  public messageText: string = '';
  public searchChatQuery: string = '';
  public chatFilter: string = 'All chats';

  ngOnInit(): void {
    this.scrollToEnd();
    let tokens = this._tokensService.getTokens();
    if (!tokens) {
      this._router.navigateByUrl('app?methodName=login').then(r => r);
      return;
    }
    this.userId = tokens?.userId;
    this._communitiesService.getUserChats().subscribe(response => {
      this.chats = response.chats.filter(x => !x.isArchived);
      this.activeChatId = this.chats[0].chatId;
      this.getChatMessages(this.activeChatId);
    }, error => {
      this._errorNotificationService.notifyOnError(error);
    });
  }

  onEmojiClick(event: Event): void {
    let button = event.currentTarget as HTMLButtonElement;
    let emoji = button.innerText;
    this.messageText += emoji;
  }

  toShortTimeString(date: string): string {
    return formatDate(date, "hh:mm a", "en-US");
  }

  getChatMessages(chatId: string | null): void {
    if (chatId == null) return;

    this._messagesService.getChatMessages(chatId).subscribe(response => {
      this.messages = response.messages;
      this.scrollToEnd();
    }, error => {
      this._errorNotificationService.notifyOnError(error);
    });
  }

  scrollToEnd(): void {
    let chatMessages = document.getElementById('chatMessages');
    chatMessages!.scrollTop = chatMessages!.scrollHeight;
  }

  onChatTabClick(chatId: string): void {
    this.activeChatId = chatId;
    this.activeChat = this.chats.filter(x => x.chatId === this.activeChatId)[0];
    this.getChatMessages(this.activeChatId);
  }

  chatContainsMessages(chat: IChat): boolean {
    return chat.lastMessageAuthor != null &&
      chat.lastMessageText != null;
  }

  onSearchChatClick() {
    this._communitiesService.searchChat(this.searchChatQuery).subscribe(response => {
      this.chats = response.chats;
    }, error => {
      this._errorNotificationService.notifyOnError(error);
    })
  }

  onChatFilterClick(event: Event): void {
    let div = event.currentTarget as HTMLDivElement;
    this.chatFilter = div.innerText;

    this._communitiesService.getUserChats().subscribe(response => {
      let chats = response.chats;
      switch (this.chatFilter) {
        case 'All chats':
          this.ngOnInit();
          break;
        case 'Groups':
          this.chats = chats.filter(x => x.communityType === CommunityType.PublicChannel);
          break;
        case 'Direct chats':
          this.chats = chats.filter(x => x.communityType === CommunityType.DirectChat);
          break;
        case 'Archived':
          this.chats = chats.filter(x => x.isArchived);
          break;
      }
    }, error => {
      this._errorNotificationService.notifyOnError(error);
    });

  }
}
