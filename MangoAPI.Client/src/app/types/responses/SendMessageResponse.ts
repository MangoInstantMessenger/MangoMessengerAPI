import { BaseResponse } from './BaseResponse';
import { Message } from '../models/Message';

export interface SendMessageResponse extends BaseResponse {
  messageModel: Message;
}
