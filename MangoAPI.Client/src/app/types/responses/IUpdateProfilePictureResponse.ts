import {IBaseResponse} from "./IBaseResponse";

export interface IUpdateProfilePictureResponse extends IBaseResponse {
  newUserPictureUrl: string;
}
