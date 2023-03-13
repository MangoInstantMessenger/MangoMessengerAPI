import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { BaseResponse } from '../../types/responses/BaseResponse';
import ApiBaseService from './api-base.service';

@Injectable({
  providedIn: 'root'
})
export class UserChatsService extends ApiBaseService {
  private userChatsRoute = 'api/user-chats/';
  private readonly baseUrl: string;

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  // POST /api/user-chats/{chatId}
  joinCommunity(chatId: string): Observable<BaseResponse> {
    return this.httpClient.post<BaseResponse>(this.baseUrl + this.userChatsRoute + chatId, {});
  }

  // PUT /api/user-chats/{chatId}
  archiveCommunity(chatId: string): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(this.baseUrl + this.userChatsRoute + chatId, {});
  }

  // DELETE /api/user-chats/{chatId}
  leaveCommunity(chatId: string): Observable<BaseResponse> {
    return this.httpClient.delete<BaseResponse>(this.baseUrl + this.userChatsRoute + chatId);
  }
}
