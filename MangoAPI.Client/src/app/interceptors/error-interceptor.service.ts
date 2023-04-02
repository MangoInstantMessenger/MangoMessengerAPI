import {
  HttpErrorResponse,
  HttpEvent,
  HttpHandler,
  HttpInterceptor,
  HttpRequest
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Injectable } from '@angular/core';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {
  private handleError(err: HttpErrorResponse) {
    const shouldHandle = err.status === 409 || err.status === 400 || err.status === 0;
    if (shouldHandle && err.status !== 0) {
      const errorMessage = `${err.error.errorMessage}`;
      console.log(JSON.stringify(err));
      alert(errorMessage);
      return;
    }

    if (shouldHandle && err.status === 0) {
      const errorMessage = `${err.message}. Server not responding.`;
      console.log(JSON.stringify(err));
      alert(errorMessage);
      return;
    }
  }

  intercept(request: HttpRequest<unknown>, next: HttpHandler): Observable<HttpEvent<unknown>> {
    return next.handle(request).pipe(
      catchError((error) => {
        if (error instanceof HttpErrorResponse) {
          this.handleError(error);
        }

        return throwError(error);
      })
    );
  }
}
