import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import Config from './types/config/Config';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html'
})
export class AppComponent implements OnInit {
  title = 'Mango Messenger';
  httpClient;

  constructor(http: HttpClient) {
    this.httpClient = http;
  }

  ngOnInit(): void {
    this.httpClient.get<Config>('assets/config/config.json')
    .subscribe(data => localStorage.setItem("baseUrl", data.baseUrl));
  }
}
