import { BaseResponse } from './BaseResponse';
import { User } from '../models/User';

export interface UpdateUserAccountInfoResponse extends BaseResponse {
  user: User;
}
