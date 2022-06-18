import {Component, OnInit} from '@angular/core';
import {ConfirmEmailObject} from "../../types/query-objects/ConfirmEmailObject";
import {ActivatedRoute, Router} from "@angular/router";
import {VerifyEmailCommand} from "../../types/requests/VerifyEmailCommand";
import {IBaseResponse} from "../../types/responses/IBaseResponse";
import {UsersService} from "../../services/users.service";
import {RoutingService} from "../../services/routing.service";

@Component({
  selector: 'app-confirm-registration',
  templateUrl: './confirm-registration.component.html',
  styleUrls: ['./confirm-registration.component.scss']
})
export class ConfirmRegistrationComponent implements OnInit {

  public response: IBaseResponse = {
    message: "",
    success: false
  };
  public errorMessage = '';

  constructor(private _routingService: RoutingService,
              private _usersService: UsersService,
              private _router: Router) {
  }

  ngOnInit(): void {
    const confirmEmailObject = this._routingService.getQueryData();

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
    this._router.navigateByUrl('app?methodName=login').then(r => r);
  }

}
