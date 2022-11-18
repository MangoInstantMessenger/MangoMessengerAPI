import { BaseResponse } from './BaseResponse';
import { Contact } from '../models/Contact';

export interface SearchContactsResponse extends BaseResponse {
  contacts: Contact[];
}
