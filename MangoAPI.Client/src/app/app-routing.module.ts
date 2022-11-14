import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GatewayComponent } from './components/gateway/gateway.component';
import { RegisterComponent } from './components/register/register.component';
import { ConfirmRegistrationComponent } from './components/confirm-registration/confirm-registration.component';
import { LoginComponent } from './components/login/login.component';
import { RestorePasswordRequestComponent } from './components/restore-password-request/restore-password-request.component';
import { RestorePasswordComponent } from './components/restore-password/restore-password.component';
import { ChatsComponent } from './components/chats/chats.component';
import { ContactsComponent } from './components/contacts/contacts.component';
import { SettingsComponent } from './components/settings/settings.component';
import { CreateGroupComponent } from './components/create-group/create-group.component';
import { CheckEmailNoteComponent } from './components/check-email-note/check-email-note.component';
import { RedirectToConfirmRegistrationComponent } from './components/redirect-to-confirm-registration/redirect-to-confirm-registration.component';
import { RedirectToRestorePasswordComponent } from './components/redirect-to-restore-password/redirect-to-restore-password.component';

const routes: Routes = [
  { path: 'register', component: RegisterComponent },
  { path: 'confirm-registration', component: ConfirmRegistrationComponent },
  { path: 'check-email-note', component: CheckEmailNoteComponent },
  {
    path: 'redirect-to-confirm-registration',
    component: RedirectToConfirmRegistrationComponent
  },
  {
    path: 'redirect-to-restore-password',
    component: RedirectToRestorePasswordComponent
  },
  { path: 'login', component: LoginComponent },
  {
    path: 'restore-password-request',
    component: RestorePasswordRequestComponent
  },
  { path: 'restore-password', component: RestorePasswordComponent },
  { path: 'chats', component: ChatsComponent },
  { path: 'contacts', component: ContactsComponent },
  { path: 'settings', component: SettingsComponent },
  { path: 'create-group', component: CreateGroupComponent },
  { path: 'app', component: GatewayComponent },
  { path: '**', component: GatewayComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule {}
