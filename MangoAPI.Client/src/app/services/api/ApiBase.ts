


export default class ApiBase {
  private readonly LocalStorageBaseUrl = 'baseUrl';

  getUrl(): string {
    const urlString = localStorage.getItem(this.LocalStorageBaseUrl);

    if (urlString === null) throw new Error("Url not defined");

    return urlString;
  }
}