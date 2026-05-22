import { Injectable } from '@angular/core';
import { inject } from '@angular/core';
import { StorageService } from './storage.service';

@Injectable({
  providedIn: 'root'
})
export class JwtService {
  private storageService = inject(StorageService);

  constructor() {}

  decodeToken(): any {
    const token = this.storageService.getToken();
    if (!token) return null;

    try {
      const base64Url = token.split('.')[1];
      const base64 = base64Url.replace(/-/g, '+').replace(/_/g, '/');
      const jsonPayload = decodeURIComponent(
        window
          .atob(base64)
          .split('')
          .map((c) => '%' + ('00' + c.charCodeAt(0).toString(16)).slice(-2))
          .join('')
      );
      return JSON.parse(jsonPayload);
    } catch (error) {
      console.error('Error decoding JWT token', error);
      return null;
    }
  }

  getUserRole(): string | null {
    const decoded = this.decodeToken();
    // Maps standard JWT role claims — adjust key based on your backend naming pattern
    return decoded ? decoded.role || decoded['http://schemas.microsoft.com/ws/2008/06/identity/claims/role'] : null;
  }
}