import {IBaseResponse} from "./IBaseResponse";
import {IContact} from "../models/IContact";

export interface IGetContactsResponse extends IBaseResponse {
  contacts: IContact[];
}
