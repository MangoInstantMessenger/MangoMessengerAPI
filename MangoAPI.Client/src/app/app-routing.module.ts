import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GatewayComponent } from './components/gateway/gateway.component';
import { NotFoundComponent } from './components/not-found/not-found.component';
import { RegisterComponent } from './components/register/register.component';
import { ConfirmRegistrationComponent } from './components/confirm-registration/confirm-registration.component';
import { LoginComponent } from './components/login/login.component';
import { ChangePasswordRequestComponent } from './components/change-password-request/change-password-request.component';
import { ChangePasswordComponent } from './components/change-password/change-password.component';
import { ChatsComponent } from './components/chats/chats.component';
import { ContactsComponent } from './components/contacts/contacts.component';
import { SettingsComponent } from './components/settings/settings.component';

const routes: Routes = [
  { path: 'register', component: RegisterComponent },
  { path: 'confirm-registration', component: ConfirmRegistrationComponent },
  { path: 'login', component: LoginComponent },
  {
    path: 'change-password-request',
    component: ChangePasswordRequestComponent
  },
  { path: 'change-password', component: ChangePasswordComponent },
  { path: 'chats', component: ChatsComponent },
  { path: 'contacts', component: ContactsComponent },
  { path: 'settings', component: SettingsComponent },
  { path: 'app', component: GatewayComponent },
  { path: '**', component: NotFoundComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
