import {BaseResponse} from "./BaseResponse";
import {User} from "../models/User";

export interface GetUserResponse extends BaseResponse {
  user: User;
}
