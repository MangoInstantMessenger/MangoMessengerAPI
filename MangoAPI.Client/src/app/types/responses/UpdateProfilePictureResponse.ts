import {BaseResponse} from "./BaseResponse";

export interface UpdateProfilePictureResponse extends BaseResponse {
  newUserPictureUrl: string;
}
