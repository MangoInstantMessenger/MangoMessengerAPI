import { Injectable } from '@angular/core';
import { Tokens } from '../../types/models/Tokens';

@Injectable({
  providedIn: 'root'
})
export class TokensService {
  private readonly LocalStorageTokenKey = 'MangoTokens';

  getTokens(): Tokens | null {
    const tokensString = localStorage.getItem(this.LocalStorageTokenKey);

    return tokensString === null ? null : JSON.parse(tokensString);
  }

  setTokens(tokens: Tokens): void {
    const tokensStringify = JSON.stringify(tokens);
    localStorage.setItem(this.LocalStorageTokenKey, tokensStringify);
  }

  clearTokens(): void {
    localStorage.removeItem(this.LocalStorageTokenKey);
  }
}
