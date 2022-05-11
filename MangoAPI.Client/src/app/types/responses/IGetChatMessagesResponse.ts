import {IBaseResponse} from "./IBaseResponse";
import {IMessage} from "../models/IMessage";

export interface IGetChatMessagesResponse extends IBaseResponse {
  messages: IMessage[];
}
