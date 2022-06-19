import {Router} from "@angular/router";
import {Injectable} from "@angular/core";

@Injectable({
  providedIn: 'root'
})
export class RoutingService {

  constructor(private router: Router) {  }

  matchMethodName(methodName: string): void {
    switch(methodName) {
      case 'chats':
        this.router.navigate(['chats'], {skipLocationChange: true}).then(r => r);
        break;
      case 'confirmRegistration':
        this.router.navigate(['confirm-registration'], {skipLocationChange: true}).then(r => r);
        break;
      case 'register':
        this.router.navigate(['register'], {skipLocationChange: true}).then(r => r);
        break;
      case 'checkEmailNote':
        this.router.navigate(['check-email-note'], {skipLocationChange: true}).then(r => r);
        break;
      case 'restorePasswordRequest':
        this.router.navigate(['restore-password-request'], {skipLocationChange: true}).then(r => r);
        break;
      case 'restorePassword':
        this.router.navigate(['restore-password'], {skipLocationChange: true}).then(r => r);
        break;
      case 'redirectToConfirmRegistration':
        this.router.navigate(['redirect-to-confirm-registration'], {skipLocationChange: true}).then(r => r);
        break;
      case 'redirectToRestorePassword':
        this.router.navigate(['redirect-to-restore-password'], {skipLocationChange: true}).then(r => r);
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
