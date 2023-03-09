import { DisplayNameColours } from '../enums/DisplayNameColours';

export interface User {
  userId: string;
  displayName: string;
  displayNameColour: DisplayNameColours;
  birthdayDate: string;
  email: string;
  website: string;
  username: string;
  bio: string;
  userNameChanged: boolean;
  address: string;
  facebook: string;
  twitter: string;
  instagram: string;
  linkedIn: string;
  publicKey: number;
  pictureUrl: string;
}
