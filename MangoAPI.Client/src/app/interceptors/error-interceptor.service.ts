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
    const shouldHandle = err.status === 409 || err.status === 400;
    console.log('123');
    if (shouldHandle) {
      const errorMessage = `${err.error.errorDetails}`;
      alert(errorMessage);
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
