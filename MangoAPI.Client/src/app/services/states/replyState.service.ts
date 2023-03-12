import { Injectable } from '@angular/core';
import { Reply } from './../../types/models/Reply';


@Injectable({
  providedIn: 'root'
})
export class ReplyStateSerivce {
  public reply: Reply | null = null;

  public setReply(replyEntity: Reply) {
    this.reply = replyEntity;
  }

  public setReplyNull() {
    this.reply = null;
  }
}