import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { LoginCommand } from '../../types/requests/LoginCommand';
import { TokensResponse } from '../../types/responses/TokensResponse';
import { BaseResponse } from '../../types/responses/BaseResponse';
import ApiBaseService from './apiBase.service';

@Injectable({
  providedIn: 'root'
})
export class SessionService extends ApiBaseService {
  private sessionsRoute = 'api/sessions/';
  private readonly baseUrl: string;

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  // POST /api/sessions
  createSession(command: LoginCommand): Observable<TokensResponse> {
    return this.httpClient.post<TokensResponse>(this.baseUrl + this.sessionsRoute, command, {
      withCredentials: true
    });
  }

  // POST /api/sessions/{refreshToken}
  refreshSession(refreshToken: string | null): Observable<TokensResponse> {
    return this.httpClient.post<TokensResponse>(
      this.baseUrl + this.sessionsRoute + refreshToken,
      {}
    );
  }

  // DELETE /api/sessions/{refreshToken}
  deleteSession(refreshToken: string | null): Observable<BaseResponse> {
    return this.httpClient.delete<BaseResponse>(
      this.baseUrl + this.sessionsRoute + refreshToken
    );
  }

  // DELETE /api/sessions
  deleteAllSessions(): Observable<BaseResponse> {
    return this.httpClient.delete<BaseResponse>(this.baseUrl + this.sessionsRoute);
  }
}
