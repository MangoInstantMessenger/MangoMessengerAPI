import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { GetUserChatsResponse } from '../../types/responses/GetUserChatsResponse';
import { GetAppInfoResponse } from '../../types/responses/GetAppInfoResponse';
import ApiBaseService from './apiBase.service';

@Injectable({
  providedIn: 'root'
})
export class AppInfoService extends ApiBaseService {
  private chatsRoute = 'api/app-info/';
  private readonly baseUrl: string;

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  // GET /api/app-info
  getAppInfo(): Observable<GetAppInfoResponse> {
    return this.httpClient.get<GetAppInfoResponse>(this.baseUrl + this.chatsRoute);
  }
}
