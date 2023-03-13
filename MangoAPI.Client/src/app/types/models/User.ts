import { DisplayNameColours } from '../enums/DisplayNameColours';

export interface User {
  userId: string;
  displayName: string;
  displayNameColour: DisplayNameColours;
  birthdayDate: string;
  website: string;
  username: string;
  bio: string;
  address: string;
  facebook: string;
  twitter: string;
  instagram: string;
  linkedIn: string;
  publicKey: number;
  pictureUrl: string;
}
