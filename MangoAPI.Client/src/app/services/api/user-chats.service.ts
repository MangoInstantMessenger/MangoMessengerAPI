import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { BaseResponse } from '../../types/responses/BaseResponse';

@Injectable({
  providedIn: 'root'
})
export class UserChatsService {
  private userChatsRoute = 'api/user-chats/';

  constructor(private httpClient: HttpClient) {}

  // POST /api/user-chats/{chatId}
  joinCommunity(chatId: string): Observable<BaseResponse> {
    return this.httpClient.post<BaseResponse>(
      environment.baseUrl + this.userChatsRoute + chatId,
      {}
    );
  }

  // PUT /api/user-chats/{chatId}
  archiveCommunity(chatId: string): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(
      environment.baseUrl + this.userChatsRoute + chatId,
      {}
    );
  }

  // DELETE /api/user-chats/{chatId}
  leaveCommunity(chatId: string): Observable<BaseResponse> {
    return this.httpClient.delete<BaseResponse>(
      environment.baseUrl + this.userChatsRoute + chatId
    );
  }
}
