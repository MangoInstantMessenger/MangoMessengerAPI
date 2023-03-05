import { AppInfo } from './../models/AppInfo';
import { BaseResponse } from "./BaseResponse";


export interface GetAppInfoResponse extends BaseResponse {
  appInfo: AppInfo;
}
