import { Component, OnInit } from '@angular/core';
import {RoutingService} from "../../services/routing.service";
import {ConfirmEmailObject} from "../../types/query-objects/ConfirmEmailObject";

@Component({
  selector: 'app-redirect-to-confirm-registration',
  templateUrl: './redirect-to-confirm-registration.component.html',
  styleUrls: ['./redirect-to-confirm-registration.component.scss']
})
export class RedirectToConfirmRegistrationComponent implements OnInit {

  constructor(private _routingService: RoutingService) { }

  ngOnInit(): void {
    let params = new URLSearchParams(window.location.search);
    const email = params.get('email') as string;
    const emailCode = params.get('emailCode') as string;
    const queryObject: ConfirmEmailObject = { email: email, emailCode: emailCode };
    this._routingService.setQueryData(queryObject);
    this._routingService.matchMethodName('confirmRegistration');
  }

}
