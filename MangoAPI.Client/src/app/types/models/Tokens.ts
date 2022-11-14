import { DisplayNameColours } from '../enums/DisplayNameColours';

export interface Tokens {
  accessToken: string;
  refreshToken: string;
  userId: string;
  expires: number;
  userDisplayName: string;
  userProfilePictureUrl: string;
  displayNameColour: DisplayNameColours;
}
