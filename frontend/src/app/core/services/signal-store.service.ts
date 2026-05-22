import { Injectable, signal, computed } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class SignalStoreService {
  // Read-only private state tracking variables
  private readonly _isLoading = signal<boolean>(false);
  private readonly _currentUser = signal<any | null>(null);

  // Public globally exposed read-only signals
  readonly isLoading = this._isLoading.asReadonly();
  readonly currentUser = this._currentUser.asReadonly();
  readonly isAuthenticated = computed(() => this._currentUser() !== null);

  showLoader(): void {
    this._isLoading.set(true);
  }

  hideLoader(): void {
    this._isLoading.set(false);
  }

  setCurrentUser(user: any): void {
    this._currentUser.set(user);
  }

  clearStore(): void {
    this._isLoading.set(false);
    this._currentUser.set(null);
  }
}