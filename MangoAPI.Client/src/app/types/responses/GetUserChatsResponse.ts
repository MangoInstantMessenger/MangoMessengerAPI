import {BaseResponse} from "./BaseResponse";
import {Chat} from "../models/Chat";

export interface GetUserChatsResponse extends BaseResponse {
  chats: Chat[];
}
