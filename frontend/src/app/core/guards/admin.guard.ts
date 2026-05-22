import { inject } from '@angular/core';
import { CanActivateFn, Router } from '@angular/router';
import { JwtService } from '../services/jwt.service';

export const adminGuard: CanActivateFn = (route, state) => {
  const jwtService = inject(JwtService);
  const router = inject(Router);

  // Replace this placeholder with your token decoding / role check logic
  if (jwtService.getUserRole() === 'Admin') {
    return true;
  }

  router.navigate(['/unauthorized']);
  return false;
};