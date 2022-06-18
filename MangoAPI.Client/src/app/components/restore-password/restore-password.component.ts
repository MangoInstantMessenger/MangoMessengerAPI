import {Component, OnInit} from '@angular/core';
import {RoutingService} from "../../services/routing.service";
import {PasswordRestoreService} from "../../services/password-restore.service";
import {RestorePasswordRequest} from "../../types/requests/RestorePasswordRequest";
import {RestorePasswordObject} from "../../types/query-objects/RestorePasswordObject";
import {Router} from "@angular/router";
import {ErrorNotificationService} from "../../services/error-notification.service";

@Component({
  selector: 'app-restore-password',
  templateUrl: './restore-password.component.html',
  styleUrls: ['./restore-password.component.scss']
})
export class RestorePasswordComponent{
  constructor(private _routingService: RoutingService,
              private _restorePasswordService: PasswordRestoreService,
              private _router: Router,
              private _errorNotificationService: ErrorNotificationService) {}

  public newPassword: string = '';
  public repeatPassword: string = '';

  onRestorePasswordClick(): void {
    const restorePasswordQueryObject: RestorePasswordObject = this._routingService.getQueryData();

    if(!restorePasswordQueryObject.requestId) {
      alert("Password restore request invalid or expired");
      return;
    }

    const restorePasswordRequest = new RestorePasswordRequest(restorePasswordQueryObject.requestId, this.newPassword, this.repeatPassword);

    this._restorePasswordService.restorePassword(restorePasswordRequest).subscribe(_ => {
      alert("Password restoration succeeded!");
      this._router.navigateByUrl("app?methodName=login").then(r => r);
    }, error => {
      console.log('abc');
      this._errorNotificationService.notifyOnError(error);
    })
  }
}
