import {Component, OnInit} from '@angular/core';
import {ContactsService} from "../../services/api/contacts.service";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {Contact} from "../../types/models/Contact";
import {UsersService} from "../../services/api/users.service";
import {TokensService} from "../../services/messenger/tokens.service";
import {User} from "../../types/models/User";

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html'
})
export class ContactsComponent implements OnInit {

  constructor(private _contactsService: ContactsService,
              private _errorNotificationService: ErrorNotificationService,
              private _usersService: UsersService,
              private _tokensService: TokensService) {
  }

  public contacts: Contact[] = [];
  public activeContact: User = {
    userId:  '',
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
  public currentUserId: string = '';
  public activeContactUserId: string = '';
  public contactSearchQuery: string = '';

  ngOnInit(): void {
    this.currentUserId = this._tokensService.getTokens()?.userId as string;
    this._usersService.getUserById(this.currentUserId).subscribe({
      next: response => {
        let user = response.user;
        this.getUsersContacts();
        this.activeContactUserId = user.userId;
        this.activeContact = user;
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
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

  onContactTabClick(contactId: string): void {
    this._usersService.getUserById(contactId).subscribe({
      next: response => {
        let contact = response.user;
        this.activeContactUserId = contact.userId;
        this.activeContact = contact;
      },
      error: error => {
        this._errorNotificationService.notifyOnError(error);
      }
    });
  }

  onContactSearchQueryChange(): void {
    if(this.contactSearchQuery != '') {
      this._contactsService.searchContacts(this.contactSearchQuery).subscribe({
        next: response => {
          this.contacts = response.contacts;
        },
        error: error => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
    } else {
      this.ngOnInit();
    }
  }
}
