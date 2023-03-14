import { RoutingConstants } from '../../types/constants/RoutingConstants';
import { Component, OnInit } from '@angular/core';
import { ContactsService } from '../../services/api/contacts.service';
import { ErrorNotificationService } from '../../services/messenger/error-notification.service';
import { Contact } from '../../types/models/Contact';
import { UsersService } from '../../services/api/users.service';
import { TokensService } from '../../services/messenger/tokens.service';
import { User } from '../../types/models/User';
import { CommunitiesService } from '../../services/api/communities.service';
import { Router } from '@angular/router';
import { RoutingService } from '../../services/messenger/routing.service';
import { firstValueFrom } from 'rxjs';
import { ModalWindowStateService } from 'src/app/services/states/modalWindowState.service';
import { GetContactsResponse } from '../../types/responses/GetContactsResponse';
import { GetUserResponse } from '../../types/responses/GetUserResponse';
import { SearchContactsResponse } from '../../types/responses/SearchContactsResponse';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { CreateCommunityResponse } from '../../types/responses/CreateCommunityResponse';

@Component({
  selector: 'app-contacts',
  templateUrl: './contacts.component.html'
})
export class ContactsComponent implements OnInit {
  constructor(
    private _contactsService: ContactsService,
    private _errorNotificationService: ErrorNotificationService,
    private _usersService: UsersService,
    private _tokensService: TokensService,
    private _communitiesService: CommunitiesService,
    private _router: Router,
    private _routingService: RoutingService,
    public _modalWindowStateService: ModalWindowStateService
  ) {}

  public contacts: Contact[] = [];
  public activeContact: User = {
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
  public currentUserId = '';
  public contactSearchQuery = '';
  public isActiveContactAlreadyAdded = false;
  public contactFilter = 'All contacts';

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }

  async ngOnInit() {
    await this.loadContacts();
  }

  private async loadContacts() {
    const tokens = this._tokensService.getTokens();

    if (!tokens) {
      this._router.navigateByUrl(this.routingConstants.Login).then((r) => r);
      return;
    }

    this.currentUserId = this._tokensService.getTokens()?.userId as string;

    this.contacts = [];

    this.contactFilter = 'All Contacts';

    const contactsSub$ = this._contactsService.getCurrentUserContacts();

    const getContactsResponse = await firstValueFrom<GetContactsResponse>(contactsSub$);

    console.log(getContactsResponse.contacts);

    if (getContactsResponse.contacts.length === 0) {
      console.log('No contacts');
      const currentUserSub$ = this._usersService.getUserById(this.currentUserId);
      const currentUserResponse = await firstValueFrom<GetUserResponse>(currentUserSub$);

      this.activeContact = currentUserResponse.user;
      return;
    }

    this.contacts = getContactsResponse.contacts;
    const displayedContactId = getContactsResponse.contacts[0].userId;
    const displayUserSub$ = this._usersService.getUserById(displayedContactId);
    const displayedContactResult = await firstValueFrom<GetUserResponse>(displayUserSub$);
    this.activeContact = displayedContactResult.user;
    this.isActiveContactAlreadyAdded = true;

    this.contactSearchQuery = '';
  }

  onOpenAvatarClick(): void {
    this._modalWindowStateService.setIsModalWindowShowing(true);
    this._modalWindowStateService.setPicture(this.activeContact.pictureUrl);
  }

  closeModalWindowClick(): void {
    this._modalWindowStateService.setIsModalWindowShowing(false);
    this._modalWindowStateService.setPictureNull();
  }

  async onContactClick(contact: Contact) {
    const getUserSub$ = this._usersService.getUserById(contact.userId);
    const getUserResult = await firstValueFrom<GetUserResponse>(getUserSub$);
    this.activeContact = getUserResult.user;
    this.isActiveContactAlreadyAdded = contact.isContact;
  }

  async onContactSearchQueryChange() {
    if (this.contactSearchQuery === '') {
      await this.loadContacts();
      return;
    }

    const searchContactsSub$ = this._contactsService.searchContacts(this.contactSearchQuery);
    const searchResult = await firstValueFrom<SearchContactsResponse>(searchContactsSub$);

    this.contactFilter = 'Search Results';
    this.contacts = searchResult.contacts;
  }

  async onAddContactClick(contactId: string) {
    const addContactSub$ = this._contactsService.addContact(contactId);
    const addContactResult = await firstValueFrom<BaseResponse>(addContactSub$);

    console.log(addContactResult);

    await this.loadContacts();
  }

  async onContactFilterClick() {
    if (this.contactFilter === 'All Contacts') {
      return;
    }

    await this.loadContacts();
  }

  async onStartDirectChatButtonClick(contactId: string) {
    const newChatSub$ = this._communitiesService.createChat(contactId);
    const newChatResult = await firstValueFrom<CreateCommunityResponse>(newChatSub$);

    console.log(newChatResult.chatId);

    this._router.navigateByUrl('chats').then((r) => r);

    // set local storage new current chat id
    // redirect to chats component
  }

  async onRemoveContactButtonClick(contactId: string) {
    const deleteContactSub$ = this._contactsService.deleteContact(contactId);
    const response = await firstValueFrom<BaseResponse>(deleteContactSub$);
    console.log(response.message);

    await this.loadContacts();
  }
}
