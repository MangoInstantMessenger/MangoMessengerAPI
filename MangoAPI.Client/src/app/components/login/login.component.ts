import { Component } from '@angular/core';
import {LoginCommand} from "../../types/requests/LoginCommand";
import {SessionService} from "../../services/api/session.service";
import {Router} from "@angular/router";
import {ValidationService} from "../../services/messenger/validation.service";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {TokensService} from "../../services/messenger/tokens.service";
import {RoutingConstants} from "../../types/constants/RoutingConstants";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent {
  constructor(private _sessionService: SessionService,
              private _tokensService: TokensService,
              private _router: Router,
              private _validationService: ValidationService,
              private _errorNotificationService: ErrorNotificationService) {}

  public loginCommand: LoginCommand = {
    email: '',
    password: ''
  }

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  onLoginClick(): void {
    let emailFieldValidationResult = this._validationService.validateField(this.loginCommand.email, 'Email');
    let passwordFieldValidationResult = this._validationService.validateField(this.loginCommand.password, 'Password');

    if(!emailFieldValidationResult || !passwordFieldValidationResult) {
      return;
    }

    this._tokensService.clearTokens();

    this._sessionService.createSession(this.loginCommand).subscribe({
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
