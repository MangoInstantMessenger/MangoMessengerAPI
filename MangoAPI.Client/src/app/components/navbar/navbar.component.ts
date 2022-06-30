import {Component, Input} from '@angular/core';
import {RoutingConstants} from "../../types/constants/RoutingConstants";

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html'
})
export class NavbarComponent {

  @Input() public activeComponent: string = '';

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

}
