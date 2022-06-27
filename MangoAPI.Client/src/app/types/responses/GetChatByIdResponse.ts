import {BaseResponse} from "./BaseResponse";
import {Chat} from "../models/Chat";

export interface GetChatByIdResponse extends BaseResponse {
  chat: Chat;
}
