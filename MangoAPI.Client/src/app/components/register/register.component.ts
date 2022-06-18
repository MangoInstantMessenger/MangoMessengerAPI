import {Component} from '@angular/core';
import {Router} from "@angular/router";
import {RegisterCommand} from 'src/app/types/requests/RegisterCommand';
import {UsersService} from "../../services/users.service";
import {ValidationService} from "../../services/validation.service";
import {ErrorNotificationService} from "../../services/error-notification.service";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
  constructor(private _router: Router,
              private _usersService: UsersService,
              private _validationService: ValidationService,
              private _errorNotificationService: ErrorNotificationService) {
  }

  public registerCommand: RegisterCommand = {
    displayName: "",
    email: "",
    password: "",
    termsAccepted: false,
  };

  onRegisterClick(): void {
    let displayNameFieldValidationResult = this._validationService.validateField(this.registerCommand.displayName, 'Display name');
    let emailFieldValidationResult = this._validationService.validateField(this.registerCommand.email, 'Email');
    let passwordFieldValidationResult = this._validationService.validateField(this.registerCommand.password, 'Password');

    if(!displayNameFieldValidationResult || !emailFieldValidationResult || !passwordFieldValidationResult) {
      return;
    }

    if (!this.registerCommand.termsAccepted) {
      alert('Terms not accepted');
      return;
    }

    this._usersService.createUser(this.registerCommand).subscribe(_ => {
        this._router.navigateByUrl('app?methodName=confirmRegistrationNote').then(r => r);
      }, error => {
        this._errorNotificationService.notifyOnError(error);
      }
    );
  }
}
