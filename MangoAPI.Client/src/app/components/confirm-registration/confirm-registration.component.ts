import {Component, OnInit} from '@angular/core';
import {ConfirmEmailObject} from "../../types/query-objects/ConfirmEmailObject";
import {Router} from "@angular/router";

@Component({
  selector: 'app-confirm-registration',
  templateUrl: './confirm-registration.component.html',
  styleUrls: ['./confirm-registration.component.scss']
})
export class ConfirmRegistrationComponent implements OnInit {
  constructor(private _router: Router) {
  }

  ngOnInit(): void {
    let queryParams = localStorage.getItem('queryParams') as string;
    let confirmEmailObject = JSON.parse(queryParams) as ConfirmEmailObject;
    console.log(confirmEmailObject);
    localStorage.removeItem('queryParams');
  }
}
