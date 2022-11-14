import { Component, OnInit } from '@angular/core';
import { RoutingService } from '../../services/messenger/routing.service';
import { RestorePasswordObject } from '../../types/query-objects/RestorePasswordObject';
import { Router } from '@angular/router';
import { RoutingConstants } from '../../types/constants/RoutingConstants';

@Component({
  selector: 'app-redirect-to-restore-password',
  templateUrl: './redirect-to-restore-password.component.html'
})
export class RedirectToRestorePasswordComponent implements OnInit {
  constructor(private _routingService: RoutingService, private _router: Router) {}

  ngOnInit(): void {
    const params = new URLSearchParams(window.location.search);
    const requestId = params.get('requestId') as string;
    const queryObject: RestorePasswordObject = { requestId: requestId };
    this._routingService.setQueryData(queryObject);
    this._router.navigateByUrl(RoutingConstants.RestorePassword).then((r) => r);
  }
}
