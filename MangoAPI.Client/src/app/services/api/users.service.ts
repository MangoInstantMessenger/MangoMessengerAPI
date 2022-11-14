import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { environment } from '../../../environments/environment';
import { UpdateUserSocialsCommand } from '../../types/requests/UpdateUserSocialsCommand';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { GetUserResponse } from '../../types/responses/GetUserResponse';
import { RegisterCommand } from '../../types/requests/RegisterCommand';
import { VerifyEmailCommand } from '../../types/requests/VerifyEmailCommand';
import { UpdateAccountInformationCommand } from '../../types/requests/UpdateAccountInformationCommand';
import { SearchContactsResponse } from '../../types/responses/SearchContactsResponse';
import { ChangePasswordCommand } from '../../types/requests/ChangePasswordCommand';
import { User } from '../../types/models/User';
import { UpdateProfilePictureResponse } from '../../types/responses/UpdateProfilePictureResponse';
import { TokensResponse } from 'src/app/types/responses/TokensResponse';

@Injectable({
  providedIn: 'root'
})
export class UsersService {
  private usersRoute = 'api/users/';

  constructor(private httpClient: HttpClient) {}

  // PUT /api/users/socials
  updateUserSocials(request: UpdateUserSocialsCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(
      environment.baseUrl + this.usersRoute + 'socials/',
      request
    );
  }

  // GET /api/users/{userId}
  getUserById(userId: string | null): Observable<GetUserResponse> {
    return this.httpClient.get<GetUserResponse>(environment.baseUrl + this.usersRoute + userId);
  }

  // POST /api/users
  createUser(command: RegisterCommand): Observable<TokensResponse> {
    return this.httpClient.post<TokensResponse>(environment.baseUrl + this.usersRoute, command);
  }

  // PUT /api/users/email-confirmation
  confirmEmail(request: VerifyEmailCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(
      environment.baseUrl + this.usersRoute + 'email-confirmation/',
      request
    );
  }

  // PUT /api/users/{phoneCode}
  confirmPhone(phoneCode: number): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(environment.baseUrl + this.usersRoute + phoneCode, {});
  }

  // PUT /api/users/account
  updateUserAccountInformation(request: UpdateAccountInformationCommand): Observable<BaseResponse> {
    return this.httpClient.put<SearchContactsResponse>(
      environment.baseUrl + this.usersRoute + 'account/',
      request
    );
  }

  // PUT /api/users/password
  changePassword(request: ChangePasswordCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(
      environment.baseUrl + this.usersRoute + 'password/',
      request
    );
  }

  getUserProfilePicture(user: User): string {
    return user.pictureUrl ? user.pictureUrl : 'assets/media/avatar/4.png';
  }

  // POST /api/users/picture/{image}
  updateProfilePicture(formData: FormData): Observable<UpdateProfilePictureResponse> {
    return this.httpClient.post<UpdateProfilePictureResponse>(
      environment.baseUrl + this.usersRoute + 'picture',
      formData
    );
  }
}
