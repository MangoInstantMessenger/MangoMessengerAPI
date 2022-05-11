import {IBaseResponse} from "./IBaseResponse";

export interface ISendMessageResponse extends IBaseResponse {
  messageId: string;
}
