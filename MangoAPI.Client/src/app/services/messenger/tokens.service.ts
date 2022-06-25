import {Injectable} from "@angular/core";
import {ITokens} from "../../types/models/ITokens";

@Injectable({
  providedIn: 'root'
})
export class TokensService {
  private readonly LocalStorageTokenKey = 'MangoTokens';

  getTokens(): ITokens | null {
    const tokensString = localStorage.getItem(this.LocalStorageTokenKey);

    return tokensString === null ? null : JSON.parse(tokensString);
  }

  setTokens(tokens: ITokens): void {
    const tokensStringify = JSON.stringify(tokens);
    localStorage.setItem(this.LocalStorageTokenKey, tokensStringify);
  }

  clearTokens(): void {
    localStorage.removeItem(this.LocalStorageTokenKey);
  }
}
