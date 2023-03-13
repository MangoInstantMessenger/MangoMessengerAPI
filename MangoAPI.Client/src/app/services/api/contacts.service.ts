import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { GetContactsResponse } from '../../types/responses/GetContactsResponse';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { SearchContactsResponse } from '../../types/responses/SearchContactsResponse';
import ApiBaseService from './api-base.service';

@Injectable({
  providedIn: 'root'
})
export class ContactsService extends ApiBaseService {
  private contactsRoute = 'api/contacts/';
  private readonly baseUrl: string;

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  // GET /api/contacts
  getCurrentUserContacts(): Observable<GetContactsResponse> {
    return this.httpClient.get<GetContactsResponse>(this.baseUrl + this.contactsRoute);
  }

  // POST /api/contacts/{contactId}
  addContact(userId: string): Observable<BaseResponse> {
    return this.httpClient.post<GetContactsResponse>(
      this.baseUrl + this.contactsRoute + userId,
      {}
    );
  }

  // DELETE /api/contacts/{contactId}
  deleteContact(userId: string): Observable<BaseResponse> {
    return this.httpClient.delete<GetContactsResponse>(this.baseUrl + this.contactsRoute + userId);
  }

  // GET /api/contacts/searches
  searchContacts(displayName: string): Observable<SearchContactsResponse> {
    return this.httpClient.get<SearchContactsResponse>(
      this.baseUrl + this.contactsRoute + 'searches?searchQuery=' + displayName
    );
  }
}
