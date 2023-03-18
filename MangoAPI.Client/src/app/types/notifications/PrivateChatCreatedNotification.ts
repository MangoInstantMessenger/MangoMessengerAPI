import { CommunityType } from '../enums/CommunityType';

export interface PrivateChatCreatedNotification {
  chatId: string;
  title: string;
  communityType: CommunityType;
  description: string;
  membersCount: number;
  isArchived: boolean;
  isMember: boolean;
  chatLogoImageUrl: string;
}
