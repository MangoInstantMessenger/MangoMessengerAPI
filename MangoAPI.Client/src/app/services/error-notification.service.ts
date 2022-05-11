import {Injectable} from "@angular/core";

@Injectable({
  providedIn: 'root'
})
export class ErrorNotificationService {
  notifyOnError(error: any): void {
    if (error.status === 0) {
      alert("Cannot connect to the server. Response code: 0.");
      return;
    }

    if (error.status === 403) {
      alert("Your account is not activated yet. Activate to start chatting. " +
        "Activation links is sent by email after registration.");
      return;
    }

    if (error.status === 409) {
      alert(error.error.errorDetails);
      return;
    }

    if (error.status === 400) {
      alert(error.error.ErrorMessage);
      return;
    }

    if (error.status === 404) {
      console.log(error);
      alert(error.message);
    }
  }

  notifyOnErrorWithComponentName(error: any, componentName: string): void {
    if (error.status === 0) {
      alert("Cannot connect to the server. Response code: 0." + ` ${componentName}`);
      return;
    }

    if (error.status === 403) {
      alert("Your account is not activated yet. Activate to start chatting. " +
        "Activation links is sent by email after registration." + ` ${componentName}`);
      return;
    }

    if (error.status === 409) {
      alert(error.error.errorDetails + ` ${componentName}`);
      return;
    }

    if (error.status === 400) {
      alert(error.error.ErrorMessage + ` ${componentName}`);
      return;
    }
  }
}
