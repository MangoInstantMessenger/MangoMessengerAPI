import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { IGetUserChatsResponse } from '../../types/responses/IGetUserChatsResponse';
import { ICreateCommunityResponse } from '../../types/responses/ICreateCommunityResponse';
import { CreateChatCommand } from '../../types/requests/CreateChatCommand';
import { CreateChannelCommand } from '../../types/requests/CreateChannelCommand';
import { IUpdateChatLogoResponse } from '../../types/responses/IUpdateChatLogoResponse';

@Injectable({
  providedIn: 'root'
})
export class CommunitiesService {
  private chatsRoute = 'api/communities/';

  constructor(private httpClient: HttpClient) {}

  // GET /api/communities
  getUserChats(): Observable<IGetUserChatsResponse> {
    return this.httpClient.get<IGetUserChatsResponse>(
      environment.baseUrl + this.chatsRoute
    );
  }

  // POST /api/communities/chat
  createChat(userId: string): Observable<ICreateCommunityResponse> {
    let request = new CreateChatCommand(userId);
    return this.httpClient.post<ICreateCommunityResponse>(
      environment.baseUrl + this.chatsRoute + `chat/${userId}`,
      request
    );
  }

  // POST /api/communities/channel
  createChannel(
    request: CreateChannelCommand
  ): Observable<ICreateCommunityResponse> {
    return this.httpClient.post<ICreateCommunityResponse>(
      environment.baseUrl + this.chatsRoute + 'channel',
      request
    );
  }

  // GET /api/communities/searches
  searchChat(displayName: string): Observable<IGetUserChatsResponse> {
    return this.httpClient.get<IGetUserChatsResponse>(
      environment.baseUrl +
        this.chatsRoute +
        'searches?displayName=' +
        displayName
    );
  }

  // PUT /api/communities/picture
  updateChatLogo(
    chatId: string,
    formData: FormData
  ): Observable<IUpdateChatLogoResponse> {
    return this.httpClient.post<IUpdateChatLogoResponse>(
      environment.baseUrl + this.chatsRoute + `picture/${chatId}`,
      formData
    );
  }
}
