import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { RestorePasswordRequest } from '../../types/requests/RestorePasswordRequest';

@Injectable({
  providedIn: 'root'
})
export class PasswordRestoreService {
  constructor(private httpClient: HttpClient) {}

  private currentRoute = 'api/password-restore-request';

  // POST /api/password-restore-request/{emailOrPhone}
  sendPasswordRestoreRequest(email: string): Observable<BaseResponse> {
    return this.httpClient.post<BaseResponse>(
      environment.baseUrl + this.currentRoute + '?email=' + email,
      {}
    );
  }

  // PUT /api/password-restore-request
  restorePassword(request: RestorePasswordRequest): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(environment.baseUrl + this.currentRoute, request);
  }
}
