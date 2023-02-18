import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { UploadDocumentResponse } from '../../types/responses/UploadDocumentResponse';
import ApiBaseService from './apiBase.service';

@Injectable({
  providedIn: 'root'
})
export class DocumentsService extends ApiBaseService {
  private documentsRoute = 'api/documents/';
  private readonly baseUrl: string;

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  // POST /api/documents
  uploadDocument(formData: FormData): Observable<UploadDocumentResponse> {
    return this.httpClient.post<UploadDocumentResponse>(
      this.baseUrl + this.documentsRoute,
      formData
    );
  }
}
