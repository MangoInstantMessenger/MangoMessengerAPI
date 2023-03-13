export class UpdateAccountInformationCommand {
  birthday: string;
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
    this.birthday = birthdayDate;
    this.website = website;
    this.username = username;
    this.bio = bio;
    this.address = address;
    this.displayName = displayName;
  }
}
