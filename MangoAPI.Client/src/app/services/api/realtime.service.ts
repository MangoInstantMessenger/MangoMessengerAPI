import { Injectable } from '@angular/core';
import ApiBaseService from './api-base.service';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { Message } from '../../types/models/Message';

@Injectable({
  providedIn: 'root'
})
export class RealtimeService extends ApiBaseService {
  private route = 'api/realtime/send-new-message-notification';

  private readonly baseUrl: string;

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  sendRealtimeNewMessageNotification(request: Message): Observable<BaseResponse> {
    return this.httpClient.post<BaseResponse>(this.baseUrl + this.route, request);
  }
}
