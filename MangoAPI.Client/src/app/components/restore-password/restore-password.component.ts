import { Component, OnDestroy } from '@angular/core';
import { RoutingService } from '../../services/messenger/routing.service';
import { PasswordRestoreService } from '../../services/api/password-restore.service';
import { RestorePasswordRequest } from '../../types/requests/RestorePasswordRequest';
import { RestorePasswordObject } from '../../types/query-objects/RestorePasswordObject';
import { Router } from '@angular/router';
import { ErrorNotificationService } from '../../services/messenger/error-notification.service';
import { ValidationService } from '../../services/messenger/validation.service';
import { RoutingConstants } from '../../types/constants/RoutingConstants';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-restore-password',
  templateUrl: './restore-password.component.html'
})
export class RestorePasswordComponent implements OnDestroy {
  constructor(
    private _routingService: RoutingService,
    private _restorePasswordService: PasswordRestoreService,
    private _router: Router,
    private _errorNotificationService: ErrorNotificationService,
    private _validationService: ValidationService
  ) {}

  public newPassword = '';
  public repeatPassword = '';
  componentDestroyed$: Subject<boolean> = new Subject();

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  onRestorePasswordClick(): void {
    const newPasswordFieldValidationResult = this._validationService.validateField(
      this.newPassword,
      'New password'
    );
    const repeatPasswordFieldValidationResult = this._validationService.validateField(
      this.repeatPassword,
      'Repeat password'
    );

    if (!newPasswordFieldValidationResult || !repeatPasswordFieldValidationResult) {
      return;
    }

    if (this.newPassword !== this.repeatPassword) {
      alert('New password must be equal repeat password');
      return;
    }

    const restorePasswordQueryObject: RestorePasswordObject = this._routingService.getQueryData();

    if (!restorePasswordQueryObject.requestId) {
      alert('Password restore request invalid or expired');
      return;
    }

    const restorePasswordRequest = new RestorePasswordRequest(
      restorePasswordQueryObject.requestId,
      this.newPassword,
      this.repeatPassword
    );

    this._restorePasswordService
      .restorePassword(restorePasswordRequest)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (_) => {
          alert('Password restoration succeeded!');
          this._router.navigateByUrl(RoutingConstants.Login).then((r) => r);
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });

    this._routingService.clearQueryData();
  }
}
