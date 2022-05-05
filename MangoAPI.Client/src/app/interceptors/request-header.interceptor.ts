import { Injectable } from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpHeaders
} from '@angular/common/http';
import { Observable } from 'rxjs';
import { SessionService } from '../services/session.service';

@Injectable()
export class RequestHeaderInterceptor implements HttpInterceptor {
  constructor(private sessionService: SessionService) {}

  intercept(
    request: HttpRequest<unknown>,
    next: HttpHandler
  ): Observable<HttpEvent<unknown>> {
    const accessToken = this.sessionService.getTokens()?.accessToken;

    const addHeaderRequest = request.clone({
      headers: new HttpHeaders({ Authorization: 'Bearer ' + accessToken })
    });

    return next.handle(addHeaderRequest);
  }
}
