export class CreateChannelCommand {
  channelTitle: string;
  channelDescription: string;


  constructor(groupTitle: string, groupDescription: string) {
    this.channelTitle = groupTitle;
    this.channelDescription = groupDescription;
  }
}
