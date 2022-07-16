import {Component} from '@angular/core';
import {RoutingService} from "../../services/messenger/routing.service";
import {PasswordRestoreService} from "../../services/api/password-restore.service";
import {RestorePasswordRequest} from "../../types/requests/RestorePasswordRequest";
import {RestorePasswordObject} from "../../types/query-objects/RestorePasswordObject";
import {Router} from "@angular/router";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {ValidationService} from "../../services/messenger/validation.service";
import {RoutingConstants} from "../../types/constants/RoutingConstants";

@Component({
  selector: 'app-restore-password',
  templateUrl: './restore-password.component.html'
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

    this._restorePasswordService.restorePassword(restorePasswordRequest).subscribe({
      next: _ => {
        alert("Password restoration succeeded!");
        this._router.navigateByUrl(RoutingConstants.Login).then(r => r);
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }
}
