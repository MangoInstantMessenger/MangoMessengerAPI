export class UpdateAccountInformationCommand {
  birthdayDate: string;
  website: string;
  username: string;
  bio: string;
  address: string;
  displayName: string;

  constructor(
    birthdayDate: string,
    website: string,
    username: string,
    bio: string,
    address: string,
    displayName: string
  ) {
    this.birthdayDate = birthdayDate;
    this.website = website;
    this.username = username;
    this.bio = bio;
    this.address = address;
    this.displayName = displayName;
  }
}
