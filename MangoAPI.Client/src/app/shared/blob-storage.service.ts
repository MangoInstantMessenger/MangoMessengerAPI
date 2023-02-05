import { Injectable } from '@angular/core';
import { BlobServiceClient, ContainerClient } from '@azure/storage-blob';
import { Observable } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class BlobStorageService {

  accountName = "devstoreaccount1";
  containerName = "mangocontainer";
  sas = environment.sasToken;

  constructor() {
  }


  public async listImages(): Promise<string[]> {
    const result: string[] = [];

    const blobs = this.containerClient().listBlobsFlat();
    for await (const blob of blobs) {
      result.push(blob.name);
    }
    return result;
  }

  public downloadImage(name: string, handler: (blob: Blob) => void) {
    const blobClient = this.containerClient().getBlobClient(name);
    blobClient.download().then((response: any) => {
      response.blobBody.then((blob: any) => {
        handler(blob);
      });
    });
  }

  public delete(sas: string, name: string, handler: () => void) {
    const blobClient = this.containerClient().getBlobClient(name);
    blobClient.delete().then(() => {
      handler()
    });
  }

  public async uploadFile(content: Blob, name: string) {
    const blobClient = this.containerClient().getBlockBlobClient(name);
    await blobClient.uploadData(content, { blobHTTPHeaders: { blobContentType: content.type } });
  }

  public containerClient(): ContainerClient {
    let token = ""
    if (this.sas) {
      token = this.sas;
    }
    return new BlobServiceClient(`${environment.blobStorageUrl}${this.accountName}?${token}`).getContainerClient(this.containerName);
  }
}