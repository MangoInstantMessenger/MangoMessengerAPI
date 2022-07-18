import {Component, OnInit} from '@angular/core';
import {TokensService} from "../../services/messenger/tokens.service";
import {Chat} from "../../types/models/Chat";
import {CommunitiesService} from "../../services/api/communities.service";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {Router} from "@angular/router";
import {formatDate} from "@angular/common";
import {MessagesService} from "../../services/api/messages.service";
import {Message} from "../../types/models/Message";
import {CommunityType} from "../../types/enums/CommunityType";
import {RoutingConstants} from "../../types/constants/RoutingConstants";
import {UserChatsService} from "../../services/api/user-chats.service";

@Component({
  selector: 'app-chats',
  templateUrl: './chats.component.html',
  styleUrls: ['./chats.component.scss']
})
export class ChatsComponent implements OnInit {

  constructor(private _tokensService: TokensService,
              private _communitiesService: CommunitiesService,
              private _userChatsService: UserChatsService,
              private _messagesService: MessagesService,
              private _errorNotificationService: ErrorNotificationService,
              private _router: Router) {
  }

  public userId: string | undefined = '';
  public chats: Chat[] = [];
  public activeChat: Chat = {
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
  public messages: Message[] = [];

  public messageText: string = '';
  public searchChatQuery: string = '';
  public searchMessagesQuery: string = '';
  public chatFilter: string = 'All chats';

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  ngOnInit(): void {
    this.initializeView();
  }

  initializeView(): void {
    this.scrollToEnd();
    let tokens = this._tokensService.getTokens();
    if (!tokens) {
      this._router.navigateByUrl(this.routingConstants.Login).then(r => r);
      return;
    }
    this.userId = tokens?.userId;
    this._communitiesService.getUserChats().subscribe({
      next: response => {
        this.chats = response.chats.filter(x => !x.isArchived);
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
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

    this._messagesService.getChatMessages(chatId).subscribe({
      next: response => {
        this.messages = response.messages;
        this.scrollToEnd();
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }

  scrollToEnd(): void {
    let chatMessages = document.getElementById('chatMessages');
    if(!chatMessages) {
      return;
    }
    chatMessages.scrollTop = chatMessages.scrollHeight;
  }

  onChatTabClick(chatId: string): void {
    this.activeChatId = chatId;
    this.activeChat = this.chats.filter(x => x.chatId === this.activeChatId)[0];
    this.getChatMessages(this.activeChatId);
  }

  chatContainsMessages(chat: Chat): boolean {
    return chat.lastMessageAuthor != null &&
      chat.lastMessageText != null;
  }

  onSearchChatClick() {
    this._communitiesService.searchChat(this.searchChatQuery).subscribe({
      next: response => {
        this.chats = response.chats;
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }

  onSearchChatQueryChange(): void {
    if(this.searchChatQuery != '') {
      this._communitiesService.searchChat(this.searchChatQuery).subscribe({
        next: response => {
          this.chats = response.chats;
        },
        error: error => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
    } else {
      this.initializeView();
    }
  }

  onSearchMessageQueryChange(): void {
    if(this.searchMessagesQuery != '') {
      this._messagesService.searchMessages(this.activeChatId, this.searchMessagesQuery).subscribe({
        next: response => {
          this.messages = response.messages;
        },
        error: error => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
    } else {
      this.getChatMessages(this.activeChatId);
    }
  }

  onChatFilterClick(event: Event): void {
    let div = event.currentTarget as HTMLDivElement;
    this.chatFilter = div.innerText;

    this._communitiesService.getUserChats().subscribe({
      next: response => {
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
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }

  onSearchMessageClick(): void {
    this._messagesService.searchMessages(this.activeChatId, this.searchMessagesQuery).subscribe({
      next: response => {
        this.messages = response.messages;
        this.searchMessagesQuery = '';
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }

  onLeaveChatClick(): void {
    this._userChatsService.leaveCommunity(this.activeChatId).subscribe({
      next: _ => {
        this.activeChatId = '';
        this.initializeView();
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }
}
