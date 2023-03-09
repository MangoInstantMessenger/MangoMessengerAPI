import { RoutingConstants } from './../../types/constants/RoutingConstants';
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ContactsService } from '../../services/api/contacts.service';
import { ErrorNotificationService } from '../../services/messenger/error-notification.service';
import { Contact } from '../../types/models/Contact';
import { UsersService } from '../../services/api/users.service';
import { TokensService } from '../../services/messenger/tokens.service';
import { User } from '../../types/models/User';
import { CommunitiesService } from '../../services/api/communities.service';
import { Router } from '@angular/router';
import { StartDirectChatQueryObject } from '../../types/query-objects/StartDirectChatQueryObject';
import { RoutingService } from '../../services/messenger/routing.service';
import { Subject, takeUntil } from 'rxjs';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html'
})
export class ContactsComponent implements OnInit, OnDestroy {
  constructor(
    private _contactsService: ContactsService,
    private _errorNotificationService: ErrorNotificationService,
    private _usersService: UsersService,
    private _tokensService: TokensService,
    private _communitiesService: CommunitiesService,
    private _router: Router,
    private _routingService: RoutingService
  ) {}

  public contacts: Contact[] = [];
  public activeUser: User = {
    userId: '',
    displayName: '',
    displayNameColour: 0,
    birthdayDate: '',
    email: '',
    website: '',
    username: '',
    bio: '',
    userNameChanged: false,
    address: '',
    facebook: '',
    twitter: '',
    instagram: '',
    linkedIn: '',
    publicKey: 0,
    pictureUrl: ''
  };
  public currentUserId = '';
  public activeUserId = '';
  public contactSearchQuery = '';
  public isActiveUserContact = false;
  public contactFilter = 'All contacts';

  componentDestroyed$: Subject<boolean> = new Subject();

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  ngOnInit(): void {
    const tokens = this._tokensService.getTokens();

    if (!tokens) {
      this._router.navigateByUrl(this.routingConstants.Login).then((r) => r);
      return;
    }

    this.currentUserId = this._tokensService.getTokens()?.userId as string;
    this._usersService
      .getUserById(this.currentUserId)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          const user = response.user;
          this.getUsersContacts();
          this.activeUserId = user.userId;
          this.activeUser = user;
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  getUsersContacts(): void {
    this._contactsService
      .getCurrentUserContacts()
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          this.contacts = response.contacts;
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onContactTabClick(contact: Contact): void {
    this._usersService
      .getUserById(contact.userId)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          const user = response.user;
          this.activeUserId = user.userId;
          this.activeUser = user;
          this.isActiveUserContact = contact.isContact;
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onContactSearchQueryChange(): void {
    if (this.contactSearchQuery != '') {
      this._contactsService
        .searchContacts(this.contactSearchQuery)
        .pipe(takeUntil(this.componentDestroyed$))
        .subscribe({
          next: (response) => {
            this.contactFilter = 'Search results';
            this.contacts = response.contacts;
          },
          error: (error) => {
            this._errorNotificationService.notifyOnError(error);
          }
        });
    } else {
      this.contactFilter = 'All contacts';
      this.ngOnInit();
    }
  }

  onAddContactClick(contactId: string): void {
    this._contactsService
      .addContact(contactId)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (_) => {
          this.isActiveUserContact = true;
          this.contactFilter = 'All contacts';
          this.contactSearchQuery = '';
          this.ngOnInit();
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onContactFilterClick(event: Event): void {
    const div = event.currentTarget as HTMLDivElement;
    this.contactFilter = div.innerText;

    this._contactsService
      .getCurrentUserContacts()
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          switch (this.contactFilter) {
            case 'All contacts':
              this.contactSearchQuery = '';
              this.contacts = response.contacts;
              break;
          }
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onStartDirectChatButtonClick(contactId: string): void {
    this._communitiesService
      .createChat(contactId)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          const queryObject: StartDirectChatQueryObject = {
            chatId: response.chatId
          };
          this._routingService.setQueryData(queryObject);
          this._router.navigateByUrl('app?methodName=chats').then((r) => r);
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onRemoveContactButtonClick(contactId: string): void {
    this._contactsService
      .deleteContact(contactId)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (_) => {
          this.ngOnInit();
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }
}
