import {Component} from '@angular/core';
import {Router} from "@angular/router";
import {ConfirmEmailObject} from "../../types/query-objects/ConfirmEmailObject";

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent {
  constructor(private _router: Router) {
  }

  onRegisterClick(): void {
    let confirmEmailObject: ConfirmEmailObject = {
      email: 'test@gmail.com',
      emailCode: 'd1ab1de1-1aa8-4650-937c-4ed882038ad7'
    };
    localStorage.setItem('queryParams', JSON.stringify(confirmEmailObject));

    this._router.navigateByUrl(`app?methodName=confirmRegistration`).then(r => r);
  }
}
