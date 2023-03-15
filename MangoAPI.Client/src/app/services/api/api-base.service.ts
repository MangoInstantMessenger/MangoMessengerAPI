import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export default class ApiBaseService {
  private readonly LocalStorageBaseUrl = 'baseUrl';

  getUrl(): string {
    const urlString = localStorage.getItem(this.LocalStorageBaseUrl);

    if (urlString === null) throw new Error('Url not defined');

    return urlString;
  }
}
