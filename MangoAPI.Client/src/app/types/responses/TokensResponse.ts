import {BaseResponse} from "./BaseResponse";
import {Tokens} from "../models/Tokens";

export interface TokensResponse extends BaseResponse {
  tokens: Tokens;
}
