import {Component, OnInit} from '@angular/core';

@Component({
  selector: 'app-chats',
  templateUrl: './chats.component.html',
  styleUrls: ['./chats.component.scss']
})
export class ChatsComponent implements OnInit {

  constructor() {
  }

  public messageText: string = '';

  ngOnInit(): void {
    let chatMessages = document.getElementById('chatMessages');
    chatMessages!.scrollTop = chatMessages!.scrollHeight;
  }

  onEmojiClick(event: Event): void {
    let button = event.currentTarget as HTMLButtonElement;
    let emoji = button.innerText;
    this.messageText += emoji;
  }
}
