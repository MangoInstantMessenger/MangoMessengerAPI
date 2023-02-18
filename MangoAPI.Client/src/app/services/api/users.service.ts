import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
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
import ApiBaseService from './apiBase.service';

@Injectable({
  providedIn: 'root'
})
export class UsersService extends ApiBaseService {
  private usersRoute = 'api/users/';
  private readonly baseUrl: string;

  constructor(private httpClient: HttpClient) {
    super();
    this.baseUrl = super.getUrl();
  }

  // PUT /api/users/socials
  updateUserSocials(request: UpdateUserSocialsCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(
      this.baseUrl + this.usersRoute + 'socials/',
      request
    );
  }

  // GET /api/users/{userId}
  getUserById(userId: string | null): Observable<GetUserResponse> {
    return this.httpClient.get<GetUserResponse>(this.baseUrl + this.usersRoute + userId);
  }

  // POST /api/users
  createUser(command: RegisterCommand): Observable<TokensResponse> {
    return this.httpClient.post<TokensResponse>(this.baseUrl + this.usersRoute, command);
  }

  // PUT /api/users/email-confirmation
  confirmEmail(request: VerifyEmailCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(
      this.baseUrl + this.usersRoute + 'email-confirmation/',
      request
    );
  }

  // PUT /api/users/{phoneCode}
  confirmPhone(phoneCode: number): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(this.baseUrl + this.usersRoute + phoneCode, {});
  }

  // PUT /api/users/account
  updateUserAccountInformation(request: UpdateAccountInformationCommand): Observable<BaseResponse> {
    return this.httpClient.put<SearchContactsResponse>(
      this.baseUrl + this.usersRoute + 'account/',
      request
    );
  }

  // PUT /api/users/password
  changePassword(request: ChangePasswordCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(
      this.baseUrl + this.usersRoute + 'password/',
      request
    );
  }

  getUserProfilePicture(user: User): string {
    return user.pictureUrl ? user.pictureUrl : 'assets/media/avatar/4.png';
  }

  // POST /api/users/picture/{image}
  updateProfilePicture(formData: FormData): Observable<UpdateProfilePictureResponse> {
    return this.httpClient.post<UpdateProfilePictureResponse>(
      this.baseUrl + this.usersRoute + 'picture',
      formData
    );
  }
}
