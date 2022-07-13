import { Component } from '@angular/core';
import {ContactsService} from "../../services/api/contacts.service";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {Contact} from "../../types/models/Contact";
import {UsersService} from "../../services/api/users.service";
import {TokensService} from "../../services/messenger/tokens.service";
import {formatDate} from "@angular/common";
import {User} from "../../types/models/User";

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html'
})
export class ContactsComponent {

  constructor(private _contactsService: ContactsService,
              private _errorNotificationService: ErrorNotificationService,
              private _usersService: UsersService,
              private _tokensService: TokensService) {
  }

  public contacts: Contact[] = [];
  public activeContact: User = {
    userId:  '',
    firstName:  '',
    lastName:  '',
    displayName:  '',
    birthdayDate:  '',
    email:  '',
    website:  '',
    username:  '',
    bio:  '',
    address:  '',
    facebook:  '',
    twitter:  '',
    instagram:  '',
    linkedIn:  '',
    publicKey:  0,
    pictureUrl:  '',
  };
  public currentUserId: string = this._tokensService.getTokens()?.userId as string;
  public activeContactUserId: string = '';

  ngOnInit(): void {
    this._usersService.getUserById(this.currentUserId).subscribe({
      next: response => {
        let user = response.user;
        this.getUsersContacts();
        this.activeContactUserId = user.userId;
        this.activeContact = {
          userId: user.userId,
          displayName: user.displayName,
          bio: user.bio,
          address: user.address,
          pictureUrl: user.pictureUrl
        };
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    })

  }

  getUsersContacts(): void {
    this._contactsService.getCurrentUserContacts().subscribe({
      next: response => {
        this.contacts = response.contacts;
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }

  toDateParse(date: string): string {
    return formatDate(date, "dd.MM.yyyy", "en-US");
  }
}
