import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GetChatMessagesResponse } from '../../types/responses/GetChatMessagesResponse';
import { SendMessageResponse } from '../../types/responses/SendMessageResponse';
import { DeleteMessageResponse } from '../../types/responses/DeleteMessageResponse';
import { EditMessageCommand } from '../../types/requests/EditMessageCommand';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { DeleteMessageCommand } from '../../types/requests/DeleteMessageCommand';
import ApiBaseService from './apiBase.service';

@Injectable({
  providedIn: 'root'
})
export class MessagesService extends ApiBaseService {
  private messagesRoute = 'api/messages/';
  private readonly baseUrl: string;

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  // GET /api/messages/{chatId}
  getChatMessages(chatId: string): Observable<GetChatMessagesResponse> {
    return this.httpClient.get<GetChatMessagesResponse>(this.baseUrl + this.messagesRoute + chatId);
  }

  // POST /api/messages
  sendMessage(request: FormData): Observable<SendMessageResponse> {
    return this.httpClient.post<SendMessageResponse>(this.baseUrl + this.messagesRoute, request);
  }

  // DELETE /api/messages/{messageId}
  deleteMessage(request: DeleteMessageCommand): Observable<DeleteMessageResponse> {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
      body: request
    };

    return this.httpClient.delete<DeleteMessageResponse>(
      this.baseUrl + this.messagesRoute,
      options
    );
  }

  // PUT /api/messages
  editMessage(request: EditMessageCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(this.baseUrl + this.messagesRoute, request);
  }

  // GET /api/messages/searches/{chatId}
  searchMessages(chatId: string, text: string): Observable<GetChatMessagesResponse> {
    return this.httpClient.get<GetChatMessagesResponse>(
      this.baseUrl + this.messagesRoute + 'searches/' + chatId + '?messageText=' + text
    );
  }
}
