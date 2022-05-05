import {IBaseResponse} from "./IBaseResponse";
import {ITokens} from "../models/ITokens";

export interface ITokensResponse extends IBaseResponse {
  tokens: ITokens;
}
