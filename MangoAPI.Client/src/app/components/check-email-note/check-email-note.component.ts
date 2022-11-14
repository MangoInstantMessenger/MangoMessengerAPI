import { Component } from '@angular/core';
import { RoutingConstants } from '../../types/constants/RoutingConstants';

@Component({
  selector: 'app-check-email-note',
  templateUrl: './check-email-note.component.html'
})
export class CheckEmailNoteComponent {
  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }
}
