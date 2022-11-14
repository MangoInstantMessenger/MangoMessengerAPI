import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { GetUserChatsResponse } from '../../types/responses/GetUserChatsResponse';
import { CreateCommunityResponse } from '../../types/responses/CreateCommunityResponse';
import { CreateChatCommand } from '../../types/requests/CreateChatCommand';
import { CreateChannelCommand } from '../../types/requests/CreateChannelCommand';
import { UpdateChatLogoResponse } from '../../types/responses/UpdateChatLogoResponse';

@Injectable({
  providedIn: 'root'
})
export class CommunitiesService {
  private chatsRoute = 'api/communities/';

  constructor(private httpClient: HttpClient) {}

  // GET /api/communities
  getUserChats(): Observable<GetUserChatsResponse> {
    return this.httpClient.get<GetUserChatsResponse>(environment.baseUrl + this.chatsRoute);
  }

  // POST /api/communities/chat
  createChat(userId: string): Observable<CreateCommunityResponse> {
    const request = new CreateChatCommand(userId);
    return this.httpClient.post<CreateCommunityResponse>(
      environment.baseUrl + this.chatsRoute + `chat/${userId}`,
      request
    );
  }

  // POST /api/communities/channel
  createChannel(request: CreateChannelCommand): Observable<CreateCommunityResponse> {
    return this.httpClient.post<CreateCommunityResponse>(
      environment.baseUrl + this.chatsRoute + 'channel',
      request
    );
  }

  // GET /api/communities/searches
  searchChat(displayName: string): Observable<GetUserChatsResponse> {
    return this.httpClient.get<GetUserChatsResponse>(
      environment.baseUrl + this.chatsRoute + 'searches?displayName=' + displayName
    );
  }

  // PUT /api/communities/picture
  updateChatLogo(chatId: string, formData: FormData): Observable<UpdateChatLogoResponse> {
    return this.httpClient.post<UpdateChatLogoResponse>(
      environment.baseUrl + this.chatsRoute + `picture/${chatId}`,
      formData
    );
  }
}
