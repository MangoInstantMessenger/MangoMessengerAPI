import {BaseResponse} from "./BaseResponse";

export interface UploadDocumentResponse extends BaseResponse {
  fileName: string;
  fileUrl: string;
}
