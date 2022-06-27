import {BaseResponse} from "./BaseResponse";

export interface DeleteMessageResponse extends BaseResponse {
  messageId: string;
}
