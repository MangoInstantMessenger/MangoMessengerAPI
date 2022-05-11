import {IBaseResponse} from "./IBaseResponse";
import {IChat} from "../models/IChat";

export interface IGetUserChatsResponse extends IBaseResponse {
  chats: IChat[];
}
