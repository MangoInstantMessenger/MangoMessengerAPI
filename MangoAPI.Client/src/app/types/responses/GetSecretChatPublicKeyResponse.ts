import { BaseResponse } from './BaseResponse';

export interface GetSecretChatPublicKeyResponse extends BaseResponse {
  publicKey: number;
}
