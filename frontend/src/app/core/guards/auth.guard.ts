import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { StorageService } from '../services/storage.service';

export const authGuard: CanActivateFn = (route, state) => {
  const storageService = inject(StorageService);
  const router = inject(Router);

  // Replace this placeholder logic with your actual auth state verification later
  if (storageService.isLoggedIn()) {
    return true;
  }

  // Redirect unauthenticated users to the login screen
  router.navigate(['/login'], { queryParams: { returnUrl: state.url } });
  return false;
};