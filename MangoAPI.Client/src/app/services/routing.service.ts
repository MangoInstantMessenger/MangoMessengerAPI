import {Router} from "@angular/router";
import {Injectable} from "@angular/core";

@Injectable({
  providedIn: 'root'
})
export class RoutingService {

  constructor(private router: Router) {  }

  matchMethodName(methodName: string): void {
    switch(methodName) {
      case 'confirmRegistration':
        this.router.navigate(['confirm-registration'], {skipLocationChange: true}).then(r => r);
        break;
      case 'register':
        this.router.navigate(['register'], {skipLocationChange: true}).then(r => r);
        break;
      case 'chats':
        this.router.navigate(['chats'], {skipLocationChange: true}).then(r => r);
        break;
      default:
        this.router.navigate(['**'], {skipLocationChange: true}).then(r => r);

    }
  }
}
