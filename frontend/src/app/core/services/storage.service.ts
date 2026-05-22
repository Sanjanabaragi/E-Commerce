import { Injectable, inject, PLATFORM_ID } from '@angular/core';
import { isPlatformBrowser } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class StorageService {
  private readonly TOKEN_KEY = 'auth_token';
  private platformId = inject(PLATFORM_ID);
  private isBrowser = isPlatformBrowser(this.platformId);

  saveToken(token: string): void {
    if (this.isBrowser) localStorage.setItem(this.TOKEN_KEY, token);
  }

  getToken(): string | null {
    return this.isBrowser ? localStorage.getItem(this.TOKEN_KEY) : null;
  }

  isLoggedIn(): boolean {
    return !!this.getToken();
  }

  clear(): void {
    if (this.isBrowser) localStorage.clear();
  }
}