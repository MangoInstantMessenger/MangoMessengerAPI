// noinspection TypeScriptUnresolvedVariable
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ErrorNotificationService } from 'src/app/services/messenger/error-notification.service';
import { TokensService } from '../../services/messenger/tokens.service';
import { UpdatePersonalInformationRequest } from '../../types/requests/UpdatePersonalInformationRequest';
import { ChangePasswordCommand } from '../../types/requests/ChangePasswordCommand';
import { UsersService } from '../../services/api/users.service';
import { User } from '../../types/models/User';
import { ValidationService } from '../../services/messenger/validation.service';
import { UpdateAccountInformationCommand } from '../../types/requests/UpdateAccountInformationCommand';
import { SessionService } from '../../services/api/session.service';
import { Router } from '@angular/router';
import { firstValueFrom, Subject, takeUntil } from 'rxjs';
import { RoutingConstants } from 'src/app/types/constants/RoutingConstants';
import { AppInfoService } from 'src/app/services/api/app-info.service';
import { ModalWindowStateService } from 'src/app/services/states/modalWindowState.service';
import { UpdateProfilePictureResponse } from '../../types/responses/UpdateProfilePictureResponse';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html'
})
export class SettingsComponent implements OnInit, OnDestroy {
  constructor(
    private _errorNotificationService: ErrorNotificationService,
    private _usersService: UsersService,
    private _appInfoService: AppInfoService,
    private _tokensService: TokensService,
    private _validationService: ValidationService,
    private _sessionService: SessionService,
    public _modalWindowStateService: ModalWindowStateService,
    private _router: Router
  ) {}

  public apiVersion = '';
  public currentUser: User = {
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

  public currentUserForUpdating: User = {
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
  public changePasswordCommand: ChangePasswordCommand = {
    currentPassword: '',
    newPassword: '',
    repeatNewPassword: ''
  };
  public fileName = '';
  public file: File | null = null;
  componentDestroyed$: Subject<boolean> = new Subject();

  public get routingConstants(): typeof RoutingConstants {
    return RoutingConstants;
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
          this.currentUser = response.user;
          this.currentUserForUpdating = { ...response.user };
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
    this._appInfoService
      .getAppInfo()
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          this.apiVersion = response.appInfo.apiVersion;
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  ngOnDestroy(): void {
    this.componentDestroyed$.next(true);
    this.componentDestroyed$.complete();
  }

  onOpenAvatarClick(): void {
    this._modalWindowStateService.setIsModalWindowShowing(true);
    this._modalWindowStateService.setPicture(this.currentUser.pictureUrl);
  }

  closeModalWindowClick(): void {
    this._modalWindowStateService.setIsModalWindowShowing(false);
    this._modalWindowStateService.setPictureNull();
  }

  onLogoutClick(): void {
    const refreshToken = this._tokensService.getTokens()?.refreshToken as string;
    this._sessionService
      .deleteSession(refreshToken)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (_) => {
          this._tokensService.clearTokens();
          this._router.navigateByUrl('login').then((r) => r);
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onSaveChangesAccountInfoClick(): void {
    const command: UpdateAccountInformationCommand = {
      username: this.currentUserForUpdating.username,
      birthday: this.currentUserForUpdating.birthday,
      website: this.currentUserForUpdating.website,
      address: this.currentUserForUpdating.address,
      bio: this.currentUserForUpdating.bio,
      displayName: this.currentUserForUpdating.displayName
    };

    this._usersService
      .updateUserAccountInformation(command)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          this.currentUser = { ...this.currentUserForUpdating };
          alert(response.message);
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onUpdateProfilePictureChange(event: any): void {
    const file: File = event.currentTarget.files[0];

    const validationResult = this._validationService.validatePictureFileName(file.name);

    if (!validationResult) {
      return;
    }

    if (file) {
      this.file = file;
      this.fileName = file.name;
    }
  }

  async onSaveChangesUpdateProfilePictureClick() {
    const formData = new FormData();
    const validationResult = this._validationService.validatePictureFileName(this.fileName);

    if (!validationResult) {
      return;
    }

    const file = this.file as File;
    formData.append('pictureFile', file);

    const updateProfileImage$ = this._usersService.updateProfilePicture(formData);

    try {
      const result = await firstValueFrom<UpdateProfilePictureResponse>(updateProfileImage$);
      alert(result.message);
      this.currentUser.pictureUrl = result.newUserPictureUrl;
      const tokens = this._tokensService.getTokens();

      if (tokens?.userProfilePictureUrl) {
        tokens.userProfilePictureUrl = result.newUserPictureUrl;
        this._tokensService.setTokens(tokens);
      }
    } catch (e: any) {
      alert(e.error.errorMessage);
    }

    this.clearProfilePictureFile();
  }

  onSaveChangesChangePasswordClick(): void {
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

    this._usersService
      .changePassword(this.changePasswordCommand)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          alert(response.message);
          this.clearChangePasswordCommand();
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onSaveChangesSocialsClick(): void {
    const command: UpdatePersonalInformationRequest = {
      facebook: this.currentUserForUpdating.facebook,
      twitter: this.currentUserForUpdating.twitter,
      instagram: this.currentUserForUpdating.instagram,
      linkedIn: this.currentUserForUpdating.linkedIn
    };

    this._usersService
      .updateUserSocials(command)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          alert(response.message);
          this.ngOnInit();
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
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
}
