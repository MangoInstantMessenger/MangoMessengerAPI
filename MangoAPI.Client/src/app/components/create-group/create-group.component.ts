import { TokensService } from '../../services/messenger/tokens.service';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { CommunitiesService } from '../../services/api/communities.service';
import { CreateChannelCommand } from '../../types/requests/CreateChannelCommand';
import { Router } from '@angular/router';
import { RoutingConstants } from '../../types/constants/RoutingConstants';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-create-group',
  templateUrl: './create-group.component.html',
  styleUrls: ['./create-group.component.scss']
})
export class CreateGroupComponent implements OnDestroy, OnInit {
  constructor(
    private _communitiesService: CommunitiesService,
    private _router: Router,
    private _tokensService: TokensService
  ) {}

  public chatTitle = '';
  public chatDescription = '';

  componentDestroyed$: Subject<boolean> = new Subject();

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  ngOnInit() {
    const tokens = this._tokensService.getTokens();

    if (!tokens) {
      this._router.navigateByUrl(this.routingConstants.Login).then((r) => r);
      return;
    }
  }

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  onCreateGroupClick(): void {
    const command = new CreateChannelCommand(this.chatTitle, this.chatDescription);
    this._communitiesService
      .createChannel(command)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (_) => {
          this._router.navigateByUrl(RoutingConstants.Chats).then((r) => r);
        }
      });
  }

  onCancelClick(): void {
    this._router.navigateByUrl(RoutingConstants.Chats).then((r) => r);
  }
}
