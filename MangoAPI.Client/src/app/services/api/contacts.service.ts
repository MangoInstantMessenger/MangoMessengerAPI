import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { GetContactsResponse } from '../../types/responses/GetContactsResponse';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { SearchContactsResponse } from '../../types/responses/SearchContactsResponse';

@Injectable({
  providedIn: 'root'
})
export class ContactsService {
  private contactsRoute = 'api/contacts/';

  constructor(private httpClient: HttpClient) {}

  // GET /api/contacts
  getCurrentUserContacts(): Observable<GetContactsResponse> {
    return this.httpClient.get<GetContactsResponse>(
      environment.baseUrl + this.contactsRoute
    );
  }

  // POST /api/contacts/{contactId}
  addContact(userId: string): Observable<BaseResponse> {
    return this.httpClient.post<GetContactsResponse>(
      environment.baseUrl + this.contactsRoute + userId,
      {}
    );
  }

  // DELETE /api/contacts/{contactId}
  deleteContact(userId: string): Observable<BaseResponse> {
    return this.httpClient.delete<GetContactsResponse>(
      environment.baseUrl + this.contactsRoute + userId
    );
  }

  // GET /api/contacts/searches
  searchContacts(displayName: string): Observable<SearchContactsResponse> {
    return this.httpClient.get<SearchContactsResponse>(
      environment.baseUrl +
        this.contactsRoute +
        'searches?searchQuery=' +
        displayName
    );
  }
}
