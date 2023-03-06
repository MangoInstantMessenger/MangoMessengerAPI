import { APP_INITIALIZER, NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { ChatsComponent } from './components/chats/chats.component';
import { ContactsComponent } from './components/contacts/contacts.component';
import { SettingsComponent } from './components/settings/settings.component';
// import { GatewayComponent } from './components/gateway/gateway.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { HTTP_INTERCEPTORS, HttpClientModule, HttpClient } from '@angular/common/http';
import { RequestHeaderInterceptor } from './interceptors/request-header.interceptor';
import { AuthInterceptor } from './interceptors/auth-interceptor.service';
import { DatePipe } from '@angular/common';
import { CreateGroupComponent } from './components/create-group/create-group.component';
import { FormsModule } from '@angular/forms';
import { NavbarComponent } from './components/navbar/navbar.component';

const initializeAppFactory = (): Promise<void> => {
  const configUrl = 'assets/config/config.json';
  const key = 'baseUrl';

  return fetch(configUrl, {
    method: 'GET'
  })
    .then((res) => res.json())
    .then((data) => {
      localStorage.setItem(key, data.baseUrl);
    });
};

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    ChatsComponent,
    ContactsComponent,
    SettingsComponent,
    // GatewayComponent,
    NotFoundComponent,
    CreateGroupComponent,
    NavbarComponent
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, HttpClientModule],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: RequestHeaderInterceptor,
      multi: true
    },
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true },
    {
      provide: APP_INITIALIZER,
      useFactory: () => initializeAppFactory,
      deps: [HttpClient],
      multi: true
    },
    DatePipe
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
