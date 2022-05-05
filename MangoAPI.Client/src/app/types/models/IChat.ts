import {CommunityType} from "../enums/CommunityType";

export interface IChat {
  chatId: string;
  title: string;
  communityType: CommunityType;
  chatLogoImageUrl: string;
  description: string;
  membersCount: number;
  isArchived: boolean;
  isMember: boolean;
  roleId: number;
  lastMessageAuthor: string,
  lastMessageText: string,
  lastMessageTime: string,
  lastMessageId: string,
  updatedAt: string
}
