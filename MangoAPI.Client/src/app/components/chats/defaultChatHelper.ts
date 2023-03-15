import { Chat } from '../../types/models/Chat';
import { CommunityType } from '../../types/enums/CommunityType';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class DefaultChatHelper {
  public getEmptyChat(): Chat {
    const emptyChat: Chat = {
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

    return emptyChat;
  }
}
