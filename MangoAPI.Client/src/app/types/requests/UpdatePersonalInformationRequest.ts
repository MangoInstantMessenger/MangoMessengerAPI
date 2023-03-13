export class UpdatePersonalInformationRequest {
  facebook: string;
  twitter: string;
  instagram: string;
  linkedIn: string;

  constructor(facebook: string, twitter: string, instagram: string, linkedIn: string) {
    this.facebook = facebook;
    this.twitter = twitter;
    this.instagram = instagram;
    this.linkedIn = linkedIn;
  }
}
