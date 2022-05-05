import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { IBaseResponse } from '../types/responses/IBaseResponse';
import { ResetPasswordRequest } from '../types/requests/ResetPasswordRequest';

@Injectable({
  providedIn: 'root'
})
export class PasswordResetService {
  constructor(private httpClient: HttpClient) {}

  private currentRoute = 'api/password-restore-request/';

  // POST /api/password-restore-request/{emailOrPhone}
  sendPasswordResetRequest(email: string): Observable<IBaseResponse> {
    return this.httpClient.post<IBaseResponse>(
      environment.baseUrl + this.currentRoute + email,
      {}
    );
  }

  // PUT /api/password-restore-request
  resetPassword(request: ResetPasswordRequest): Observable<IBaseResponse> {
    return this.httpClient.put<IBaseResponse>(
      environment.baseUrl + this.currentRoute,
      request
    );
  }
}
