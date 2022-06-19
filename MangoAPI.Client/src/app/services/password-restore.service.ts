import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { IBaseResponse } from '../types/responses/IBaseResponse';
import { RestorePasswordRequest } from '../types/requests/RestorePasswordRequest';

@Injectable({
  providedIn: 'root'
})
export class PasswordRestoreService {
  constructor(private httpClient: HttpClient) {}

  private currentRoute = 'api/password-restore-request';

  // POST /api/password-restore-request/{emailOrPhone}
  sendPasswordRestoreRequest(email: string): Observable<IBaseResponse> {
    return this.httpClient.post<IBaseResponse>(
      environment.baseUrl + this.currentRoute + '?email=' + email,
      {}
    );
  }

  // PUT /api/password-restore-request
  restorePassword(request: RestorePasswordRequest): Observable<IBaseResponse> {
    return this.httpClient.put<IBaseResponse>(
      environment.baseUrl + this.currentRoute,
      request
    );
  }
}
