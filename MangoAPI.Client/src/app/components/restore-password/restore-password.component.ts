import {Component} from '@angular/core';
import {RoutingService} from "../../services/routing.service";
import {PasswordRestoreService} from "../../services/password-restore.service";
import {RestorePasswordRequest} from "../../types/requests/RestorePasswordRequest";
import {RestorePasswordObject} from "../../types/query-objects/RestorePasswordObject";
import {Router} from "@angular/router";
import {ErrorNotificationService} from "../../services/error-notification.service";
import {ValidationService} from "../../services/validation.service";

@Component({
  selector: 'app-restore-password',
  templateUrl: './restore-password.component.html',
  styleUrls: ['./restore-password.component.scss']
})
export class RestorePasswordComponent{
  constructor(private _routingService: RoutingService,
              private _restorePasswordService: PasswordRestoreService,
              private _router: Router,
              private _errorNotificationService: ErrorNotificationService,
              private _validationService: ValidationService) {}

  public newPassword: string = '';
  public repeatPassword: string = '';

  onRestorePasswordClick(): void {
    let newPasswordFieldValidationResult = this._validationService.validateField(this.newPassword, "New password");
    let repeatPasswordFieldValidationResult = this._validationService.validateField(this.repeatPassword, "Repeat password");

    if(!newPasswordFieldValidationResult || !repeatPasswordFieldValidationResult) {
      return;
    }

    if(this.newPassword !== this.repeatPassword) {
      alert("New password must be equal repeat password");
      return;
    }

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
      this._errorNotificationService.notifyOnError(error);
    })
  }
}
