import { Component, OnDestroy } from '@angular/core';
import { Router } from '@angular/router';
import { RegisterCommand } from 'src/app/types/requests/RegisterCommand';
import { UsersService } from '../../services/api/users.service';
import { ValidationService } from '../../services/messenger/validation.service';
import { RoutingConstants } from '../../types/constants/RoutingConstants';
import { firstValueFrom, Subject } from 'rxjs';
import { TokensService } from 'src/app/services/messenger/tokens.service';
import { TokensResponse } from '../../types/responses/TokensResponse';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html'
})
export class RegisterComponent implements OnDestroy {
  constructor(
    private _router: Router,
    private _usersService: UsersService,
    private _validationService: ValidationService,
    private _tokensService: TokensService
  ) {}

  public registerCommand: RegisterCommand = {
    username: '',
    password: ''
  };

  componentDestroyed$: Subject<boolean> = new Subject();

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  async onRegisterClick() {
    const emailFieldValidationResult = this._validationService.validateField(
      this.registerCommand.username,
      'Username'
    );

    const passwordFieldValidationResult = this._validationService.validateField(
      this.registerCommand.password,
      'Password'
    );

    if (!emailFieldValidationResult || !passwordFieldValidationResult) {
      return;
    }

    const registerSub$ = this._usersService.register(this.registerCommand);

    const result = await firstValueFrom<TokensResponse>(registerSub$);
    this._tokensService.setTokens(result.tokens);
    this._router.navigateByUrl(this.routingConstants.Chats).then((r) => r);
  }
}
