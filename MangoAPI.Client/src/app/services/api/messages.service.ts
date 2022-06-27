import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { GetChatMessagesResponse } from '../../types/responses/GetChatMessagesResponse';
import { SendMessageCommand } from '../../types/requests/SendMessageCommand';
import { SendMessageResponse } from '../../types/responses/SendMessageResponse';
import { DeleteMessageResponse } from '../../types/responses/DeleteMessageResponse';
import { EditMessageCommand } from '../../types/requests/EditMessageCommand';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { DeleteMessageCommand } from '../../types/requests/DeleteMessageCommand';

@Injectable({
  providedIn: 'root'
})
export class MessagesService {
  private messagesRoute = 'api/messages/';

  constructor(private httpClient: HttpClient) {}

  // GET /api/messages/{chatId}
  getChatMessages(chatId: string): Observable<GetChatMessagesResponse> {
    return this.httpClient.get<GetChatMessagesResponse>(
      environment.baseUrl + this.messagesRoute + chatId
    );
  }

  // POST /api/messages
  sendMessage(request: SendMessageCommand): Observable<SendMessageResponse> {
    return this.httpClient.post<SendMessageResponse>(
      environment.baseUrl + this.messagesRoute,
      request
    );
  }

  // DELETE /api/messages/{messageId}
  deleteMessage(
    request: DeleteMessageCommand
  ): Observable<DeleteMessageResponse> {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
      body: request
    };

    return this.httpClient.delete<DeleteMessageResponse>(
      environment.baseUrl + this.messagesRoute,
      options
    );
  }

  // PUT /api/messages
  editMessage(request: EditMessageCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(
      environment.baseUrl + this.messagesRoute,
      request
    );
  }

  // GET /api/messages/searches/{chatId}
  searchMessages(
    chatId: string,
    text: string
  ): Observable<GetChatMessagesResponse> {
    return this.httpClient.get<GetChatMessagesResponse>(
      environment.baseUrl +
        this.messagesRoute +
        'searches/' +
        chatId +
        '?messageText=' +
        text
    );
  }
}
