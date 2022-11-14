import {Component, OnDestroy} from '@angular/core';
import {LoginCommand} from "../../types/requests/LoginCommand";
import {SessionService} from "../../services/api/session.service";
import {Router} from "@angular/router";
import {ValidationService} from "../../services/messenger/validation.service";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {TokensService} from "../../services/messenger/tokens.service";
import {RoutingConstants} from "../../types/constants/RoutingConstants";
import {Subject, takeUntil} from "rxjs";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnDestroy {
  constructor(private _sessionService: SessionService,
              private _tokensService: TokensService,
              private _router: Router,
              private _validationService: ValidationService,
              private _errorNotificationService: ErrorNotificationService) {
  }

  public loginCommand: LoginCommand = {
    email: '',
    password: ''
  }

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  componentDestroyed$: Subject<boolean> = new Subject();

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  login(): void {
    const emailFieldValidationResult = this._validationService.validateField(this.loginCommand.email, 'Email');
    const passwordFieldValidationResult = this._validationService.validateField(this.loginCommand.password, 'Password');

    if (!emailFieldValidationResult || !passwordFieldValidationResult) {
      return;
    }

    this._tokensService.clearTokens();

    this._sessionService.createSession(this.loginCommand).pipe(takeUntil(this.componentDestroyed$)).subscribe({
      next: response => {
        this._tokensService.setTokens(response.tokens);
        this._router.navigateByUrl(this.routingConstants.Chats).then(r => r);
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }
}
