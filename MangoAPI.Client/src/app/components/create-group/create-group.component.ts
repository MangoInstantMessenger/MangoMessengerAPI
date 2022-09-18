import {Component, OnDestroy} from '@angular/core';
import {CommunitiesService} from "../../services/api/communities.service";
import {CreateChannelCommand} from "../../types/requests/CreateChannelCommand";
import {Router} from "@angular/router";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {RoutingConstants} from "../../types/constants/RoutingConstants";
import {Subject, takeUntil} from "rxjs";

@Component({
  selector: 'app-create-group',
  templateUrl: './create-group.component.html'
})
export class CreateGroupComponent implements OnDestroy{

  constructor(private _communitiesService: CommunitiesService,
              private _router: Router,
              private _errorNotificationService: ErrorNotificationService) { }

  public chatTitle: string = '';
  public chatDescription: string = '';

  componentDestroyed$: Subject<boolean> = new Subject();

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  onCreateChatClick(): void {
    let command = new CreateChannelCommand(this.chatTitle, this.chatDescription);
    this._communitiesService.createChannel(command).pipe(takeUntil(this.componentDestroyed$)).subscribe({
      next: _  => {
        this._router.navigateByUrl(RoutingConstants.Chats).then(r => r);
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }
}
