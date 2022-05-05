import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { IGetChatMessagesResponse } from '../types/responses/IGetChatMessagesResponse';
import { SendMessageCommand } from '../types/requests/SendMessageCommand';
import { ISendMessageResponse } from '../types/responses/ISendMessageResponse';
import { IDeleteMessageResponse } from '../types/responses/IDeleteMessageResponse';
import { EditMessageCommand } from '../types/requests/EditMessageCommand';
import { IBaseResponse } from '../types/responses/IBaseResponse';
import { DeleteMessageCommand } from '../types/requests/DeleteMessageCommand';

@Injectable({
  providedIn: 'root'
})
export class MessagesService {
  private messagesRoute = 'api/messages/';

  constructor(private httpClient: HttpClient) {}

  // GET /api/messages/{chatId}
  getChatMessages(chatId: string): Observable<IGetChatMessagesResponse> {
    return this.httpClient.get<IGetChatMessagesResponse>(
      environment.baseUrl + this.messagesRoute + chatId
    );
  }

  // POST /api/messages
  sendMessage(request: SendMessageCommand): Observable<ISendMessageResponse> {
    return this.httpClient.post<ISendMessageResponse>(
      environment.baseUrl + this.messagesRoute,
      request
    );
  }

  // DELETE /api/messages/{messageId}
  deleteMessage(
    request: DeleteMessageCommand
  ): Observable<IDeleteMessageResponse> {
    const options = {
      headers: new HttpHeaders({
        'Content-Type': 'application/json'
      }),
      body: request
    };

    return this.httpClient.delete<IDeleteMessageResponse>(
      environment.baseUrl + this.messagesRoute,
      options
    );
  }

  // PUT /api/messages
  editMessage(request: EditMessageCommand): Observable<IBaseResponse> {
    return this.httpClient.put<IBaseResponse>(
      environment.baseUrl + this.messagesRoute,
      request
    );
  }

  // GET /api/messages/searches/{chatId}
  searchMessages(
    chatId: string,
    text: string
  ): Observable<IGetChatMessagesResponse> {
    return this.httpClient.get<IGetChatMessagesResponse>(
      environment.baseUrl +
        this.messagesRoute +
        'searches/' +
        chatId +
        '?messageText=' +
        text
    );
  }
}
