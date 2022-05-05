import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../environments/environment';
import { UpdateUserSocialsCommand } from '../types/requests/UpdateUserSocialsCommand';
import { IBaseResponse } from '../types/responses/IBaseResponse';
import { IGetUserResponse } from '../types/responses/IGetUserResponse';
import { RegisterCommand } from '../types/requests/RegisterCommand';
import { ITokensResponse } from '../types/responses/ITokensResponse';
import { VerifyEmailCommand } from '../types/requests/VerifyEmailCommand';
import { UpdateAccountInformationCommand } from '../types/requests/UpdateAccountInformationCommand';
import { ISearchContactsResponse } from '../types/responses/ISearchContactsResponse';
import { ChangePasswordCommand } from '../types/requests/ChangePasswordCommand';
import { IUser } from '../types/models/IUser';
import { IUpdateProfilePictureResponse } from '../types/responses/IUpdateProfilePictureResponse';

@Injectable({
  providedIn: 'root'
})
export class UsersService {
  private usersRoute = 'api/users/';

  constructor(private httpClient: HttpClient) {}

  // PUT /api/users/socials
  updateUserSocials(
    request: UpdateUserSocialsCommand
  ): Observable<IBaseResponse> {
    return this.httpClient.put<IBaseResponse>(
      environment.baseUrl + this.usersRoute + 'socials/',
      request
    );
  }

  // GET /api/users/{userId}
  getUserById(userId: string | null): Observable<IGetUserResponse> {
    return this.httpClient.get<IGetUserResponse>(
      environment.baseUrl + this.usersRoute + userId
    );
  }

  // POST /api/users
  createUser(command: RegisterCommand): Observable<ITokensResponse> {
    return this.httpClient.post<ITokensResponse>(
      environment.baseUrl + this.usersRoute,
      command
    );
  }

  // PUT /api/users/email-confirmation
  confirmEmail(request: VerifyEmailCommand): Observable<IBaseResponse> {
    return this.httpClient.put<IBaseResponse>(
      environment.baseUrl + this.usersRoute + 'email-confirmation/',
      request
    );
  }

  // PUT /api/users/{phoneCode}
  confirmPhone(phoneCode: number): Observable<IBaseResponse> {
    return this.httpClient.put<IBaseResponse>(
      environment.baseUrl + this.usersRoute + phoneCode,
      {}
    );
  }

  // PUT /api/users/account
  updateUserAccountInformation(
    request: UpdateAccountInformationCommand
  ): Observable<IBaseResponse> {
    return this.httpClient.put<ISearchContactsResponse>(
      environment.baseUrl + this.usersRoute + 'account/',
      request
    );
  }

  // PUT /api/users/password
  changePassword(request: ChangePasswordCommand): Observable<IBaseResponse> {
    return this.httpClient.put<IBaseResponse>(
      environment.baseUrl + this.usersRoute + 'password/',
      request
    );
  }

  getUserProfilePicture(user: IUser): string {
    return user.pictureUrl ? user.pictureUrl : 'assets/media/avatar/4.png';
  }

  // POST /api/users/picture/{image}
  updateProfilePicture(
    formData: FormData
  ): Observable<IUpdateProfilePictureResponse> {
    return this.httpClient.post<IUpdateProfilePictureResponse>(
      environment.baseUrl + this.usersRoute + 'picture',
      formData
    );
  }
}
