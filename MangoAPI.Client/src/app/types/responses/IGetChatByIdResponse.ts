import {IBaseResponse} from "./IBaseResponse";
import {IChat} from "../models/IChat";

export interface IGetChatByIdResponse extends IBaseResponse {
  chat: IChat;
}
