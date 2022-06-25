import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { IGetContactsResponse } from '../../types/responses/IGetContactsResponse';
import { IBaseResponse } from '../../types/responses/IBaseResponse';
import { ISearchContactsResponse } from '../../types/responses/ISearchContactsResponse';

@Injectable({
  providedIn: 'root'
})
export class ContactsService {
  private contactsRoute = 'api/contacts/';

  constructor(private httpClient: HttpClient) {}

  // GET /api/contacts
  getCurrentUserContacts(): Observable<IGetContactsResponse> {
    return this.httpClient.get<IGetContactsResponse>(
      environment.baseUrl + this.contactsRoute
    );
  }

  // POST /api/contacts/{contactId}
  addContact(userId: string): Observable<IBaseResponse> {
    return this.httpClient.post<IGetContactsResponse>(
      environment.baseUrl + this.contactsRoute + userId,
      {}
    );
  }

  // DELETE /api/contacts/{contactId}
  deleteContact(userId: string): Observable<IBaseResponse> {
    return this.httpClient.delete<IGetContactsResponse>(
      environment.baseUrl + this.contactsRoute + userId
    );
  }

  // GET /api/contacts/searches
  searchContacts(displayName: string): Observable<ISearchContactsResponse> {
    return this.httpClient.get<ISearchContactsResponse>(
      environment.baseUrl +
        this.contactsRoute +
        'searches?searchQuery=' +
        displayName
    );
  }
}
