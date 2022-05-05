import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../environments/environment';
import { IUploadDocumentResponse } from '../types/responses/IUploadDocumentResponse';

@Injectable({
  providedIn: 'root'
})
export class DocumentsService {
  private documentsRoute = 'api/documents/';

  constructor(private httpClient: HttpClient) {}

  // POST /api/documents
  uploadDocument(formData: FormData): Observable<IUploadDocumentResponse> {
    return this.httpClient.post<IUploadDocumentResponse>(
      environment.baseUrl + this.documentsRoute,
      formData
    );
  }
}
