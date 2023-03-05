// noinspection TypeScriptUnresolvedVariable
import { Component, OnDestroy, OnInit } from '@angular/core';
import { ErrorNotificationService } from 'src/app/services/messenger/error-notification.service';
import { ContactsService } from 'src/app/services/api/contacts.service';
import { TokensService } from '../../services/messenger/tokens.service';
import { UpdateUserSocialsCommand } from '../../types/requests/UpdateUserSocialsCommand';
import { ChangePasswordCommand } from '../../types/requests/ChangePasswordCommand';
import { UsersService } from '../../services/api/users.service';
import { User } from '../../types/models/User';
import { ValidationService } from '../../services/messenger/validation.service';
import { UpdateAccountInformationCommand } from '../../types/requests/UpdateAccountInformationCommand';
import { SessionService } from '../../services/api/session.service';
import { Router } from '@angular/router';
import { Subject, takeUntil } from 'rxjs';
import { RoutingConstants } from 'src/app/types/constants/RoutingConstants';
import { AppInfoService } from 'src/app/services/api/app-info.service';

@Component({
  selector: 'app-settings',
  templateUrl: './settings.component.html'
})
export class SettingsComponent implements OnInit, OnDestroy {
  constructor(
    private _contactsService: ContactsService,
    private _errorNotificationService: ErrorNotificationService,
    private _usersService: UsersService,
    private _appInfoService: AppInfoService,
    private _tokensService: TokensService,
    private _validationService: ValidationService,
    private _sessionService: SessionService,
    private _router: Router
  ) {}

  public apiVersion: string = "";
  public currentUser: User = {
    userId: '',
    displayName: '',
    displayNameColour: 0,
    birthdayDate: '',
    email: '',
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

  onLogoutClick(): void {
    const refreshToken = this._tokensService.getTokens()?.refreshToken as string;
    this._sessionService
      .deleteSession(refreshToken)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (_) => {
          this._tokensService.clearTokens();
          this._router.navigateByUrl('app?methodName=login').then((r) => r);
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onLogoutAllClick(): void {
    this._sessionService
      .deleteAllSessions()
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (_) => {
          this._tokensService.clearTokens();
          this._router.navigateByUrl('app?methodName=login').then((r) => r);
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
  }

  onSaveChangesAccountInfoClick(): void {
    const command: UpdateAccountInformationCommand = {
      username: this.currentUser.username,
      birthdayDate: this.currentUser.birthdayDate,
      website: this.currentUser.website,
      address: this.currentUser.address,
      bio: this.currentUser.bio,
      displayName: this.currentUser.displayName
    };

    this._usersService
      .updateUserAccountInformation(command)
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

  onSaveChangesUpdateProfilePictureClick(): void {
    const formData = new FormData();
    const validationResult = this._validationService.validatePictureFileName(this.fileName);

    if (!validationResult) {
      return;
    }

    const file = this.file as File;
    formData.append('pictureFile', file);

    this._usersService
      .updateProfilePicture(formData)
      .pipe(takeUntil(this.componentDestroyed$))
      .subscribe({
        next: (response) => {
          this.clearProfilePictureFile();
          alert(response.message);
          this.currentUser.pictureUrl = response.newUserPictureUrl;
        },
        error: (error) => {
          this._errorNotificationService.notifyOnError(error);
        }
      });
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
    const command: UpdateUserSocialsCommand = {
      instagram: this.currentUser.instagram,
      facebook: this.currentUser.facebook,
      twitter: this.currentUser.twitter,
      linkedIn: this.currentUser.linkedIn
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

  clearProfilePictureFile(): void {
    this.file = null;
    this.fileName = '';
  }
}
