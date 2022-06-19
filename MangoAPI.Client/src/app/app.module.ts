import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { LoginComponent } from './components/login/login.component';
import { RegisterComponent } from './components/register/register.component';
import { RestorePasswordComponent } from './components/restore-password/restore-password.component';
import { RestorePasswordRequestComponent } from './components/restore-password-request/restore-password-request.component';
import { ChatsComponent } from './components/chats/chats.component';
import { ContactsComponent } from './components/contacts/contacts.component';
import { SettingsComponent } from './components/settings/settings.component';
import { ConfirmRegistrationComponent } from './components/confirm-registration/confirm-registration.component';
import { GatewayComponent } from './components/gateway/gateway.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { HTTP_INTERCEPTORS, HttpClientModule } from '@angular/common/http';
import { RequestHeaderInterceptor } from './interceptors/request-header.interceptor';
import { AuthInterceptor } from './interceptors/auth-interceptor.service';
import { DatePipe } from '@angular/common';
import { CreateGroupComponent } from './components/create-group/create-group.component';
import { FormsModule } from '@angular/forms';
import { CheckEmailNoteComponent } from './components/check-email-note/check-email-note.component';
import { RedirectToConfirmRegistrationComponent } from './components/redirect-to-confirm-registration/redirect-to-confirm-registration.component';
import { RedirectToRestorePasswordComponent } from './components/redirect-to-restore-password/redirect-to-restore-password.component';

@NgModule({
  declarations: [
    AppComponent,
    LoginComponent,
    RegisterComponent,
    RestorePasswordComponent,
    RestorePasswordRequestComponent,
    ChatsComponent,
    ContactsComponent,
    SettingsComponent,
    ConfirmRegistrationComponent,
    GatewayComponent,
    NotFoundComponent,
    CreateGroupComponent,
    CheckEmailNoteComponent,
    RedirectToConfirmRegistrationComponent,
    RedirectToRestorePasswordComponent
  ],
  imports: [BrowserModule, AppRoutingModule, FormsModule, HttpClientModule],
  providers: [
    {
      provide: HTTP_INTERCEPTORS,
      useClass: RequestHeaderInterceptor,
      multi: true
    },
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true },
    DatePipe
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}
