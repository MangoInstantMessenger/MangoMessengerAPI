import {IBaseResponse} from "./IBaseResponse";
import {IUser} from "../models/IUser";

export interface IGetUserResponse extends IBaseResponse {
  user: IUser;
}
