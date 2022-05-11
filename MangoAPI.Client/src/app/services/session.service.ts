import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { LoginCommand } from '../types/requests/LoginCommand';
import { ITokensResponse } from '../types/responses/ITokensResponse';
import { IBaseResponse } from '../types/responses/IBaseResponse';
import { ITokens } from '../types/models/ITokens';

@Injectable({
  providedIn: 'root'
})
export class SessionService {
  private sessionsRoute = 'api/sessions/';
  private readonly LocalStorageTokenKey = 'MANGO_TOKEN';

  constructor(private httpClient: HttpClient) {}

  // POST /api/sessions
  createSession(command: LoginCommand): Observable<ITokensResponse> {
    return this.httpClient.post<ITokensResponse>(
      environment.baseUrl + this.sessionsRoute,
      command,
      { withCredentials: true }
    );
  }

  // POST /api/sessions/{refreshToken}
  refreshSession(refreshToken: string | null): Observable<ITokensResponse> {
    return this.httpClient.post<ITokensResponse>(
      environment.baseUrl + this.sessionsRoute + refreshToken,
      {}
    );
  }

  // DELETE /api/sessions/{refreshToken}
  deleteSession(refreshToken: string | null): Observable<IBaseResponse> {
    return this.httpClient.delete<IBaseResponse>(
      environment.baseUrl + this.sessionsRoute + refreshToken
    );
  }

  // DELETE /api/sessions
  deleteAllSessions(): Observable<IBaseResponse> {
    return this.httpClient.delete<IBaseResponse>(
      environment.baseUrl + this.sessionsRoute
    );
  }

  getTokens(): ITokens | null {
    const tokensString = localStorage.getItem(this.LocalStorageTokenKey);

    return tokensString === null ? null : JSON.parse(tokensString);
  }

  setTokens(tokens: ITokens): void {
    const tokensStringify = JSON.stringify(tokens);
    localStorage.setItem(this.LocalStorageTokenKey, tokensStringify);
  }

  clearTokens(): void {
    localStorage.removeItem(this.LocalStorageTokenKey);
  }
}
