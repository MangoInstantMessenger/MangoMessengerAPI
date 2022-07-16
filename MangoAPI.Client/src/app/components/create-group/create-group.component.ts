import {Component} from '@angular/core';
import {CommunitiesService} from "../../services/api/communities.service";
import {CreateChannelCommand} from "../../types/requests/CreateChannelCommand";
import {Router} from "@angular/router";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {RoutingConstants} from "../../types/constants/RoutingConstants";

@Component({
  selector: 'app-create-group',
  templateUrl: './create-group.component.html'
})
export class CreateGroupComponent{

  constructor(private _communitiesService: CommunitiesService,
              private _router: Router,
              private _errorNotificationService: ErrorNotificationService) { }

  public chatTitle: string = '';
  public chatDescription: string = '';

  onCreateChatClick(): void {
    let command = new CreateChannelCommand(this.chatTitle, this.chatDescription);
    this._communitiesService.createChannel(command).subscribe({
      next: _  => {
        this._router.navigateByUrl(RoutingConstants.Chats).then(r => r);
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }
}
