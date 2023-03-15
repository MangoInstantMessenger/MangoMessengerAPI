import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ErrorNotificationService {
  notifyOnError(e: any): void {
    if (e.status === 0) {
      alert('Cannot connect to the server. Response code: 0.');
      return;
    }

    if (e.status === 400 || e.status === 409) {
      const errorMessage = `${e.error.errorMessage}: ${e.error.errorDetails}`;
      alert(errorMessage);
    }
  }
}
