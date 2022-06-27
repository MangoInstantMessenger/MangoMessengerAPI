import {BaseResponse} from "./BaseResponse";
import {Contact} from "../models/Contact";

export interface GetContactsResponse extends BaseResponse {
  contacts: Contact[];
}
