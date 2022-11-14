import { BaseResponse } from './BaseResponse';

export interface SendMessageResponse extends BaseResponse {
  messageId: string;
}
