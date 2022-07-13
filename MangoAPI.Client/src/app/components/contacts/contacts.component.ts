import { Component } from '@angular/core';
import {ContactsService} from "../../services/api/contacts.service";
import {ErrorNotificationService} from "../../services/messenger/error-notification.service";
import {Contact} from "../../types/models/Contact";

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html'
})
export class ContactsComponent {

  constructor(private _contactsService: ContactsService,
              private _errorNotificationService: ErrorNotificationService) {
  }

  public contacts: Contact[] = [];
  public activeContact: Contact = {
    userId: '',
    displayName: '',
    bio: '',
    address: '',
    isContact: false,
    pictureUrl: ''
  };
  public activeContactUserId: string = '';

  ngOnInit(): void {
    this.getUsersContacts();
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
}
