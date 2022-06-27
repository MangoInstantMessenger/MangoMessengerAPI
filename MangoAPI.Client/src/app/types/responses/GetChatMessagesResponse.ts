import {BaseResponse} from "./BaseResponse";
import {Message} from "../models/Message";

export interface GetChatMessagesResponse extends BaseResponse {
  messages: Message[];
}
