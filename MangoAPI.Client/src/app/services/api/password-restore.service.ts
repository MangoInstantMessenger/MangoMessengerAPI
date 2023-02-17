import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { RestorePasswordRequest } from '../../types/requests/RestorePasswordRequest';
import ApiBase from './ApiBase';

@Injectable({
  providedIn: 'root'
})
export class PasswordRestoreService extends ApiBase {
  private readonly baseUrl: string; 

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  private currentRoute = 'api/password-restore-request';

  // POST /api/password-restore-request/{emailOrPhone}
  sendPasswordRestoreRequest(email: string): Observable<BaseResponse> {
    return this.httpClient.post<BaseResponse>(
      this.baseUrl + this.currentRoute + '?email=' + email,
      {}
    );
  }

  // PUT /api/password-restore-request
  restorePassword(request: RestorePasswordRequest): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(this.baseUrl + this.currentRoute, request);
  }
}
