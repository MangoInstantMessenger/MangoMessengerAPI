import {Component, Inject, LOCALE_ID, OnInit} from '@angular/core';
import {TokensService} from "../../services/tokens.service";
import {IChat} from "../../types/models/IChat";
import {CommunitiesService} from "../../services/communities.service";
import {ErrorNotificationService} from "../../services/error-notification.service";
import {Router} from "@angular/router";
import {formatDate} from "@angular/common";

@Component({
  selector: 'app-chats',
  templateUrl: './chats.component.html',
  styleUrls: ['./chats.component.scss']
})
export class ChatsComponent implements OnInit {

  constructor(private _tokensService: TokensService,
              private _communitiesService: CommunitiesService,
              private _errorNotificationService: ErrorNotificationService,
              private _router: Router) {
  }

  public chats: IChat[] = [];
  public activeChatId: string = '';

  public messageText: string = '';

  ngOnInit(): void {
    let chatMessages = document.getElementById('chatMessages');
    chatMessages!.scrollTop = chatMessages!.scrollHeight;
    this._communitiesService.getUserChats().subscribe(response => {
      this.chats = response.chats.filter(x => !x.isArchived);
      this.activeChatId = this.chats[0].chatId;
    }, error => {
      this._errorNotificationService.notifyOnError(error);

      if (error.status === 403 || error.status === 0) {
        this._router.navigateByUrl('app?methodName=login').then(r => r);
        return;
      }
    })
  }

  onEmojiClick(event: Event): void {
    let button = event.currentTarget as HTMLButtonElement;
    let emoji = button.innerText;
    this.messageText += emoji;
  }

  toShortTimeString(date: string): string {
    return formatDate(date, "hh:mm a", "en-US");
  }
}
