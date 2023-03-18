import { Pipe, PipeTransform } from '@angular/core';
import { Chat } from '../../types/models/Chat';

@Pipe({ name: 'chatHasMessages' })
export class ChatHasMessagesPipe implements PipeTransform {
  transform(value: Chat): boolean {
    console.log(JSON.stringify(value));
    const hasLastMessageAuthor = value.lastMessageAuthor !== null && value.lastMessageAuthor !== '';
    const hasLastMessageText = value.lastMessageText !== null && value.lastMessageText !== '';
    const hasLastMessage = hasLastMessageAuthor && hasLastMessageText;

    return hasLastMessage;
  }
}
