import { BaseResponse } from './BaseResponse';

export interface SendMessageResponse extends BaseResponse {
  newMessageId: string;
  attachmentUrl: string;
  createdAt: string;
}
