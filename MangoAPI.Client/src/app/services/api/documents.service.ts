import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { environment } from '../../../environments/environment';
import { UploadDocumentResponse } from '../../types/responses/UploadDocumentResponse';

@Injectable({
  providedIn: 'root'
})
export class DocumentsService {
  private documentsRoute = 'api/documents/';

  constructor(private httpClient: HttpClient) {}

  // POST /api/documents
  uploadDocument(formData: FormData): Observable<UploadDocumentResponse> {
    return this.httpClient.post<UploadDocumentResponse>(
      environment.baseUrl + this.documentsRoute,
      formData
    );
  }
}
