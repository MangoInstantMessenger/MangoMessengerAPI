import { BaseResponse } from './BaseResponse';
import { User } from '../models/User';

export interface UpdatePersonalInformationResponse extends BaseResponse {
  user: User;
}
