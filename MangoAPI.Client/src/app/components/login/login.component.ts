import { Component, OnDestroy, OnInit } from '@angular/core';
import { LoginCommand } from '../../types/requests/LoginCommand';
import { SessionService } from '../../services/api/session.service';
import { Router } from '@angular/router';
import { ValidationService } from '../../services/messenger/validation.service';
import { TokensService } from '../../services/messenger/tokens.service';
import { RoutingConstants } from '../../types/constants/RoutingConstants';
import {firstValueFrom, Subject, takeUntil} from 'rxjs';
import {TokensResponse} from "../../types/responses/TokensResponse";

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html'
})
export class LoginComponent implements OnDestroy, OnInit {
  constructor(
    private _sessionService: SessionService,
    private _tokensService: TokensService,
    private _router: Router,
    private _validationService: ValidationService
  ) {}

  ngOnInit(): void {
    this._tokensService.clearTokens();
  }

  public loginCommand: LoginCommand = {
    username: '',
    password: ''
  };

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  componentDestroyed$: Subject<boolean> = new Subject();

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  async login() {
    const emailFieldValidationResult = this._validationService.validateField(
      this.loginCommand.username,
      'Email'
    );
    const passwordFieldValidationResult = this._validationService.validateField(
      this.loginCommand.password,
      'Password'
    );

    if (!emailFieldValidationResult || !passwordFieldValidationResult) {
      return;
    }

    this._tokensService.clearTokens();

    const loginSub$ = this._sessionService.createSession(this.loginCommand);
    const response = await firstValueFrom<TokensResponse>(loginSub$);
    this._tokensService.setTokens(response.tokens);
    this._router.navigateByUrl(this.routingConstants.Chats).then((r) => r);
  }
}
