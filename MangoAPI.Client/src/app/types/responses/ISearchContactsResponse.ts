import {IBaseResponse} from "./IBaseResponse";
import {IContact} from "../models/IContact";

export interface ISearchContactsResponse extends IBaseResponse {
  contacts: IContact[];
}
