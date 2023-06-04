// noinspection TypeScriptUnresolvedVariable
import { Component, OnInit } from '@angular/core';
import { TokensService } from '../../services/messenger/tokens.service';
import { UpdatePersonalInformationCommand } from '../../types/requests/UpdatePersonalInformationCommand';
import { ChangePasswordCommand } from '../../types/requests/ChangePasswordCommand';
import { UsersService } from '../../services/api/users.service';
import { User } from '../../types/models/User';
import { ValidationService } from '../../services/messenger/validation.service';
import { UpdateAccountInformationCommand } from '../../types/requests/UpdateAccountInformationCommand';
import { SessionService } from '../../services/api/session.service';
import { Router } from '@angular/router';
import { firstValueFrom } from 'rxjs';
import { RoutingConstants } from 'src/app/types/constants/RoutingConstants';
import { AppInfoService } from 'src/app/services/api/app-info.service';
import { ModalWindowStateService } from 'src/app/services/states/modalWindowState.service';
import { UpdateProfilePictureResponse } from '../../types/responses/UpdateProfilePictureResponse';
import { GetUserResponse } from '../../types/responses/GetUserResponse';
import { GetAppInfoResponse } from '../../types/responses/GetAppInfoResponse';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { SettingsHelper } from './settings.helper';
import { UpdatePersonalInformationResponse } from '../../types/responses/UpdatePersonalInformationResponse';
import { UpdateUserAccountInfoResponse } from '../../types/responses/UpdateUserAccountInfoResponse';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html'
})
export class SettingsComponent implements OnInit {
  constructor(
    private _usersService: UsersService,
    private _appInfoService: AppInfoService,
    private _tokensService: TokensService,
    private _validationService: ValidationService,
    private _sessionService: SessionService,
    public _modalWindowStateService: ModalWindowStateService,
    private _settingsHelper: SettingsHelper,
    private _router: Router
  ) {}

  public apiVersion = '';
  public currentUser: User = this._settingsHelper.generateEmptyUser();
  public currentUserForUpdating: User = this._settingsHelper.generateEmptyUser();
  public currentUserId = '';
  public changePasswordCommand: ChangePasswordCommand = {
    currentPassword: '',
    newPassword: '',
    repeatNewPassword: ''
  };
  public fileName = '';
  public file: File | null = null;

  async ngOnInit() {
    const tokens = this._tokensService.getTokens();

    if (!tokens) {
      this._router.navigateByUrl(this.routingConstants.Login).then((r) => r);
      return;
    }

    this.currentUserId = tokens.userId;

    const getUserInfoSub$ = this._usersService.getUserById(this.currentUserId);

    const getUserInfoResponse = await firstValueFrom<GetUserResponse>(getUserInfoSub$);

    this.currentUser = getUserInfoResponse.user;

    this.currentUserForUpdating = { ...getUserInfoResponse.user };

    const getApiVersionSub$ = this._appInfoService.getAppInfo();

    const versionResponse = await firstValueFrom<GetAppInfoResponse>(getApiVersionSub$);

    this.apiVersion = versionResponse.appInfo.apiVersion;
  }

  async onLogoutClick() {
    const tokens = this._tokensService.getTokens();

    if (!tokens?.refreshToken) {
      this._router.navigateByUrl('login').then((r) => r);
      return;
    }

    const refreshToken = tokens.refreshToken;
    const logoutSub$ = this._sessionService.deleteSession(refreshToken);

    const result = await firstValueFrom<BaseResponse>(logoutSub$);

    if (result.success) {
      this._router.navigateByUrl('login').then((r) => r);
    }
  }

  async onSaveChangesAccountInfoClick() {
    const command = new UpdateAccountInformationCommand(
      this.currentUserForUpdating.birthday,
      this.currentUserForUpdating.website,
      this.currentUserForUpdating.username,
      this.currentUserForUpdating.bio,
      this.currentUserForUpdating.address,
      this.currentUserForUpdating.displayName
    );

    const updateUserInfoSub$ = this._usersService.updateUserAccountInformation(command);

    const response = await firstValueFrom<UpdateUserAccountInfoResponse>(updateUserInfoSub$);

    alert(response.message);

    this.currentUser = response.user;
  }

  async onSavePersonalInformationClick() {
    const command: UpdatePersonalInformationCommand = {
      facebook: this.currentUserForUpdating.facebook,
      twitter: this.currentUserForUpdating.twitter,
      instagram: this.currentUserForUpdating.instagram,
      linkedIn: this.currentUserForUpdating.linkedIn
    };

    const saveSocialsSub$ = this._usersService.updateUserSocials(command);

    const response = await firstValueFrom<UpdatePersonalInformationResponse>(saveSocialsSub$);

    alert(response.message);

    this.currentUser = response.user;
  }

  async onSaveProfilePictureClick() {
    const tokens = this._tokensService.getTokens();

    if (!tokens) {
      alert('Tokens are empty.');
      return;
    }

    const validationResult = this._validationService.validatePictureFileName(this.fileName);

    if (!validationResult) {
      return;
    }

    const formData = new FormData();
    const file = this.file as File;
    formData.append('pictureFile', file);

    try {
      const updateProfileImage$ = this._usersService.updateProfilePicture(formData);

      const result = await firstValueFrom<UpdateProfilePictureResponse>(updateProfileImage$);

      this.currentUser.pictureUrl = result.newUserPictureUrl;

      tokens.userProfilePictureUrl = result.newUserPictureUrl;

      this._tokensService.setTokens(tokens);

      this.clearProfilePictureFile();

      alert(result.message);
    } catch (e) {
      this.clearProfilePictureFile();
    }
  }

  async onSaveChangesChangePasswordClick() {
    const newPasswordValidationResult = this._validationService.validateField(
      'New password',
      this.changePasswordCommand.newPassword
    );
    const currentPasswordValidationResult = this._validationService.validateField(
      'Current password',
      this.changePasswordCommand.currentPassword
    );
    const repeatPasswordValidationResult = this._validationService.validateField(
      'Repeat password',
      this.changePasswordCommand.repeatNewPassword
    );

    if (
      !newPasswordValidationResult ||
      !currentPasswordValidationResult ||
      !repeatPasswordValidationResult
    ) {
      return;
    }

    try {
      const changePassSub$ = this._usersService.changePassword(this.changePasswordCommand);
      await firstValueFrom<BaseResponse>(changePassSub$);
      this.clearChangePasswordCommand();
    } catch (e) {
      this.clearChangePasswordCommand();
    }
  }

  onUpdateProfilePictureChange(event: any): void {
    const file: File = event.currentTarget.files[0];

    const validationResult = this._validationService.validatePictureFileName(file.name);

    if (!validationResult) {
      this.clearProfilePictureFile();
      return;
    }

    if (file) {
      this.file = file;
      this.fileName = file.name;
    }
  }

  clearChangePasswordCommand(): void {
    this.changePasswordCommand = {
      currentPassword: '',
      newPassword: '',
      repeatNewPassword: ''
    };
  }

  clearProfilePictureFile() {
    const fileInput = document.getElementById('ProfilePicture') as HTMLInputElement;

    if (!fileInput) {
      return;
    }

    fileInput.value = '';
    this.file = null;
    this.fileName = '';
  }

  onOpenAvatarClick(): void {
    this._modalWindowStateService.setIsModalWindowShowing(true);
    this._modalWindowStateService.setPicture(this.currentUser.pictureUrl);
  }

  closeModalWindowClick(): void {
    this._modalWindowStateService.setIsModalWindowShowing(false);
    this._modalWindowStateService.setPictureNull();
  }

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
  }
}
