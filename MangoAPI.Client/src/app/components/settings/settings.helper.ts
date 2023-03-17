import { Injectable } from '@angular/core';
import { User } from '../../types/models/User';

@Injectable({
  providedIn: 'root'
})
export class SettingsHelper {
  public generateEmptyUser(): User {
    const currentUser: User = {
      userId: '',
      displayName: '',
      displayNameColour: 0,
      birthday: '',
      website: '',
      username: '',
      bio: '',
      address: '',
      facebook: '',
      twitter: '',
      instagram: '',
      linkedIn: '',
      publicKey: 0,
      pictureUrl: ''
    };

    return currentUser;
  }
}
