import {Component, OnDestroy} from '@angular/core';
import {ValidationService} from "../../services/messenger/validation.service";
import {PasswordRestoreService} from "../../services/api/password-restore.service";
import {Router} from "@angular/router";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {RoutingConstants} from "../../types/constants/RoutingConstants";
import {Subject, takeUntil} from "rxjs";

@Component({
  selector: 'app-restore-password-request',
  templateUrl: './restore-password-request.component.html'
})
export class RestorePasswordRequestComponent implements OnDestroy{
  constructor(private _validationService: ValidationService,
              private _passwordRestoreService: PasswordRestoreService,
              private _router: Router,
              private _errorNotificationService: ErrorNotificationService) {}

  public email = '';
  componentDestroyed$: Subject<boolean> = new Subject();

  onRequestRestorePasswordClick(): void {
    let emailFieldValidationResult = this._validationService.validateField(this.email, 'Email');

    if(!emailFieldValidationResult) {
      return;
    }

    this._passwordRestoreService.sendPasswordRestoreRequest(this.email).pipe(takeUntil(this.componentDestroyed$)).subscribe({
      next: _ => {
        this._router.navigateByUrl(RoutingConstants.CheckEmailNote).then(r => r);
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }
}
