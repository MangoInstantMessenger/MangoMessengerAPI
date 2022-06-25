import { Component, OnInit } from '@angular/core';
import {RoutingService} from "../../services/messenger/routing.service";
import {RestorePasswordObject} from "../../types/query-objects/RestorePasswordObject";
import {Router} from "@angular/router";

@Component({
  selector: 'app-redirect-to-restore-password',
  templateUrl: './redirect-to-restore-password.component.html'
})
export class RedirectToRestorePasswordComponent implements OnInit {

  constructor(private _routingService: RoutingService,
              private _router: Router) { }

  ngOnInit(): void {
    let params = new URLSearchParams(window.location.search);
    const requestId = params.get('requestId') as string;
    const queryObject: RestorePasswordObject = { requestId: requestId };
    this._routingService.setQueryData(queryObject);
    this._router.navigateByUrl("app?methodName=restorePassword").then(r => r);
  }

}
