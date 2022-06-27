import {Component, OnInit} from '@angular/core';
import {ConfirmEmailObject} from "../../types/query-objects/ConfirmEmailObject";
import {Router} from "@angular/router";
import {VerifyEmailCommand} from "../../types/requests/VerifyEmailCommand";
import {BaseResponse} from "../../types/responses/BaseResponse";
import {UsersService} from "../../services/api/users.service";
import {RoutingService} from "../../services/messenger/routing.service";
import {RoutingConstants} from "../../types/constants/RoutingConstants";

@Component({
  selector: 'app-confirm-registration',
  templateUrl: './confirm-registration.component.html'
})
export class ConfirmRegistrationComponent implements OnInit {

  public response: BaseResponse = {
    message: "",
    success: false
  };
  public errorMessage = '';

  constructor(private _routingService: RoutingService,
              private _usersService: UsersService,
              private _router: Router) {
  }

  ngOnInit(): void {
    const confirmEmailObject: ConfirmEmailObject = this._routingService.getQueryData();

    if(!confirmEmailObject.email || !confirmEmailObject.emailCode) {
      alert('Verification link invalid or expired');
      return;
    }

    const verifyEmailCommand = new VerifyEmailCommand(confirmEmailObject.email, confirmEmailObject.emailCode);

    this._usersService.confirmEmail(verifyEmailCommand).subscribe(result =>
        this.response = result,
      _ => this.errorMessage = "Invalid or expired activation link.");
  }

  redirectToLogin(): void {
    this._router.navigateByUrl(RoutingConstants.Login).then(r => r);
  }

}
