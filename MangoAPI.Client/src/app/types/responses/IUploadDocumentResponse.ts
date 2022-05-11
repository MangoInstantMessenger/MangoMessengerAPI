import {IBaseResponse} from "./IBaseResponse";

export interface IUploadDocumentResponse extends IBaseResponse {
  fileName: string;
  fileUrl: string;
}
