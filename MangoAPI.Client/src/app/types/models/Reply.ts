import { DisplayNameColours } from "../enums/DisplayNameColours";

export class Reply {
  public messageId: string;
  public displayName: string;
  public text: string;
  public displayNameColour: DisplayNameColours;

  constructor(messageId: string, displayName: string, text: string, displayNameColour: DisplayNameColours) {
    this.messageId = messageId;
    this.displayName = displayName;
    this.text = text;
    this.displayNameColour = displayNameColour;
  }
}