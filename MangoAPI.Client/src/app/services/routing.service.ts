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
      case 'checkEmailNote':
        this.router.navigate(['check-email-note'], {skipLocationChange: true}).then(r => r);
        break;
      case 'redirectToConfirmRegistration':
        this.router.navigate(['redirect-to-confirm-registration'], {skipLocationChange: true}).then(r => r);
        break;
      case 'login':
        this.router.navigate(['login'], {skipLocationChange: true}).then(r => r);
        break;
      default:
        this.router.navigate(['**'], {skipLocationChange: true}).then(r => r);

    }
  }

  setQueryData(queryData: any): void {
    const queryDataStringify = JSON.stringify(queryData);

    localStorage.setItem('queryData', queryDataStringify);
  }

  getQueryData(): any {
    const queryDataString = localStorage.getItem('queryData');

    return queryDataString === null ? null : JSON.parse(queryDataString);
  }
}
