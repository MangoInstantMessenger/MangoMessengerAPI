import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { UpdatePersonalInformationCommand } from '../../types/requests/UpdatePersonalInformationCommand';
import { BaseResponse } from '../../types/responses/BaseResponse';
import { GetUserResponse } from '../../types/responses/GetUserResponse';
import { RegisterCommand } from '../../types/requests/RegisterCommand';
import { UpdateAccountInformationCommand } from '../../types/requests/UpdateAccountInformationCommand';
import { SearchContactsResponse } from '../../types/responses/SearchContactsResponse';
import { ChangePasswordCommand } from '../../types/requests/ChangePasswordCommand';
import { UpdateProfilePictureResponse } from '../../types/responses/UpdateProfilePictureResponse';
import { TokensResponse } from 'src/app/types/responses/TokensResponse';
import ApiBaseService from './api-base.service';
import { UpdatePersonalInformationResponse } from '../../types/responses/UpdatePersonalInformationResponse';
import { UpdateUserAccountInfoResponse } from '../../types/responses/UpdateUserAccountInfoResponse';

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
  updateUserSocials(
    request: UpdatePersonalInformationCommand
  ): Observable<UpdatePersonalInformationResponse> {
    return this.httpClient.put<UpdatePersonalInformationResponse>(
      this.baseUrl + this.usersRoute + 'socials/',
      request
    );
  }

  // GET /api/users/{userId}
  getUserById(userId: string | null): Observable<GetUserResponse> {
    return this.httpClient.get<GetUserResponse>(this.baseUrl + this.usersRoute + userId);
  }

  // POST /api/users
  register(command: RegisterCommand): Observable<TokensResponse> {
    return this.httpClient.post<TokensResponse>(this.baseUrl + this.usersRoute, command);
  }

  // PUT /api/users/account
  updateUserAccountInformation(
    request: UpdateAccountInformationCommand
  ): Observable<UpdateUserAccountInfoResponse> {
    return this.httpClient.put<UpdateUserAccountInfoResponse>(
      this.baseUrl + this.usersRoute + 'account/',
      request
    );
  }

  // PUT /api/users/password
  changePassword(request: ChangePasswordCommand): Observable<BaseResponse> {
    return this.httpClient.put<BaseResponse>(this.baseUrl + this.usersRoute + 'password/', request);
  }

  // POST /api/users/picture/{image}
  updateProfilePicture(formData: FormData): Observable<UpdateProfilePictureResponse> {
    return this.httpClient.post<UpdateProfilePictureResponse>(
      this.baseUrl + this.usersRoute + 'picture',
      formData
    );
  }
}
